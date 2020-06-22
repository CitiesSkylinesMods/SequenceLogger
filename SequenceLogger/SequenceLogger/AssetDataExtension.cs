namespace SequenceLogger {
    using ICities;
    using JetBrains.Annotations;
    using SequenceLogger.Util;
    using System.Collections.Generic;

    [UsedImplicitly]
    public class AssetDataExtension : IAssetDataExtension {

        [UsedImplicitly]
        static AssetDataExtension() {
            Log.Info("AssetDataExtension.ctor() static");
        }

        [UsedImplicitly]
        public AssetDataExtension() {
            Log.Info("AssetDataExtension.ctor() instance");
        }

        [UsedImplicitly]
        public void OnAssetLoaded(string name, object asset, Dictionary<string, byte[]> userData) {
            Log.Info($"AssetDataExtension.OnAssetLoaded(name={name}, asset={asset}, userData={userData})");
        }

        [UsedImplicitly]
        public void OnAssetSaved(string name, object asset, out Dictionary<string, byte[]> userData) {
            Log.Info($"AssetDataExtension.OnAssetSaved(name={name}, asset={asset})");
            userData = null;
        }

        [UsedImplicitly]
        public void OnCreated(IAssetData assetData) {
            Log.Info($"AssetDataExtension.OnCreated(assetData={assetData})");
        }

        [UsedImplicitly]
        public void OnReleased() {
            Log.Info($"AssetDataExtension.OnReleased()");
        }
    }
}
