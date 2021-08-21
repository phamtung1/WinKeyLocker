using Newtonsoft.Json;
using System.IO;

namespace WinKeyLocker.Helpers
{
    public static class AppSettingHelper
    {
        private const string DEFAULT_FILENAME = "settings.json";

        public static void Save<T>(T pSettings, string fileName = DEFAULT_FILENAME)
        {
            File.WriteAllText(fileName, JsonConvert.SerializeObject(pSettings));
        }

        public static T Load<T>(string fileName = DEFAULT_FILENAME) where T: new()
        {
            T t = new T();
            if (File.Exists(fileName))
                t = JsonConvert.DeserializeObject<T>(File.ReadAllText(fileName));
            return t;
        }
    }
}