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
    /// 
    public class ThreadingExtension : ThreadingExtensionBase {
        bool first_frame_called;
        bool first_tick_called;
        bool first_update_called;

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
            first_update_called = first_tick_called = first_frame_called = false;
            Log.Info("ThreadingExtension.OnCreated(...)");
            base.OnCreated(threading);
        }

        public override void OnUpdate(float realTimeDelta, float simulationTimeDelta) {
            if (!first_update_called) {
                first_update_called = true;
                Log.Info("ThreadingExtension.OnUpdate() first update");
            }
            base.OnUpdate(realTimeDelta, simulationTimeDelta);
        }

        public override void OnBeforeSimulationFrame() {
            if (!first_frame_called) {
                first_frame_called = true;
                Log.Info("ThreadingExtension.OnBeforeSimulationFrame() first frame");
            }
            base.OnBeforeSimulationFrame();
        }

        public override void OnBeforeSimulationTick() {
            if (!first_tick_called) {
                first_tick_called = true;
                Log.Info("ThreadingExtension.OnBeforeSimulationTick() first tick");
            }
            base.OnBeforeSimulationFrame();
        }

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
