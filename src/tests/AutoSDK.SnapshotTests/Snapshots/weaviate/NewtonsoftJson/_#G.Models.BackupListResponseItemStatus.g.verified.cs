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
        [global::System.Runtime.Serialization.EnumMember(Value="CANCELED")]
        Canceled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FAILED")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STARTED")]
        Started,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SUCCESS")]
        Success,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TRANSFERRED")]
        Transferred,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TRANSFERRING")]
        Transferring,
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
                BackupListResponseItemStatus.Canceled => "CANCELED",
                BackupListResponseItemStatus.Failed => "FAILED",
                BackupListResponseItemStatus.Started => "STARTED",
                BackupListResponseItemStatus.Success => "SUCCESS",
                BackupListResponseItemStatus.Transferred => "TRANSFERRED",
                BackupListResponseItemStatus.Transferring => "TRANSFERRING",
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
                "CANCELED" => BackupListResponseItemStatus.Canceled,
                "FAILED" => BackupListResponseItemStatus.Failed,
                "STARTED" => BackupListResponseItemStatus.Started,
                "SUCCESS" => BackupListResponseItemStatus.Success,
                "TRANSFERRED" => BackupListResponseItemStatus.Transferred,
                "TRANSFERRING" => BackupListResponseItemStatus.Transferring,
                _ => null,
            };
        }
    }
}