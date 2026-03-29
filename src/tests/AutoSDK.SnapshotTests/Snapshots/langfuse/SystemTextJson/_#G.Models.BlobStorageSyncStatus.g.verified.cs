//HintName: G.Models.BlobStorageSyncStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sync status of the blob storage integration:<br/>
    /// - `disabled` — integration is not enabled<br/>
    /// - `error` — last export failed (see `lastError` for details)<br/>
    /// - `idle` — enabled but has never exported yet<br/>
    /// - `queued` — next export is overdue (`nextSyncAt` is in the past) and waiting to be picked up by the worker<br/>
    /// - `up_to_date` — all available data has been exported; next export is scheduled for the future<br/>
    /// **ETL usage**: poll this endpoint and check for `up_to_date` status. Compare `lastSyncAt` against your<br/>
    /// ETL bookmark to determine if new data is available. Note that exports run with a 30-minute lag buffer,<br/>
    /// so `lastSyncAt` will always be at least 30 minutes behind real-time.
    /// </summary>
    public enum BlobStorageSyncStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Idle,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// poll this endpoint and check for `up_to_date` status. Compare `lastSyncAt` against your
        /// </summary>
        UpToDate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BlobStorageSyncStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BlobStorageSyncStatus value)
        {
            return value switch
            {
                BlobStorageSyncStatus.Disabled => "disabled",
                BlobStorageSyncStatus.Error => "error",
                BlobStorageSyncStatus.Idle => "idle",
                BlobStorageSyncStatus.Queued => "queued",
                BlobStorageSyncStatus.UpToDate => "up_to_date",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BlobStorageSyncStatus? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => BlobStorageSyncStatus.Disabled,
                "error" => BlobStorageSyncStatus.Error,
                "idle" => BlobStorageSyncStatus.Idle,
                "queued" => BlobStorageSyncStatus.Queued,
                "up_to_date" => BlobStorageSyncStatus.UpToDate,
                _ => null,
            };
        }
    }
}