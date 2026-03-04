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
                BackupRestoreStatusResponseStatus.Started => "STARTED",
                BackupRestoreStatusResponseStatus.Transferring => "TRANSFERRING",
                BackupRestoreStatusResponseStatus.Transferred => "TRANSFERRED",
                BackupRestoreStatusResponseStatus.Success => "SUCCESS",
                BackupRestoreStatusResponseStatus.Failed => "FAILED",
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
                "STARTED" => BackupRestoreStatusResponseStatus.Started,
                "TRANSFERRING" => BackupRestoreStatusResponseStatus.Transferring,
                "TRANSFERRED" => BackupRestoreStatusResponseStatus.Transferred,
                "SUCCESS" => BackupRestoreStatusResponseStatus.Success,
                "FAILED" => BackupRestoreStatusResponseStatus.Failed,
                _ => null,
            };
        }
    }
}