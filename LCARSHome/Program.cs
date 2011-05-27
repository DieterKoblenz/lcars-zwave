using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LCARSHome
{
    static class Program
    {
        internal static MainForm _MainForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            _MainForm = new MainForm();
            Application.Run(_MainForm);
        }
    }
}
