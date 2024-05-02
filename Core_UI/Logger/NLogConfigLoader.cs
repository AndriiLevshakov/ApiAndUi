using Newtonsoft.Json;

namespace Core_UI.Logger
{
    public static class NLogConfigLoader
    {
        public static NLogConfiguration LoadConfig(string filePath)
        {
            string json = File.ReadAllText(filePath);

            return JsonConvert.DeserializeObject<NLogConfiguration>(json);
        }
    }
}

