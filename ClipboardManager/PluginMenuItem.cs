using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PluginInterface;

namespace ClipboardManager{
    public partial class PluginMenuItem : ToolStripMenuItem{
        private IPlugin pluginMenu;
        private bool enabledMenu;
        private string textMenu;
        private Image imageMenu;

        public override bool Enabled{
            get { return enabledMenu; }
            set { enabledMenu = value; }
        }

        public override Image Image{
            get { return imageMenu; }
            set { imageMenu = value; }
        }

        public override string Text{
            get { return textMenu; }
            set { textMenu = value; }
        }
        
        public PluginMenuItem(IPlugin plugin){
            pluginMenu = plugin;
            textMenu = pluginMenu.PlugName;

            if (pluginMenu.HasIcon)
                imageMenu = pluginMenu.PlugImage;

            if (!pluginMenu.IsOptionsFormPresent)
                enabledMenu = false;
            else
                enabledMenu = true;
        }

        protected override void OnClick(EventArgs e){
            Form optionForm = pluginMenu.OptionsForm;
            optionForm.Show();
        }
    }
}
