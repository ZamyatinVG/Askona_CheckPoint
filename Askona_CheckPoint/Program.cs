using System;
using System.Windows.Forms;
using System.Threading;

namespace Askona_CheckPoint
{
    static class Program
    {
        private const string appName = "Askona CheckPoint";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            _ = new Mutex(true, appName, out bool tryCreateNewApp);
            if (tryCreateNewApp)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormMain());
                return;
            }
        }
    }
}