namespace SequenceLogger
{
    using ICities;
    using JetBrains.Annotations;
    using SequenceLogger.Util;

    public class LoadingExtension : LoadingExtensionBase {

        /// <summary>
        /// Initializes static members of the <see cref="LoadingExtension"/> class.
        /// </summary>
        [UsedImplicitly]
        static LoadingExtension() {
            Log.Info("LoadingExtension.ctor() static");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoadingExtension"/> class.
        /// </summary>
        [UsedImplicitly]
        public LoadingExtension() {
            Log.Info("LoadingExtension.ctor() instance");
        }

        /// <summary>
        /// Triggered when the extension is created.
        /// </summary>
        /// 
        /// <param name="loading">Loading information.</param>
        [UsedImplicitly]
        public override void OnCreated(ILoading loading) {
            Log.Info("LoadingExtension.OnCreated(...):");
            Log.Info($"- Mode: {loading.currentMode}");
            Log.Info($"- Theme: {loading.currentTheme}");
            Log.Info($"- Complete: {loading.loadingComplete}");
            base.OnCreated(loading);
        }

        /// <summary>
        /// Triggered after level finishes loading.
        ///
        /// Note: Mod errors can prevent this event from being triggered.
        /// </summary>
        /// 
        /// <param name="mode">The <see cref="LoadMode"/> for the level.</param>
        [UsedImplicitly]
        public override void OnLevelLoaded(LoadMode mode) {
            Log.Info($"LoadingExtension.OnLevelLoaded({mode})");
            base.OnLevelLoaded(mode);
        }

        /// <summary>
        /// Triggered when level starts unloading.
        ///
        /// Note: Mod errors can prevent this event from being triggered.
        /// </summary>
        [UsedImplicitly]
        public override void OnLevelUnloading() {
            Log.Info("LoadingExtension.OnLevelUnloading()");
            base.OnLevelUnloading();
        }

        /// <summary>
        /// Triggered when the extension is released.
        /// </summary>
        [UsedImplicitly]
        public override void OnReleased() {
            Log.Info("LoadingExtension.OnReleased()");
            base.OnReleased();
        }
    }
}
