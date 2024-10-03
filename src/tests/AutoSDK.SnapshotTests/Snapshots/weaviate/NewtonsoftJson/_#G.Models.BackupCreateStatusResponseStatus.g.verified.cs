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
    public static class BackupCreateStatusResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackupCreateStatusResponseStatus value)
        {
            return value switch
            {
                BackupCreateStatusResponseStatus.STARTED => "STARTED",
                BackupCreateStatusResponseStatus.TRANSFERRING => "TRANSFERRING",
                BackupCreateStatusResponseStatus.TRANSFERRED => "TRANSFERRED",
                BackupCreateStatusResponseStatus.SUCCESS => "SUCCESS",
                BackupCreateStatusResponseStatus.FAILED => "FAILED",
                BackupCreateStatusResponseStatus.CANCELED => "CANCELED",
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
                "STARTED" => BackupCreateStatusResponseStatus.STARTED,
                "TRANSFERRING" => BackupCreateStatusResponseStatus.TRANSFERRING,
                "TRANSFERRED" => BackupCreateStatusResponseStatus.TRANSFERRED,
                "SUCCESS" => BackupCreateStatusResponseStatus.SUCCESS,
                "FAILED" => BackupCreateStatusResponseStatus.FAILED,
                "CANCELED" => BackupCreateStatusResponseStatus.CANCELED,
                _ => null,
            };
        }
    }
}