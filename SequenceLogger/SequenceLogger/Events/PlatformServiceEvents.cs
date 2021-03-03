namespace SequenceLogger.Events {
    using ColossalFramework.PlatformServices;
    using SequenceLogger.Util;

    /// <summary>
    /// Logs <see cref="PlatformService"/> events.
    /// </summary>
    public class PlatformServiceEvents {

        public static void Start() {
            if (Options.Instance.LogPlatformService) {
                PlatformService.eventGameOverlayActivated += OnGameOverlayActivated;
                PlatformService.workshop.eventSubmitItemUpdate += OnSubmitItemUpdate;
                PlatformService.workshop.eventWorkshopItemInstalled += OnWorkshopItemInstalled;
                PlatformService.workshop.eventWorkshopSubscriptionChanged += OnWorkshopSubscriptionChanged;
            }
            if (Options.Instance.LogPlatformServiceUGC) {
                PlatformService.workshop.eventUGCQueryCompleted += OnUGCQueryCompleted;
                PlatformService.workshop.eventUGCRequestUGCDetailsCompleted += OnUGCRequestUGCDetailsCompleted;
            }
        }

        public static void Stop() {
            PlatformService.eventGameOverlayActivated -= OnGameOverlayActivated;
            PlatformService.workshop.eventSubmitItemUpdate -= OnSubmitItemUpdate;
            PlatformService.workshop.eventUGCQueryCompleted -= OnUGCQueryCompleted;
            PlatformService.workshop.eventUGCRequestUGCDetailsCompleted -= OnUGCRequestUGCDetailsCompleted;
            PlatformService.workshop.eventWorkshopItemInstalled -= OnWorkshopItemInstalled;
            PlatformService.workshop.eventWorkshopSubscriptionChanged -= OnWorkshopSubscriptionChanged;
        }

        private static void OnGameOverlayActivated(bool active) {
            Log.Info($"PlatformService.workshop.eventGameOverlayActivated({active})");
        }

        private static void OnSubmitItemUpdate(SubmitItemUpdateResult result, bool ioError) {
            Log.Info($"PlatformService.workshop.eventSubmitItemUpdate(" +
                $"result ({result.result}), {ioError})");
        }

        private static void OnUGCQueryCompleted(UGCDetails result, bool ioError) {
            Log.Info($"PlatformService.workshop.eventUGCQueryCompleted(" +
                $"result (id:{result.publishedFileId}), {ioError})");
        }

        private static void OnUGCRequestUGCDetailsCompleted(UGCDetails result, bool ioError) {
            Log.Info($"PlatformService.workshop.eventUGCRequestUGCDetailsCompleted(" +
                $"result (id:{result.publishedFileId}), {ioError})");
        }

        private static void OnWorkshopItemInstalled(PublishedFileId id) {
            Log.Info($"PlatformService.workshop.eventWorkshopItemInstalled({id.AsUInt64})");
        }

        private static void OnWorkshopSubscriptionChanged(PublishedFileId id, bool subscribed) {
            Log.Info($"PlatformService.workshop.eventWorkshopSubscriptionChanged({id.AsUInt64}, {subscribed})");
        }
    }
}
