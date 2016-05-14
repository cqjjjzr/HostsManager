using System;
using System.IO;
using System.Windows.Forms;

namespace HostsManagerConfigurationTool
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (!File.Exists("C:\\HostsManager\\config.json"))
                Application.Run(new frmFirst());
            else
                Application.Run(new frmMain());
        }
    }
}
