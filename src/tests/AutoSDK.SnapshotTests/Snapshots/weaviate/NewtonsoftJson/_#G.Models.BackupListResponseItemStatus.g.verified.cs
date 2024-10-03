//HintName: G.Models.BackupListResponseItemStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// status of backup process
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BackupListResponseItemStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STARTED")]
        STARTED,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TRANSFERRING")]
        TRANSFERRING,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TRANSFERRED")]
        TRANSFERRED,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SUCCESS")]
        SUCCESS,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FAILED")]
        FAILED,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CANCELED")]
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