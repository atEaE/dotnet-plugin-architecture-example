namespace PluginComponent.Plugin
{
    /// <summary>
    /// Plugin Interface
    /// </summary>
    public interface IPlugin
    {
        /// <summary> Plugin name </summary>
        string Name { get; }
        /// <summary>  </summary>
        void DoAction();
    }
}
