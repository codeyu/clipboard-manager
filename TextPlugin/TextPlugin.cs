using System;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using PluginInterface;

namespace TextPlugin{
    public partial class TextPlugin : Form, IPlugin{
        [DllImport("user32.dll", EntryPoint = "WindowFromPoint")]
        static extern IntPtr WindowFromPoint(Point Point);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        static extern uint GetWindowThreadProcessId(IntPtr hWnd, uint lpdwProcessId);

        [DllImport("user32.dll")]
        static extern bool AttachThreadInput(uint idAttach, uint idAttachTo, bool fAttach);

        [DllImport("user32.dll")]
        static extern IntPtr GetFocus();

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", EntryPoint = "GlobalAddAtomA", SetLastError = true)]
        static extern Int16 GlobalAddAtom(string lpString);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern Int16 GlobalDeleteAtom(Int16 nAtom);

        [DllImport("user32.dll", SetLastError = true)]
        static extern Int32 RegisterHotKey(IntPtr hwnd, Int32 id, Int32 fsModifiers, Int32 vk);

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool UnregisterHotKey(IntPtr hWnd, Int32 id);

        const int MOD_ALT = 0x0001;
        const int MOD_CONTROL = 0x0002;
        const int MOD_SHIFT = 0x0004;

        const int WM_PASTE = 0x0302;
        const int WM_HOTKEY = 0x0312;

        Int16 firstAtomID;
        Int16 currentAtomID;
        Int16 previousAtomID;
        Int16 nextAtomID;

        string myName = "Text Plugin";
        string myDescription = "Plugin to manage text copied in the clipboard";
        string myAuthor = "Francesco Ielpi";
        string myVersion = "1.0.0";

        int myID;

        bool hasIcon = true;
        bool isAboutFormPresent = false;
        bool isOptionsFormPresent = true;
        bool addEmail;
        bool addURL;

        ArrayList myFormats = new ArrayList();
        NameValueCollection myOptions = new NameValueCollection();

        EntryList entries = new EntryList();

        IPluginHost myHost = null;

        public TextPlugin(){
            InitializeComponent();

            myFormats.Add(DataFormats.Text);
        }

        public string PlugName{
            get { return myName; }
        }

        public string PlugDescription{
            get { return myDescription; }
        }

        public string PlugAuthor{
            get { return myAuthor; }
        }

        public string PlugVersion{
            get { return myVersion; }
        }

        public int PlugID{
            get { return myID; }
            set { myID = value; }
        }

        public bool HasIcon{
            get { return hasIcon; }
        }

        public bool IsAboutFormPresent{
            get { return isAboutFormPresent; }
        }

        public bool IsOptionsFormPresent{
            get { return isOptionsFormPresent; }
        }

        public ArrayList PlugFormats{
            get { return myFormats; }
        }

        public NameValueCollection PlugOptions{
            get { return myOptions; }
            set { myOptions = value; }
        }

        public IPluginHost Host{
            get { return myHost; }
            set { myHost = value; }
        }

        public Form AboutForm{
            get { return null; }
        }

        public EntryList Entries {
            get { return entries; }
            set { entries = value; }
        }

        public Form OptionsForm{
            get{
                OptionsForm optForm = new OptionsForm(this);
                optForm.TextSettings = myOptions;

                return optForm;
            }
        }

        public Image PlugImage{
            get { return Properties.Resources.text; }
        }

