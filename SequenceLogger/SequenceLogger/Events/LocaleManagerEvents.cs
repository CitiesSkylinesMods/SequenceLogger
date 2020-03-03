namespace SequenceLogger.Events {
    using ColossalFramework.Globalization;
    using SequenceLogger.Util;

    class LocaleManagerEvents {

        public static void Start() {
            LocaleManager.eventLocaleChanged += OnLocaleChanged;
        }

        public static void Stop() {
            LocaleManager.eventLocaleChanged -= OnLocaleChanged;
        }

        public static void OnLocaleChanged() {
            Log.Info("LocaleManager.eventLocaleChanged");
        }
    }
}
