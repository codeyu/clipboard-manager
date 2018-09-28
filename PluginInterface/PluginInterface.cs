using System;
using System.Collections;
using System.Collections.Specialized;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace PluginInterface{
    public interface IPlugin{
        string PlugName { get; }
        string PlugDescription { get; }
        string PlugAuthor { get; }
        string PlugVersion { get; }

        int PlugID { get; set; }

        bool HasIcon { get; }
        bool IsAboutFormPresent { get; }
        bool IsOptionsFormPresent { get; }

        ArrayList PlugFormats { get; }
        IPluginHost Host { get; set; }
        NameValueCollection PlugOptions { get; set; }
        Form AboutForm { get; }
        Form OptionsForm { get; }
        Image PlugImage { get; }

        void Init();
        void Execute(object data);
        void Unload();
    }

    public interface IPluginHost{
        void LoadPluginFormats(IPlugin plugin);
        void UnloadPluginFormats(IPlugin plugin);

        NameValueCollection ReadPluginOptions(IPlugin plugin);
        void WritePluginOptions(IPlugin plugin);
    }
}
