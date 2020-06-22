namespace SequenceLogger {
    using ICities;
    using JetBrains.Annotations;
    using SequenceLogger.Util;

    [UsedImplicitly]
    public class SerializableDataExtension : ISerializableDataExtension {
        [UsedImplicitly]
        static SerializableDataExtension() {
            Log.Info("SerializableDataExtension.ctor() static");
        }

        [UsedImplicitly]
        public SerializableDataExtension() {
            Log.Info("SerializableDataExtension.ctor() instance");
        }

        [UsedImplicitly]
        public void OnCreated(ISerializableData serializedData) {
            Log.Info($"SerializableDataExtension.OnCreated({serializedData})");
        }

        [UsedImplicitly]
        public void OnReleased() {
            Log.Info("SerializableDataExtension.OnReleased()");
        }

        [UsedImplicitly]
        public void OnLoadData() {
            Log.Info("SerializableDataExtension.OnLoadData()");
        }

        [UsedImplicitly]
        public void OnSaveData() {
            Log.Info("SerializableDataExtension.OnSaveData()");
        }
    }
}
