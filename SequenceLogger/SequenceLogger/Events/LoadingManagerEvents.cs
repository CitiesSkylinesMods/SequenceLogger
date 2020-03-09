namespace SequenceLogger.Events {
    using SequenceLogger.Util;

    /// <summary>
    /// Logs <see cref="LoadingManager"/> events.
    /// </summary>
    public class LoadingManagerEvents {

        /// <summary>
        /// Add event listeners.
        /// </summary>
        public static void Start() {
            LoadingManager mgr = LoadingManager.instance;
            mgr.m_introLoaded += OnIntroLoaded;
            mgr.m_levelLoaded += OnLevelLoaded;
            mgr.m_levelPreLoaded += OnLevelPreLoaded;
            mgr.m_levelPreUnloaded += OnLevelPreUnloaded;
            mgr.m_levelUnloaded += OnLevelUnloaded;
            mgr.m_metaDataReady += OnMetaDataReady;
            mgr.m_simulationDataReady += OnSimulationDataReady;
        }

        /// <summary>
        /// Remove event listeners.
        /// </summary>
        public static void Stop() {
            LoadingManager mgr = LoadingManager.instance;
            mgr.m_introLoaded -= OnIntroLoaded;
            mgr.m_levelLoaded -= OnLevelLoaded;
            mgr.m_levelPreLoaded -= OnLevelPreLoaded;
            mgr.m_levelPreUnloaded -= OnLevelPreUnloaded;
            mgr.m_levelUnloaded -= OnLevelUnloaded;
            mgr.m_metaDataReady -= OnMetaDataReady;
            mgr.m_simulationDataReady -= OnSimulationDataReady;
        }

        /// <summary>
        /// Triggered just before main menu is displayed after app launch.
        ///
        /// A useful point to perform compatibility checks. UIView and other
        /// useful classes have been instantiated by this point.
        /// </summary>
        public static void OnIntroLoaded() {
            Log.Info("LoadingManager.instance.m_introLoaded");
        }

        public static void OnLevelLoaded(SimulationManager.UpdateMode mode) {
            Log.Info($"LoadingManager.instance.m_levelLoaded({mode})");
        }

        public static void OnLevelPreLoaded() {
            Log.Info("LoadingManager.instance.m_levelPreLoaded");
        }

        public static void OnLevelPreUnloaded() {
            Log.Info("LoadingManager.instance.m_levelPreUnloaded");
        }

        public static void OnLevelUnloaded() {
            Log.Info("LoadingManager.instance.m_levelUnloaded");
        }

        public static void OnMetaDataReady() {
            Log.Info("LoadingManager.instance.m_metaDataReady");
        }

        public static void OnSimulationDataReady() {
            Log.Info("LoadingManager.instance.m_simulationDataReady");
        }
    }
}
