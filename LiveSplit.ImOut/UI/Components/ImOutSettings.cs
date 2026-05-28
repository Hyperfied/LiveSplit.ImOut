using System;
using System.Drawing;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using System.Xml;

namespace LiveSplit.UI.Components
{
    public partial class ImOutSettings : UserControl
    {
        public new float Height { get; set; }
        public new float Width { get; set; }

        public ImOutSettings()
        {
            InitializeComponent();

            Height = 200;
            Width = 200;
        }
        private int CreateSettingsNode(XmlDocument document, XmlElement parent)
        {
            return SettingsHelper.CreateSetting(document, parent, "Version", "1.0");
        }

        public XmlNode GetSettings(XmlDocument document)
        {
            var parent = document.CreateElement("Settings");
            CreateSettingsNode(document, parent);
            return parent;
        }

        public int GetSettingsHashCode()
        {
            return CreateSettingsNode(null, null);
        }

        public void SetSettings(XmlNode node)
        {
            var element = (XmlElement)node;
        }
    }

}
