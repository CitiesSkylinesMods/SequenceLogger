namespace SequenceLogger {
    using SequenceLogger.Attributes;
    using SequenceLogger.Util;

    /// <summary>
    /// Log file verbosity options.
    /// </summary>
    [StorageFile("SequenceLogger.Options.xml")] // path: ...\Steam\steamapps\common\Cities_Skylines
    public class Options {
        private static Options instance;
        public static Options Instance => instance ?? (instance = StorageManager<Options>.Load());

        // not implemented yet
        public bool ResetLogOnHotload { get; set; } = false;

        /// <summary>
        /// Gets or sets a value which indicates whether Loading Manager events should be logged.
        /// </summary>
        public bool LogLoadingManager { get; set; } = true;

        /// <summary>
        /// Gets or sets a value which indicates whether Locale Manager events should be logged.
        /// </summary>
        public bool LogLocaleManager { get; set; } = true;

        /// <summary>
        /// Gets or sets a value which indicates whether non-UGC Platform Service events should be logged.
        /// </summary>
        public bool LogPlatformService { get; set; } = true;

        /// <summary>
        /// Gets or sets a value which indicates whether UGC Platform Service events should be logged.
        /// </summary>
        public bool LogPlatformServiceUGC { get; set; } = true;

        /// <summary>
        /// Gets or sets a value which indicates whether Plugin Manager events should be logged.
        /// </summary>
        public bool LogPluginManager { get; set; } = true;

        /// <summary>
        /// Gets or sets a value which indicates whether Scene Manager events should be logged.
        /// </summary>
        public bool LogSceneManager { get; set; } = true;

        /// <summary>
        /// Save settings to disk.
        /// </summary>
        public void Save() => StorageManager<Options>.Save();
    }
}