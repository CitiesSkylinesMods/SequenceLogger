namespace SequenceLogger.Events {
    using ColossalFramework;
    using ColossalFramework.Plugins;
    using SequenceLogger.Util;

    /// <summary>
    /// Logs <see cref="PluginManager"/> events.
    /// </summary>
    public class PluginManagerEvents {

        public static void Start() {
            if (Options.Instance.LogPluginManager) {
                PluginManager mgr = Singleton<PluginManager>.instance;
                mgr.eventPluginsChanged += OnPluginsChanged;
                mgr.eventPluginsStateChanged += OnPluginsStateChanged;
            }
        }

        public static void Stop() {
            PluginManager mgr = Singleton<PluginManager>.instance;
            mgr.eventPluginsChanged -= OnPluginsChanged;
            mgr.eventPluginsStateChanged -= OnPluginsStateChanged;
        }

        private static void OnPluginsChanged() {
            Log.Info("PluginManager.eventPluginsChanged");
        }

        private static void OnPluginsStateChanged() {
            Log.Info("PluginManager.eventPluginsStateChanged");
        }
    }
}
