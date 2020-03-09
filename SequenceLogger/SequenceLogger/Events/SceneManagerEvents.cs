namespace SequenceLogger.Events {
    using SequenceLogger.Util;
    using UnityEngine.SceneManagement;

    /// <summary>
    /// Logs <see cref="SceneManager"/> events.
    /// </summary>
    class SceneManagerEvents {

        /// <summary>
        /// Add event listeners.
        /// </summary>
        public static void Start() {
            SceneManager.activeSceneChanged += OnActiveSceneChanged;
            SceneManager.sceneLoaded += OnSceneLoaded;
            SceneManager.sceneUnloaded += OnSceneUnloaded;
        }

        /// <summary>
        /// Remove event listeners.
        /// </summary>
        public static void Stop() {
            SceneManager.activeSceneChanged -= OnActiveSceneChanged;
            SceneManager.sceneLoaded -= OnSceneLoaded;
            SceneManager.sceneUnloaded -= OnSceneUnloaded;
        }

        /// <summary>
        /// Triggered whenever the scene is going to change.
        ///
        /// Except when intro scenes transition to main menu, but you can use
        /// <see cref="LoadingManager.m_introLoaded"/> event to detect that.
        /// </summary>
        /// 
        /// <param name="from">Scene details for current scene (usually <c>null</c>).</param>
        /// <param name="to">Scene details for replacement scene.</param>
        public static void OnActiveSceneChanged(Scene from, Scene to) {
            Log.Info($"SceneManager.activeSceneChanged({from.name}, {to.name})");
        }

        /// <summary>
        /// Triggered when a scene is loaded.
        /// </summary>
        /// 
        /// <param name="scene">Scene details.</param>
        /// <param name="mode">Specifies whether the secene replaced previous scene (singel) or added to it (additive).</param>
        public static void OnSceneLoaded(Scene scene, LoadSceneMode mode) {
            Log.Info($"SceneManager.sceneLoaded({scene.name}, {mode})");
        }

        /// <summary>
        /// Triggered when a scene is unloaded.
        /// </summary>
        /// 
        /// <param name="scene">Scene details.</param>
        public static void OnSceneUnloaded(Scene scene) {
            Log.Info($"SceneManager.sceneUnloaded({scene.name})");
        }
    }
}
