namespace SequenceLogger
{
    using ICities;
    using JetBrains.Annotations;
    using SequenceLogger.Util;

    /// <summary>
    /// Logs <see cref="ThreadingExtension"/> events.
    ///
    /// Per-frame events are not logged as they would grind game to a halt.
    /// </summary>
    public class ThreadingExtension : ThreadingExtensionBase {

        /// <summary>
        /// Initializes static members of the <see cref="ThreadingExtension"/> class.
        /// </summary>
        [UsedImplicitly]
        static ThreadingExtension() {
            Log.Info("ThreadingExtension.ctor() static");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadingExtension"/> class.
        /// </summary>
        [UsedImplicitly]
        public ThreadingExtension() {
            Log.Info("ThreadingExtension.ctor() instance");
        }

        /// <summary>
        /// Triggered when the extension is created.
        /// </summary>
        /// 
        /// <param name="threading">Threading information.</param>
        [UsedImplicitly]
        public override void OnCreated(IThreading threading) {
            Log.Info("ThreadingExtension.OnCreated(...)");
            base.OnCreated(threading);
        }

        // OnUpdate()

        // OnBeforeSimulationTick()

        // OnBeforeSimulationFrame()

        // OnAfterSimilationFrame()

        // OnAfterSimulationTick()

        /// <summary>
        /// Triggered when the extension is released.
        /// </summary>
        [UsedImplicitly]
        public override void OnReleased() {
            Log.Info("ThreadingExtension.OnReleased()");
            base.OnReleased();
        }

    }
}
