namespace SequenceLogger
{
    using ICities;
    using JetBrains.Annotations;
    using SequenceLogger.Util;

    public class LoadingExtension : LoadingExtensionBase {

        [UsedImplicitly]
        static LoadingExtension() {
            Log.Info("LoadingExtension.ctor() static");
        }

        [UsedImplicitly]
        public LoadingExtension() {
            Log.Info("LoadingExtension.ctor() instance");
        }

        [UsedImplicitly]
        public override void OnCreated(ILoading loading) {
            Log.Info("LoadingExtension.OnCreated(...):");
            Log.Info($"- Mode: {loading.currentMode}");
            Log.Info($"- Theme: {loading.currentTheme}");
            Log.Info($"- Complete: {loading.loadingComplete}");
            base.OnCreated(loading);
        }

        [UsedImplicitly]
        public override void OnLevelLoaded(LoadMode mode) {
            Log.Info($"LoadingExtension.OnLevelLoaded({mode})");
            base.OnLevelLoaded(mode);
        }

        [UsedImplicitly]
        public override void OnLevelUnloading() {
            Log.Info("LoadingExtension.OnLevelUnloading()");
            base.OnLevelUnloading();
        }

        [UsedImplicitly]
        public override void OnReleased() {
            Log.Info("LoadingExtension.OnReleased()");
            base.OnReleased();
        }
    }
}
