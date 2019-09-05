using static System.Console;
using PluginComponent.Plugin;

namespace SecondPlugin
{
    /// <summary>
    /// FirstPlugin implements IPlugin.
    /// </summary>
    public class SecondPlugin : IPlugin
    {
        /// <summary> Plugin Name </summary>
        public string Name { get; } = "Second";

        /// <summary> Execute </summary>
        public void DoAction()
        {
            WriteLine("I`m Second Plugin.");
        }
    }
}
