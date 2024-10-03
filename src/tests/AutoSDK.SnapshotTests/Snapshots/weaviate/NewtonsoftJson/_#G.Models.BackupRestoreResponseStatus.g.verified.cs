//HintName: G.Models.BackupRestoreResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// phase of backup restoration process<br/>
    /// Default Value: STARTED
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BackupRestoreResponseStatus
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BackupRestoreResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackupRestoreResponseStatus value)
        {
            return value switch
            {
                BackupRestoreResponseStatus.STARTED => "STARTED",
                BackupRestoreResponseStatus.TRANSFERRING => "TRANSFERRING",
                BackupRestoreResponseStatus.TRANSFERRED => "TRANSFERRED",
                BackupRestoreResponseStatus.SUCCESS => "SUCCESS",
                BackupRestoreResponseStatus.FAILED => "FAILED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackupRestoreResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "STARTED" => BackupRestoreResponseStatus.STARTED,
                "TRANSFERRING" => BackupRestoreResponseStatus.TRANSFERRING,
                "TRANSFERRED" => BackupRestoreResponseStatus.TRANSFERRED,
                "SUCCESS" => BackupRestoreResponseStatus.SUCCESS,
                "FAILED" => BackupRestoreResponseStatus.FAILED,
                _ => null,
            };
        }
    }
}