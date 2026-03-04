//HintName: G.Models.BackupListResponseItemStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// status of backup process
    /// </summary>
    public enum BackupListResponseItemStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Started,
        /// <summary>
        /// 
        /// </summary>
        Transferring,
        /// <summary>
        /// 
        /// </summary>
        Transferred,
        /// <summary>
        /// 
        /// </summary>
        Success,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Canceled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BackupListResponseItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackupListResponseItemStatus value)
        {
            return value switch
            {
                BackupListResponseItemStatus.Started => "STARTED",
                BackupListResponseItemStatus.Transferring => "TRANSFERRING",
                BackupListResponseItemStatus.Transferred => "TRANSFERRED",
                BackupListResponseItemStatus.Success => "SUCCESS",
                BackupListResponseItemStatus.Failed => "FAILED",
                BackupListResponseItemStatus.Canceled => "CANCELED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackupListResponseItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "STARTED" => BackupListResponseItemStatus.Started,
                "TRANSFERRING" => BackupListResponseItemStatus.Transferring,
                "TRANSFERRED" => BackupListResponseItemStatus.Transferred,
                "SUCCESS" => BackupListResponseItemStatus.Success,
                "FAILED" => BackupListResponseItemStatus.Failed,
                "CANCELED" => BackupListResponseItemStatus.Canceled,
                _ => null,
            };
        }
    }
}