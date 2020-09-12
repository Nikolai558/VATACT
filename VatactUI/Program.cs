using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using VatactLibrary;

namespace VatactUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // TODO - Version Check and Download, call the function here?
            GlobalConfig.VersionCheck();

            // TODO - See if this user has configuration file!
            //MessageBox.Show("ARTCC Configuration could not be found\n\nIt is highly recomended to set up your ARTCC\n\nDefault ARTCC Settings are Loaded to start!");
            GlobalConfig.ConfigurationSetup(false);

            Application.Run(new MainForm());
        }
    }
}
