namespace SequenceLogger.Events {
    using ColossalFramework.Globalization;
    using SequenceLogger.Util;

    /// <summary>
    /// Logs <see cref="LocaleManager"/> events.
    /// </summary>
    class LocaleManagerEvents {

        /// <summary>
        /// Add event listeners.
        /// </summary>
        public static void Start() {
            LocaleManager.eventLocaleChanged += OnLocaleChanged;
            // LocaleManager.eventLocaleNeedsSubsitution
            // LocaleManager.eventUIComponentLocaleChanged
        }

        /// <summary>
        /// Remove event listeners.
        /// </summary>
        public static void Stop() {
            LocaleManager.eventLocaleChanged -= OnLocaleChanged;
        }

        /// <summary>
        /// Triggered when mod should change locale:
        /// 
        /// * Before first call to <see cref="UserMod.OnSettingsUI()"/>.
        /// * Whenever user changes the game language.
        /// </summary>
        public static void OnLocaleChanged() {
            Log.Info("LocaleManager.eventLocaleChanged");
        }
    }
}
