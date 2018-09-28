using System;
using System.Collections;
using System.Collections.Specialized;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;
using PluginInterface;

namespace ClipboardManager{
    public class PluginHost : IPluginHost{
        private Hashtable formatRegistered = new Hashtable();
        private Hashtable colPlugins = new Hashtable();
        private Hashtable nvPluginConfig = new Hashtable();
        private NameValueCollection genSettings = new NameValueCollection();
        private string configFile;

        public Hashtable FormatRegisteredPlugins{
            get { return formatRegistered; }
        }

        public Hashtable LoadedPlugins{
            get { return colPlugins; }
        }

        public NameValueCollection GeneralConfig{
            get { return genSettings; }
            set { genSettings = value; }
        }
        
        public Hashtable PluginConfig{
            get { return nvPluginConfig; }
        }

        public string ConfigFilename{
            set { configFile = value; }
        }

        public PluginHost(){ }

        public void LoadPlugins(string path, string ext){
            try{
                foreach (string File in Directory.GetFiles(path))
                    if (new FileInfo(File).Extension.Equals(ext))
                        LoadPlugin(File);
            }
            catch (DirectoryNotFoundException dnfe){
                MessageBox.Show("Plugin Directory not found\n" + dnfe.Message, 
                                "Error during startup", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadPlugin(string fileName){
            Assembly pluginAssembly = Assembly.LoadFrom(fileName);

            foreach (Type pluginType in pluginAssembly.GetTypes()){
                if (pluginType.IsPublic){
                    if (!pluginType.IsAbstract){
                        Type typeInterface = pluginType.GetInterface("PluginInterface.IPlugin", true);

                        if (typeInterface != null){
                            PluginInstance newPlugin = new PluginInstance();

                            int newPluginID = fileName.GetHashCode();

                            if (newPluginID < 0)
                                newPluginID *= -1;

                            newPlugin.Instance = (IPlugin)Activator.CreateInstance(pluginAssembly.GetType(pluginType.ToString()));
                            newPlugin.Instance.Host = this;
                            newPlugin.Instance.PlugID = newPluginID;
                            
                            NameValueCollection pluginOption = (NameValueCollection)nvPluginConfig[newPluginID];

                            if ((pluginOption != null) && (pluginOption.Count != 0))
                                newPlugin.Instance.PlugOptions = pluginOption;

                            if ((pluginOption != null) && (pluginOption["EnabledPlugin"] != null)) {
                                try {
                                    newPlugin.Enabled = bool.Parse(pluginOption["EnabledPlugin"]);
                                }
                                catch (FormatException fe) {
                                    MessageBox.Show("Error parsing the configuration file.\n" + fe.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    newPlugin.Enabled = true;
                                }
                            }
                            else
                                newPlugin.Enabled = true;

                            newPlugin.Instance.Init();

                            if (colPlugins[newPluginID] == null){
                                LoadPluginFormats(newPlugin.Instance);
                                WritePluginOptions(newPlugin.Instance);
                                colPlugins.Add(newPluginID, newPlugin);
                            }
                        }
                    }
                }
            }
        }

        public void RemovePlugins(){
            foreach (int pluginID in colPlugins.Keys){
                PluginInstance plugin = (PluginInstance)colPlugins[pluginID];

                plugin.Instance.Unload();
                WritePluginOptions(plugin.Instance);
                plugin.Instance = null;
            }

            colPlugins.Clear();
            formatRegistered.Clear();
        }

        public void RemovePlugin(int pluginID){
            PluginInstance plugin = (PluginInstance)colPlugins[pluginID];

            if (plugin != null){
                UnloadPluginFormats(plugin.Instance);

                plugin.Instance.Unload();
                WritePluginOptions(plugin.Instance);
                plugin.Instance = null;

                colPlugins.Remove(pluginID);
            }
        }

        public void LoadPluginFormats(IPlugin plugin){
            ArrayList formatsToRegister = plugin.PlugFormats;

            foreach (string format in formatsToRegister){
                if (formatRegistered.ContainsKey(format)){
                    ArrayList PluginRegistered = (ArrayList)formatRegistered[format];

                    if (!PluginRegistered.Contains(plugin.PlugID))
                        PluginRegistered.Add(plugin.PlugID);
                }
                else{
                    ArrayList formatList = new ArrayList();
                    formatList.Add(plugin.PlugID);

                    formatRegistered.Add(format, formatList);
                }
            }
        }

        public void UnloadPluginFormats(IPlugin plugin){
            ArrayList formats = plugin.PlugFormats;

            foreach (string format in formats){
                if (formatRegistered.ContainsKey(format)){
                    ((ArrayList)formatRegistered[format]).Remove(plugin.PlugID);
                }
            }
        }

        public NameValueCollection ReadPluginOptions(IPlugin plugin) {
            NameValueCollection pluginSetting = (NameValueCollection)nvPluginConfig[plugin.PlugID];

            return pluginSetting;
        }

        public void WritePluginOptions(IPlugin plugin){
            if (nvPluginConfig.ContainsKey(plugin.PlugID))
                nvPluginConfig.Remove(plugin.PlugID);

            nvPluginConfig.Add(plugin.PlugID, plugin.PlugOptions);

            WriteOptions();
        }

        public void WriteOptions(){
            try{
                XmlDocument settings = new XmlDocument();
                XmlNode node = settings.CreateXmlDeclaration("1.0", "utf-8", null);
                XmlAttribute attribute;
                settings.AppendChild(node);

                XmlNode root = settings.CreateElement("ClipManSettings");
                XmlNode rootGeneral = settings.CreateElement("General");
                XmlNode rootPlugin = settings.CreateElement("Plugin");

                settings.AppendChild(root);
                root.AppendChild(rootGeneral);
                root.AppendChild(rootPlugin);

                foreach (string name in genSettings.Keys){
                    node = settings.CreateElement("Setting");
                    attribute = settings.CreateAttribute(name);
                    attribute.Value = genSettings[name];
                    node.Attributes.SetNamedItem(attribute);
                    rootGeneral.AppendChild(node);
                }

                foreach (int plugID in nvPluginConfig.Keys){
                    XmlNode nodeName = settings.CreateElement("CMP" + plugID.ToString());

                    NameValueCollection nvPlugin = (NameValueCollection)nvPluginConfig[plugID];

                    foreach (string name in nvPlugin.Keys){
                        node = settings.CreateElement("Setting");
                        attribute = settings.CreateAttribute(name);
                        attribute.Value = nvPlugin[name];
                        node.Attributes.SetNamedItem(attribute);
                        nodeName.AppendChild(node);
                    }

                    rootPlugin.AppendChild(nodeName);
                }

                settings.Save(configFile);
            }
            catch (XmlException xe){
                MessageBox.Show("Error parsing the configuration file.\n" + xe.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (UnauthorizedAccessException uae){
                MessageBox.Show("Error accessing the configuration file.\n" + uae.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public class PluginInstance{
        private IPlugin myInstance = null;
        private bool enabled = false;

        public bool Enabled{
            get { return enabled; }
            set { 
                if (myInstance.PlugOptions["EnabledPlugin"] != null)
                    myInstance.PlugOptions.Remove("EnabledPlugin");

                myInstance.PlugOptions.Add("EnabledPlugin", value.ToString());

                enabled = value;
            }
        }

        public IPlugin Instance{
            get { return myInstance; }
            set { myInstance = value; }
        }
    }
}