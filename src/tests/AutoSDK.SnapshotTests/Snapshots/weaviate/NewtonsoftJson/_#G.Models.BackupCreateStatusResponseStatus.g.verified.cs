//HintName: G.Models.BackupCreateStatusResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// phase of backup creation process<br/>
    /// Default Value: STARTED
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BackupCreateStatusResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STARTED")]
        Started,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TRANSFERRING")]
        Transferring,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TRANSFERRED")]
        Transferred,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SUCCESS")]
        Success,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FAILED")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CANCELED")]
        Canceled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BackupCreateStatusResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackupCreateStatusResponseStatus value)
        {
            return value switch
            {
                BackupCreateStatusResponseStatus.Started => "STARTED",
                BackupCreateStatusResponseStatus.Transferring => "TRANSFERRING",
                BackupCreateStatusResponseStatus.Transferred => "TRANSFERRED",
                BackupCreateStatusResponseStatus.Success => "SUCCESS",
                BackupCreateStatusResponseStatus.Failed => "FAILED",
                BackupCreateStatusResponseStatus.Canceled => "CANCELED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackupCreateStatusResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "STARTED" => BackupCreateStatusResponseStatus.Started,
                "TRANSFERRING" => BackupCreateStatusResponseStatus.Transferring,
                "TRANSFERRED" => BackupCreateStatusResponseStatus.Transferred,
                "SUCCESS" => BackupCreateStatusResponseStatus.Success,
                "FAILED" => BackupCreateStatusResponseStatus.Failed,
                "CANCELED" => BackupCreateStatusResponseStatus.Canceled,
                _ => null,
            };
        }
    }
}