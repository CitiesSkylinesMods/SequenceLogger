namespace SequenceLogger.Events {
    using SequenceLogger.Util;

    public class LoadingManagerEvents {

        public static void Start() {
            LoadingManager.instance.m_introLoaded += OnIntroLoaded;
            LoadingManager.instance.m_levelLoaded += OnLevelLoaded;
            LoadingManager.instance.m_levelPreLoaded += OnLevelPreLoaded;
            LoadingManager.instance.m_levelPreUnloaded += OnLevelPreUnloaded;
            LoadingManager.instance.m_levelUnloaded += OnLevelUnloaded;
        }

        public static void Stop() {
            LoadingManager.instance.m_introLoaded += OnIntroLoaded;
            LoadingManager.instance.m_levelLoaded += OnLevelLoaded;
            LoadingManager.instance.m_levelPreLoaded += OnLevelPreLoaded;
            LoadingManager.instance.m_levelPreUnloaded += OnLevelPreUnloaded;
            LoadingManager.instance.m_levelUnloaded += OnLevelUnloaded;
        }

        public static void OnIntroLoaded() {
            Log.Info("LoadingManager.instance.m_introLoaded");
        }

        public static void OnLevelLoaded(SimulationManager.UpdateMode mode) {
            Log.Info("LoadingManager.instance.m_levelLoaded({mode})");
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
    }
}
