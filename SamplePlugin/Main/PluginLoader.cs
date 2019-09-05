using PluginComponent.Plugin;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Loader;

namespace SamplePlugin.Main
{
    /// <summary>
    /// Plugin Loader
    /// </summary>
    public static class PluginLoader
    {
        /// <summary>
        /// Load Plugin For Plugin directory
        /// </summary>
        /// <param name="path">Plugin directory path</param>
        /// <returns>load assembly</returns>
        public static ICollection<IPlugin> LoadPlugins(string path)
        {
            var plugins = new List<IPlugin>();
            if (Directory.Exists(path))
            {
                var dlls = Directory.GetFiles(path, "*.dll")
                            .Select(p => Path.GetFullPath(p)).ToArray();
                var pluginTypes = new List<Type>();
                foreach(var dll in dlls)
                {
                    var assm = AssemblyLoadContext.Default.LoadFromAssemblyPath(dll);
                    
                    if (assm != null)
                    {
                        var types = assm.GetTypes();
                        foreach(var type in types)
                        {
                            if (type.IsInterface || type.IsAbstract)
                            {
                                continue;
                            }
                            else
                            {
                                // implements IPlugin interface
                                if (type.GetInterface(typeof(IPlugin).FullName) != null)
                                {
                                    pluginTypes.Add(type);
                                }
                            }
                        }
                    }
                }

                pluginTypes.ForEach(pType =>
                {
                    var plugin = (IPlugin)Activator.CreateInstance(pType);
                    plugins.Add(plugin);
                });

                return plugins;
            }

            return plugins;
        }
    }
}
