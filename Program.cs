using System;
using System.Windows.Forms;

namespace L2_login
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.DoEvents();

            Control.CheckForIllegalCrossThreadCalls = false;
            Application.Run(new L2NET(args));
        }
    }
}