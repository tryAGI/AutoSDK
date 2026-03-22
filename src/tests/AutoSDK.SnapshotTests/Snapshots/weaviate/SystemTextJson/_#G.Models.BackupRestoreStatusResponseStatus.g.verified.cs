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
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Started,
        /// <summary>
        /// 
        /// </summary>
        Success,
        /// <summary>
        /// 
        /// </summary>
        Transferred,
        /// <summary>
        /// 
        /// </summary>
        Transferring,
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
                BackupRestoreStatusResponseStatus.Failed => "FAILED",
                BackupRestoreStatusResponseStatus.Started => "STARTED",
                BackupRestoreStatusResponseStatus.Success => "SUCCESS",
                BackupRestoreStatusResponseStatus.Transferred => "TRANSFERRED",
                BackupRestoreStatusResponseStatus.Transferring => "TRANSFERRING",
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
                "FAILED" => BackupRestoreStatusResponseStatus.Failed,
                "STARTED" => BackupRestoreStatusResponseStatus.Started,
                "SUCCESS" => BackupRestoreStatusResponseStatus.Success,
                "TRANSFERRED" => BackupRestoreStatusResponseStatus.Transferred,
                "TRANSFERRING" => BackupRestoreStatusResponseStatus.Transferring,
                _ => null,
            };
        }
    }
}