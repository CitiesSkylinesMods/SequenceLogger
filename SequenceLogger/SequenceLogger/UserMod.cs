namespace SequenceLogger
{
    using ICities;
    using JetBrains.Annotations;
    using SequenceLogger.Events;
    using SequenceLogger.Util;

    public class UserMod : IUserMod {

        [UsedImplicitly]
        public string Name => "Sequence Logger";

        [UsedImplicitly]
        public string Description => "Logs out game event sequence.";

        [UsedImplicitly]
        static UserMod() {
            Log.Info("UserMod.ctor() static");
        }

        [UsedImplicitly]
        public UserMod() {
            Log.Info("UserMod.ctor() instance");
        }

        [UsedImplicitly]
        public void OnEnabled() {
            Log.Info("UserMod.OnEnabled()");
            Start();
        }

        [UsedImplicitly]
        public void OnSettingsUI(UIHelperBase panel) {
            Log.Info("UserMod.OnSettingsUI()");
            Settings.Render(panel);
        }

        [UsedImplicitly]
        public void OnDisabled() {
            Log.Info("UserMod.OnDisabled()");
            Stop();
        }

        internal static void Start() {
            LoadingManagerEvents.Start();
            LocaleManagerEvents.Start();
            PlatformServiceEvents.Start();
            PluginManagerEvents.Start();
            SceneManagerEvents.Start();
        }

        internal static void Stop() {
            LoadingManagerEvents.Stop();
            LocaleManagerEvents.Stop();
            PlatformServiceEvents.Stop();
            PluginManagerEvents.Stop();
            SceneManagerEvents.Stop();
        }
    }
}
