using static System.Console;
using PluginComponent.Plugin;

namespace FirstPlugin
{
    /// <summary>
    /// FirstPlugin implements IPlugin.
    /// </summary>
    public class FirstPlugin : IPlugin
    {
        /// <summary> Plugin Name </summary>
        public string Name { get; } = "First";
        
        /// <summary> Execute </summary>
        public void DoAction()
        {
            WriteLine("I`m First Plugin.");
        }
    }
}
