namespace SequenceLogger.Events {
    using ColossalFramework;
    using ColossalFramework.Plugins;
    using SequenceLogger.Util;

    /// <summary>
    /// Logs <see cref="PluginManager"/> events.
    /// </summary>
    class PluginManagerEvents {

        public static void Start() {
            PluginManager mgr = Singleton<PluginManager>.instance;
            mgr.eventPluginsChanged += OnPluginsChanged;
            mgr.eventPluginsStateChanged += OnPluginsStateChanged;
        }

        public static void Stop() {
            PluginManager mgr = Singleton<PluginManager>.instance;
            mgr.eventPluginsChanged -= OnPluginsChanged;
            mgr.eventPluginsStateChanged -= OnPluginsStateChanged;
        }

        public static void OnPluginsChanged() {
            Log.Info("PluginManager.eventPluginsChanged");
        }

        public static void OnPluginsStateChanged() {
            Log.Info("PluginManager.eventPluginsStateChanged");
        }
    }
}
