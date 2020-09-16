using System;
using System.Collections.Generic;
using System.IO;
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

            GlobalConfig.VersionCheck();

            // TODO - See if this user has configuration file!
            DirectoryInfo configDirectory = new DirectoryInfo(Application.LocalUserAppDataPath);
            if (configDirectory.GetFiles("*.txt").Count() >= 1)
            {
                GlobalConfig.ConfigurationSetup(true);
            }
            else
            {
                MessageBox.Show("ARTCC / FIR Configuration could not be found\n\nIt is highly recomended to set up your ARTCC / FIR.\n\nDefault ARTCC / FIR Settings are loaded to start!");
                GlobalConfig.ConfigurationSetup(false);
            }

            Application.Run(new MainForm());
            //Application.Run(new ConfigureArtccForm());

        }
    }
}
