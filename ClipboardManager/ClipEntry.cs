using System;

namespace ClipboardManager {
    public enum ClipEntryType { Text = 0, 
                                Bitmap = 1, 
                                FileDrop = 2, 
                                Html = 3,
                                Rtf = 4,
                                Special = 5
                              };
    
    public class ClipEntry {
		private string messageHeader = "";
		private string messageText = "";
        private string[] formats;
        private string principalFormat;

        private int formatNumber = 0;

        private object dataFormatted;
        private object dataForPlugins;
        private object secondaryDataForPlugins;
        
        private ClipEntryType entryType = ClipEntryType.Text;

		public string MessageText{
            get { return messageText; }
            set { messageText = value; }
		}

		public string MessageHeader{
            get { return messageHeader; }
		}

        public string[] Formats {
            get { return formats; }
        }

        public string PrincipalFormat {
            get { return principalFormat; }
        }

        public int FormatNumber {
            get { return formatNumber; }
        }

        public object FormattedData {
            get { return dataFormatted; }
            set { dataFormatted = value; }
        }

        public object PluginData {
            get { return dataForPlugins; }
            set { dataForPlugins = value; }
        }

        public object SecondaryPluginData {
            get { return secondaryDataForPlugins; }
        }

        public ClipEntryType MessageType {
            get { return entryType; }
		}

        public ClipEntry(ClipEntryType type, string MessageHeader, string MessageText, string[] Formats, 
                         object FormatData, object PluginData, string PrincipalFormat, object SecondPluginData) {
            entryType = type;

            messageHeader = MessageHeader;
            messageText = MessageText;
            formats = Formats;
            
            dataFormatted = FormatData;
            dataForPlugins = PluginData;
            secondaryDataForPlugins = SecondPluginData;

            principalFormat = PrincipalFormat;

            formatNumber = formats.Length;
        }
	}
}
