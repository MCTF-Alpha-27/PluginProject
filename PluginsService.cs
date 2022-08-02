using PluginFrame;
using System;
using System.IO;
using System.Reflection;

namespace PluginsService
{
    public class Plugins
    {
        private string pluginsFolder;

        public Plugins(string pluginsFolder)
        {
            this.pluginsFolder = pluginsFolder;
        }

        public void LoadAndRunAllPlugins()
        {
            try
            {
                string[] plugins = Directory.GetFiles(pluginsFolder, "*.dll");
                foreach (string plugin in plugins)
                {
                    Assembly assembly = Assembly.LoadFrom(plugin);
                    Type[] types = assembly.GetTypes();
                    foreach (Type type in types)
                    {
                        if (type.GetInterface("IPlugin") != null)
                        {
                            IPlugin plug = Activator.CreateInstance(type) as IPlugin;
                            plug.Main();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("运行插件时发生错误");
                Console.WriteLine(e.Message);
            }
            
        }

        public string GetPluginName(string plugin)
        {
            try
            {
                Assembly assembly = Assembly.LoadFrom($"{pluginsFolder}/{plugin}.dll");
                IPlugin plug = Activator.CreateInstance(assembly.GetTypes()[0]) as IPlugin;
                return plug.PluginName;
            }
            catch (Exception e)
            {
                Console.WriteLine("获取插件名称时发生错误");
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public string GetPluginVersion(string plugin)
        {
            try
            {
                Assembly assembly = Assembly.LoadFrom($"{pluginsFolder}/{plugin}.dll");
                IPlugin plug = Activator.CreateInstance(assembly.GetTypes()[0]) as IPlugin;
                return plug.PluginVersion;
            }
            catch (Exception e)
            {
                Console.WriteLine("获取插件版本时发生错误");
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public string GetPluginDescription(string plugin)
        {
            try
            {
                Assembly assembly = Assembly.LoadFrom($"{pluginsFolder}/{plugin}.dll");
                IPlugin plug = Activator.CreateInstance(assembly.GetTypes()[0]) as IPlugin;
                return plug.PluginDescription;
            }
            catch (Exception e)
            {
                Console.WriteLine("获取插件介绍时发生错误");
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public void RunPlugin(string plugin)
        {
            try
            {
                Assembly assembly = Assembly.LoadFrom($"{pluginsFolder}/{plugin}.dll");
                IPlugin plug = Activator.CreateInstance(assembly.GetTypes()[0]) as IPlugin;
                plug.Main();
            }
            catch (Exception e)
            {
                Console.WriteLine("运行插件时发生错误");
                Console.WriteLine(e.Message);
            }
        }
    }
}
