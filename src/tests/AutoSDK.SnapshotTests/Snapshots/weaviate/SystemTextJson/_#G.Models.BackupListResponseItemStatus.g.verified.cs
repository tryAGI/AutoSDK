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
        STARTED,
        /// <summary>
        /// 
        /// </summary>
        TRANSFERRING,
        /// <summary>
        /// 
        /// </summary>
        TRANSFERRED,
        /// <summary>
        /// 
        /// </summary>
        SUCCESS,
        /// <summary>
        /// 
        /// </summary>
        FAILED,
        /// <summary>
        /// 
        /// </summary>
        CANCELED,
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
                BackupListResponseItemStatus.STARTED => "STARTED",
                BackupListResponseItemStatus.TRANSFERRING => "TRANSFERRING",
                BackupListResponseItemStatus.TRANSFERRED => "TRANSFERRED",
                BackupListResponseItemStatus.SUCCESS => "SUCCESS",
                BackupListResponseItemStatus.FAILED => "FAILED",
                BackupListResponseItemStatus.CANCELED => "CANCELED",
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
                "STARTED" => BackupListResponseItemStatus.STARTED,
                "TRANSFERRING" => BackupListResponseItemStatus.TRANSFERRING,
                "TRANSFERRED" => BackupListResponseItemStatus.TRANSFERRED,
                "SUCCESS" => BackupListResponseItemStatus.SUCCESS,
                "FAILED" => BackupListResponseItemStatus.FAILED,
                "CANCELED" => BackupListResponseItemStatus.CANCELED,
                _ => null,
            };
        }
    }
}