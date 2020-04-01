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
            if (Options.Instance.LogLoadingManager) {
                LoadingManager mgr = LoadingManager.instance;
                mgr.m_introLoaded += OnIntroLoaded;
                mgr.m_levelLoaded += OnLevelLoaded;
                mgr.m_levelPreLoaded += OnLevelPreLoaded;
                mgr.m_levelPreUnloaded += OnLevelPreUnloaded;
                mgr.m_levelUnloaded += OnLevelUnloaded;
                mgr.m_metaDataReady += OnMetaDataReady;
                mgr.m_simulationDataReady += OnSimulationDataReady;
            }
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
        private static void OnIntroLoaded() {
            Log.Info("LoadingManager.instance.m_introLoaded");
        }

        private static void OnLevelLoaded(SimulationManager.UpdateMode mode) {
            Log.Info($"LoadingManager.instance.m_levelLoaded({mode})");
        }

        private static void OnLevelPreLoaded() {
            Log.Info("LoadingManager.instance.m_levelPreLoaded");
        }

        private static void OnLevelPreUnloaded() {
            Log.Info("LoadingManager.instance.m_levelPreUnloaded");
        }

        private static void OnLevelUnloaded() {
            Log.Info("LoadingManager.instance.m_levelUnloaded");
        }

        private static void OnMetaDataReady() {
            Log.Info("LoadingManager.instance.m_metaDataReady");
        }

        private static void OnSimulationDataReady() {
            Log.Info("LoadingManager.instance.m_simulationDataReady");
        }
    }
}
