using System;
using PluginFrame;

namespace TestPlugin
{
    public class Test : IPlugin
    {
        public string PluginName => "TestPlugin";

        public string PluginVersion => "1.0";

        public string PluginDescription => "A test plugin";

        public void Main()
        {
            Console.WriteLine("Hello World");
        }
    }
}
