using SamplePlugin.Util;
using System.Linq;
using static System.Console;

namespace SamplePlugin.Main
{
    /// <summary>
    /// Sample Plugin MainClass
    /// </summary>
    public class SamplePluginMain
    {
        /// <summary>
        /// Do Action.
        /// </summary>
        public void Execute()
        {
            var plugins = PluginLoader.LoadPlugins(SettingsUtil.GetAppSettings("pluginPath"));

            WriteLine("=== MENU ====");
            foreach(var plugin in plugins.Select((value, i) => new { value, i}))
            {
                WriteLine("[{0:00}] : {1}", plugin.i, plugin.value.Name);
            }
            WriteLine("[ z] : END");

            var endflag = false;
            do
            {
                var input = ReadLine();
                if (input != "z")
                {
                    if (!int.TryParse(input, out int result) || plugins.Count <= result)
                    {
                        WriteLine("Please input again.");
                    }
                    else
                    {
                        plugins.ElementAt(result).DoAction();
                    }
                }
                else
                {
                    endflag = true;
                }
            }
            while (!endflag);            
        }
    }
}
