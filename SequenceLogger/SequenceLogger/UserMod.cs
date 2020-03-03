namespace SequenceLogger
{
    using ICities;
    using JetBrains.Annotations;
    using SequenceLogger.Events;
    using SequenceLogger.Util;
    using UnityEngine.SceneManagement;

    public class UserMod : IUserMod
    {
        [UsedImplicitly]
        public string Name => "Sequence Logger";

        [UsedImplicitly]
        public string Description => "Logs out game event sequence.";

        static UserMod() {
            Log.Info("UserMod.ctor() static");
        }

        public UserMod() {
            Log.Info("UserMod.ctor() instance");
        }

        [UsedImplicitly]
        public void OnEnabled() {
            Log.Info("UserMod.OnEnabled()");

            // listen for events
            LoadingManagerEvents.Start();
            LocaleManagerEvents.Start();
        }

        [UsedImplicitly]
        public void OnSettingsUI(UIHelperBase helper) {
            Log.Info("UserMod.OnSettingsUI()");
        }

        [UsedImplicitly]
        public void OnDisabled() {
            Log.Info("UserMod.OnDisabled()");

            // stop listneing to events
            LoadingManagerEvents.Stop();
            LocaleManagerEvents.Stop();
        }
    }
}