        public void Init(){
            if (myOptions["AddEmailToList"] == null)
                myOptions.Add("AddEmailToList", "true");

            if (myOptions["AddUrlToList"] == null)
                myOptions.Add("AddUrlToList", "true");

            if (myOptions["CatchEmail"] == null)
                myOptions.Add("CatchEmail", "false");

            if (myOptions["CatchUrl"] == null)
                myOptions.Add("CatchUrl", "false");

            if (myOptions["EntryListLength"] == null)
                myOptions.Add("EntryListLength", "10");

            if (myOptions["FirstEntryCtrlMod"] == null)
                myOptions.Add("FirstEntryCtrlMod", "true");

            if (myOptions["FirstEntryAltMod"] == null)
                myOptions.Add("FirstEntryAltMod", "true");

            if (myOptions["FirstEntryShiftMod"] == null)
                myOptions.Add("FirstEntryShiftMod", "true");

            if (myOptions["FirstEntryHotKey"] == null)
                myOptions.Add("FirstEntryHotKey", Keys.F.ToString());

            if (myOptions["SelectedEntryCtrlMod"] == null)
                myOptions.Add("SelectedEntryCtrlMod", "true");

            if (myOptions["SelectedEntryAltMod"] == null)
                myOptions.Add("SelectedEntryAltMod", "true");

            if (myOptions["SelectedEntryShiftMod"] == null)
                myOptions.Add("SelectedEntryShiftMod", "true");

            if (myOptions["SelectedEntryHotKey"] == null)
                myOptions.Add("SelectedEntryHotKey", Keys.S.ToString());

            if (myOptions["PreviousEntryCtrlMod"] == null)
                myOptions.Add("PreviousEntryCtrlMod", "true");

            if (myOptions["PreviousEntryAltMod"] == null)
                myOptions.Add("PreviousEntryAltMod", "true");

            if (myOptions["PreviousEntryShiftMod"] == null)
                myOptions.Add("PreviousEntryShiftMod", "true");

            if (myOptions["PreviousEntryHotKey"] == null)
                myOptions.Add("PreviousEntryHotKey", Keys.P.ToString());

            if (myOptions["NextEntryCtrlMod"] == null)
                myOptions.Add("NextEntryCtrlMod", "true");

            if (myOptions["NextEntryAltMod"] == null)
                myOptions.Add("NextEntryAltMod", "true");

            if (myOptions["NextEntryShiftMod"] == null)
                myOptions.Add("NextEntryShiftMod", "true");

            if (myOptions["NextEntryHotKey"] == null)
                myOptions.Add("NextEntryHotKey", Keys.N.ToString());

            if (myOptions["PasteType"] == null)
                myOptions.Add("PasteType", "true");

            InitSettings();

            try {
                RegisterHotKeys();
            }
            catch (Win32Exception w3e) {
                MessageBox.Show("Error registering selected hotkeys:\n" + w3e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void InitSettings() {
            try {
                addEmail = bool.Parse(myOptions["AddEmailToList"]);
                addURL = bool.Parse(myOptions["AddUrlToList"]);

                entries.MaxSize = int.Parse(myOptions["EntryListLength"]);
            }
            catch (FormatException fe) {
                MessageBox.Show("Error parsing the configuration file.\n" + fe.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Execute(object data){
            string text = (string)data;

            bool textIsEmail = isEmail(text);
            bool textIsURL = isURL(text);

            if (textIsEmail){
                if ((addEmail) && (!entries.Contains(text)))
                    entries.Add(text);

                if (bool.Parse(myOptions["CatchEmail"])) {
                    try {
                        Process.Start("mailto:" + text);
                    }
                    catch (Win32Exception w3e) {
                        MessageBox.Show("Error opening the email client:\n" + w3e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (ObjectDisposedException ode) {
                        MessageBox.Show("Error opening the email client:\n" + ode.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (textIsURL){
                if  ((addURL) && (!entries.Contains(text)))
                    entries.Add(text);

                if (bool.Parse(myOptions["CatchUrl"])) {
                    try {
                        Process.Start(text);
                    }
                    catch (Win32Exception w3e) {
                        MessageBox.Show("Error opening the browser:\n" + w3e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (ObjectDisposedException ode) {
                        MessageBox.Show("Error opening the browser:\n" + ode.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if ((!textIsEmail) && (!textIsURL))
                if (!entries.Contains(text))
                    entries.Add(text);
        }

        public void Unload(){
            UnregisterHotKeys();
        }

        private void SetClipboardText(string text){
            try{
                if (text != null){
                    Clipboard.Clear();
                    Clipboard.SetText(text);
                }
            }
            catch (ExternalException ee){
                MessageBox.Show(ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Threading.ThreadStateException tse){
                MessageBox.Show(tse.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MousePointerWindowPaste(){
            SendMessage(WindowFromPoint(Cursor.Position), WM_PASTE, (IntPtr)0, (IntPtr)0);
        }

        private void ForegroundWindowPaste(){
            IntPtr controlHandle = GetBlinkingCaretHandle(GetForegroundWindow());

            if (controlHandle != IntPtr.Zero)
                SendMessage(controlHandle, WM_PASTE, (IntPtr)0, (IntPtr)0);

            /*
            IntPtr winHandle = GetForegroundWindow();
            
            foreach (Process process in Process.GetProcesses()) {
                if (process.MainWindowHandle == winHandle) {
                    Microsoft.VisualBasic.Interaction.AppActivate(process.MainWindowTitle);
                    SendKeys.SendWait("^V");/*
                }
            }
            */
        }

        private IntPtr GetBlinkingCaretHandle(IntPtr windowHandle) {
            IntPtr focusHandle = IntPtr.Zero;

            if (windowHandle != IntPtr.Zero) {
                uint extAppTID = GetWindowThreadProcessId(windowHandle, 0);
                uint thisAppTID = GetWindowThreadProcessId(this.Handle, 0);

                if (extAppTID == thisAppTID)
                    focusHandle = GetFocus();
                else{
                    AttachThreadInput(extAppTID, thisAppTID, true);
                    focusHandle = GetFocus();
                    AttachThreadInput(extAppTID, thisAppTID, false);
                }
            }

            return focusHandle;
        }

        public void RegisterHotKeys(){
            int firstModifiers = 0;
            int currentModifiers = 0;
            int previousModifiers = 0;
            int nextModifiers = 0;

            int firstKeys = 0;
            int currentKeys = 0;
            int previousKeys = 0;
            int nextKeys = 0;

            try {
                if (bool.Parse(myOptions["FirstEntryCtrlMod"]))
                    firstModifiers |= MOD_CONTROL;

                if (bool.Parse(myOptions["FirstEntryAltMod"]))
                    firstModifiers |= MOD_ALT;

                if (bool.Parse(myOptions["FirstEntryShiftMod"]))
                    firstModifiers |= MOD_SHIFT;

                if (bool.Parse(myOptions["SelectedEntryCtrlMod"]))
                    currentModifiers |= MOD_CONTROL;

                if (bool.Parse(myOptions["SelectedEntryAltMod"]))
                    currentModifiers |= MOD_ALT;

                if (bool.Parse(myOptions["SelectedEntryShiftMod"]))
                    currentModifiers |= MOD_SHIFT;

                if (bool.Parse(myOptions["PreviousEntryCtrlMod"]))
                    previousModifiers |= MOD_CONTROL;

                if (bool.Parse(myOptions["PreviousEntryAltMod"]))
                    previousModifiers |= MOD_ALT;

                if (bool.Parse(myOptions["PreviousEntryShiftMod"]))
                    previousModifiers |= MOD_SHIFT;

                if (bool.Parse(myOptions["NextEntryCtrlMod"]))
                    nextModifiers |= MOD_CONTROL;

                if (bool.Parse(myOptions["NextEntryAltMod"]))
                    nextModifiers |= MOD_ALT;

                if (bool.Parse(myOptions["NextEntryShiftMod"]))
                    nextModifiers |= MOD_SHIFT;

                firstKeys = (int)(new KeysConverter()).ConvertFromString(myOptions["FirstEntryHotKey"]);
                currentKeys = (int)(new KeysConverter()).ConvertFromString(myOptions["SelectedEntryHotKey"]);
                previousKeys = (int)(new KeysConverter()).ConvertFromString(myOptions["PreviousEntryHotKey"]);
                nextKeys = (int)(new KeysConverter()).ConvertFromString(myOptions["NextEntryHotKey"]);
            }
            catch (FormatException fe) {
                MessageBox.Show("Error parsing the configuration file.\n" + fe.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            firstAtomID = GlobalAddAtom(DateTime.Now.ToString());
            currentAtomID = GlobalAddAtom(DateTime.Now.AddHours(2).ToString());
            previousAtomID = GlobalAddAtom(DateTime.Now.AddHours(4).ToString());
            nextAtomID = GlobalAddAtom(DateTime.Now.AddHours(6).ToString());

            if ((firstAtomID == 0) || (currentAtomID == 0) || (previousAtomID == 0) || (nextAtomID == 0))
                throw new Win32Exception();

            if (RegisterHotKey(this.Handle, firstAtomID, firstModifiers, firstKeys) == 0)
                throw new Win32Exception();

            if (RegisterHotKey(this.Handle, currentAtomID, currentModifiers, currentKeys) == 0)
                throw new Win32Exception();

            if (RegisterHotKey(this.Handle, previousAtomID, previousModifiers, previousKeys) == 0)
                throw new Win32Exception();

            if (RegisterHotKey(this.Handle, nextAtomID, nextModifiers, nextKeys) == 0)
                throw new Win32Exception();
        }

        public void UnregisterHotKeys() {
            UnregisterHotKey(this.Handle, firstAtomID);
            UnregisterHotKey(this.Handle, currentAtomID);
            UnregisterHotKey(this.Handle, previousAtomID);
            UnregisterHotKey(this.Handle, nextAtomID);

            GlobalDeleteAtom(firstAtomID);
            GlobalDeleteAtom(currentAtomID);
            GlobalDeleteAtom(previousAtomID);
            GlobalDeleteAtom(nextAtomID);
        }

        private bool isEmail(string inputEmail){
            string strRegex = @"^(([^<>()[\]\\.,;:\s@\""]+"
               + @"(\.[^<>()[\]\\.,;:\s@\""]+)*)|(\"".+\""))@"
               + @"((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}"
               + @"\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+"
               + @"[a-zA-Z]{2,}))$";

            Regex rEmail = new Regex(strRegex, RegexOptions.Compiled);
            return rEmail.IsMatch(inputEmail);
        }

        private bool isURL(string inputURL){
            Regex rUrl = new Regex(@"(http|https)://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?", RegexOptions.Compiled);

            inputURL = inputURL.Replace(" ", "").Replace("\r", "").Replace("\n", "").Replace("\t", "").Trim();

            return ((rUrl.IsMatch(inputURL)) && (inputURL.StartsWith("http://")));
        }

        protected override void WndProc(ref Message m){
            switch (m.Msg){
                case WM_HOTKEY:
                    if ((Int16)m.WParam == firstAtomID){
                        entries.ResetEntryIndex();
                        SetClipboardText(entries.CurrentEntry());

                        if (bool.Parse(myOptions["PasteType"]))
                            MousePointerWindowPaste();
                        else
                            ForegroundWindowPaste();
                    }
                    else if ((Int16)m.WParam == currentAtomID){
                        SetClipboardText(entries.CurrentEntry());

                        if (bool.Parse(myOptions["PasteType"]))
                            MousePointerWindowPaste();
                        else
                            ForegroundWindowPaste();
                    }
                    else if ((Int16)m.WParam == previousAtomID){
                        SetClipboardText(entries.PreviousEntry());

                        if (bool.Parse(myOptions["PasteType"]))
                            MousePointerWindowPaste();
                        else
                            ForegroundWindowPaste();
                    }
                    else if ((Int16)m.WParam == nextAtomID){
                        SetClipboardText(entries.NextEntry());

                        if (bool.Parse(myOptions["PasteType"]))
                            MousePointerWindowPaste();
                        else
                            ForegroundWindowPaste();
                    }

                    break;

                default:
                    base.WndProc(ref m);

                    break;
            }
        }
    }
}