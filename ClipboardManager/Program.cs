using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;

namespace ClipboardManager{
    static class Program{
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args){
            Application.ThreadException += new ThreadExceptionEventHandler(UnhandledExceptionHandler.ThreadException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(UnhandledExceptionHandler.UnhandledException);
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (args.Length > 0)
                Application.Run(new MainForm(args[0]));
            else
                Application.Run(new MainForm());
        }
    }

    internal class UnhandledExceptionHandler {
        public static void ThreadException(object sender, ThreadExceptionEventArgs e) {
            try {
                if (MessageBox.Show("An unexpected error was thrown.\nSource: " + e.Exception.Source + "\nMessage: " + e.Exception.Message +
                                    "\n\nIt might be necessary to restart the application.\nDo you want to quit now?",
                                    "Unexpected error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)

                    Application.Exit();
            }
            catch {
                try {
                    MessageBox.Show("Fatal Error", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                finally {
                    Application.Exit();
                }
            }
        }

        public static void UnhandledException(object sender, UnhandledExceptionEventArgs e) {
            try {
                if (MessageBox.Show("An unexpected error was thrown within a thread.\nSource: " + sender.ToString() +
                                "\n\nIt might be necessary to restart the application.\nDo you want to quit now?",
                                "Unexpected error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    
                    Application.Exit();
            }
            catch {
                try {
                    MessageBox.Show("Fatal Error", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                finally {
                    Application.Exit();
                }
            }
        }
    }
}