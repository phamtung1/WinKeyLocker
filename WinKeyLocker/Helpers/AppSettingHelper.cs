using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;

namespace WinKeyLocker.Helpers
{
    public static class AppSettingHelper
    {
        private const string DEFAULT_FILENAME = "settings.json";

        public static void Save<T>(T pSettings, string fileName = DEFAULT_FILENAME)
        {
            string apppath = Path.GetDirectoryName(Application.ExecutablePath);

            var fullPath = Path.Combine(apppath, fileName);
            File.WriteAllText(fullPath, JsonConvert.SerializeObject(pSettings));
        }

        public static T Load<T>(string fileName = DEFAULT_FILENAME) where T : new()
        {
            string apppath = Path.GetDirectoryName(Application.ExecutablePath);

            var fullPath = Path.Combine(apppath, fileName);
            T t = new T();
            if (File.Exists(fullPath))
                t = JsonConvert.DeserializeObject<T>(File.ReadAllText(fullPath));
            return t;
        }
    }
}