//HintName: G.Models.BackupRestoreStatusResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// phase of backup restoration process<br/>
    /// Default Value: STARTED
    /// </summary>
    public enum BackupRestoreStatusResponseStatus
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BackupRestoreStatusResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackupRestoreStatusResponseStatus value)
        {
            return value switch
            {
                BackupRestoreStatusResponseStatus.STARTED => "STARTED",
                BackupRestoreStatusResponseStatus.TRANSFERRING => "TRANSFERRING",
                BackupRestoreStatusResponseStatus.TRANSFERRED => "TRANSFERRED",
                BackupRestoreStatusResponseStatus.SUCCESS => "SUCCESS",
                BackupRestoreStatusResponseStatus.FAILED => "FAILED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackupRestoreStatusResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "STARTED" => BackupRestoreStatusResponseStatus.STARTED,
                "TRANSFERRING" => BackupRestoreStatusResponseStatus.TRANSFERRING,
                "TRANSFERRED" => BackupRestoreStatusResponseStatus.TRANSFERRED,
                "SUCCESS" => BackupRestoreStatusResponseStatus.SUCCESS,
                "FAILED" => BackupRestoreStatusResponseStatus.FAILED,
                _ => null,
            };
        }
    }
}