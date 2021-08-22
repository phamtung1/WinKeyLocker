using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinKeyLocker
{
    static class Program
    {
        private static string AppGuid = "fca3439d-a52f-43d8-bb22-7405472ad9b4";

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (Mutex mutex = new Mutex(false, AppGuid))
            {
                if (!mutex.WaitOne(0, false))
                {
                    MessageBox.Show(Application.ProductName + " already running");
                    return;
                }


                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                Application.Run(new Form1());
            }

        }
    }
}
