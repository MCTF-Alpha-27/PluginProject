using PluginsService;

public class Program
{
    public static void Main(string[] args)
    {
        Plugins plugins = new("plugins");
        Console.WriteLine("插件名称：" + plugins.GetPluginName("TestPlugin"));
        Console.WriteLine("插件版本：" + plugins.GetPluginVersion("TestPlugin"));
        Console.WriteLine("插件介绍：" + plugins.GetPluginDescription("TestPlugin"));
        plugins.RunPlugin("TestPlugin");
    }
}
