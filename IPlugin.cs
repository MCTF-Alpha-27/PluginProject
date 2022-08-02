namespace PluginFrame
{
    public interface IPlugin
    {
        /// <summary>
        /// 插件名称
        /// </summary>
        string PluginName { get; }

        /// <summary>
        /// 插件版本
        /// </summary>
        string PluginVersion { get; }

        /// <summary>
        /// 插件介绍
        /// </summary>
        string PluginDescription { get; }

        /// <summary>
        /// 插件入口方法
        /// </summary> 
        void Main();
    }
}
