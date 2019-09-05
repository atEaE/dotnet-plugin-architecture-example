using Microsoft.Extensions.Configuration;
using System.IO;

namespace SamplePlugin.Util
{
    public static class SettingsUtil
    {
        /// <summary> Configuration tree </summary>
        private static IConfigurationRoot configuration = new ConfigurationBuilder()
                                                            .SetBasePath(Directory.GetCurrentDirectory())
                                                            .AddJsonFile("appsettings.json", true, true).Build();
        /// <summary>
        /// Get "appSettings" value.
        /// </summary>
        /// <param name="key">key name</param>
        /// <returns>value</returns>
        public static string GetAppSettings(string key)
        {
            var conf = configuration.GetSection("appSettings").GetSection(key);
            return conf.Value ?? "";
        }

        /// <summary>
        /// Execute reload.
        /// </summary>
        public static void Reload()
        {
            configuration.Reload();
        }
    }
}
