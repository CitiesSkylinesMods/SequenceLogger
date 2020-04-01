namespace SequenceLogger {
    using SequenceLogger.Events;
    using SequenceLogger.Util;
    using ColossalFramework.UI;
    using ICities;
    using System.IO;
    using UnityEngine;

    /// <summary>
    /// Renders the settings UI.
    /// </summary>
    public class Settings {

        /// <summary>
        /// Define components for settings UI.
        /// </summary>
        /// 
        /// <param name="panel">UI helper from the game.</param>
        public static void Render(UIHelperBase panel) {

            UIHelperBase group = panel.AddGroup("Which events should be logged?");

            bool selected = Options.Instance.LogLoadingManager;
            group.AddCheckbox("Loading Manager", selected, sel => {
                Options.Instance.LogLoadingManager = sel;
                Options.Instance.Save();
                if (sel) {
                    LoadingManagerEvents.Start();
                } else {
                    LoadingManagerEvents.Stop();
                }
            });

            selected = Options.Instance.LogLocaleManager;
            group.AddCheckbox("Locale Manager", selected, sel => {
                Options.Instance.LogLocaleManager = sel;
                Options.Instance.Save();
                if (sel) {
                    LocaleManagerEvents.Start();
                } else {
                    LocaleManagerEvents.Stop();
                }
            });

            selected = Options.Instance.LogPlatformService;
            group.AddCheckbox("Platform Service", selected, sel => {
                Options.Instance.LogPlatformService = sel;
                Options.Instance.Save();
                PlatformServiceEvents.Stop();
                PlatformServiceEvents.Start();
            });

            selected = Options.Instance.LogPlatformServiceUGC;
            group.AddCheckbox("Platform Service - UGCDetails", selected, sel => {
                Options.Instance.LogPlatformServiceUGC = sel;
                Options.Instance.Save();
                PlatformServiceEvents.Stop();
                PlatformServiceEvents.Start();
            });

            selected = Options.Instance.LogPluginManager;
            group.AddCheckbox("Plugin Manager", selected, sel => {
                Options.Instance.LogPluginManager = sel;
                Options.Instance.Save();
                if (sel) {
                    PluginManagerEvents.Start();
                } else {
                    PluginManagerEvents.Stop();
                }
            });

            selected = Options.Instance.LogSceneManager;
            group.AddCheckbox("Scene Manager", selected, sel => {
                Options.Instance.LogSceneManager = sel;
                Options.Instance.Save();
                if (sel) {
                    SceneManagerEvents.Start();
                } else {
                    SceneManagerEvents.Stop();
                }
            });
        }
    }
}
