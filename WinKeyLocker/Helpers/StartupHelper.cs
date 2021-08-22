using Microsoft.Win32;
using System.Diagnostics;
using System.Windows.Forms;

namespace WinKeyLocker.Helpers
{
    public static class StartupHelper
    {
        private const string _autoStartKey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";

        public static bool GetAutoStartup()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(_autoStartKey, false))
            {
                return key.GetValue(Application.ProductName, false) != null;
            }
        }


        public static void SetAutoStartup(bool value)
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(_autoStartKey, true))
            {
                if (value)
                {
                    key.SetValue(Application.ProductName, $"\"{Process.GetCurrentProcess().MainModule.FileName}\"");
                }
                else
                {
                    key.DeleteValue(Application.ProductName, false);
                }
            }
        }
    }
}