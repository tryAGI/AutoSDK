//HintName: G.Models.BackupRestoreResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// phase of backup restoration process<br/>
    /// Default Value: STARTED
    /// </summary>
    public enum BackupRestoreResponseStatus
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
    public static class BackupRestoreResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackupRestoreResponseStatus value)
        {
            return value switch
            {
                BackupRestoreResponseStatus.Started => "STARTED",
                BackupRestoreResponseStatus.Transferring => "TRANSFERRING",
                BackupRestoreResponseStatus.Transferred => "TRANSFERRED",
                BackupRestoreResponseStatus.Success => "SUCCESS",
                BackupRestoreResponseStatus.Failed => "FAILED",
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
                "STARTED" => BackupRestoreResponseStatus.Started,
                "TRANSFERRING" => BackupRestoreResponseStatus.Transferring,
                "TRANSFERRED" => BackupRestoreResponseStatus.Transferred,
                "SUCCESS" => BackupRestoreResponseStatus.Success,
                "FAILED" => BackupRestoreResponseStatus.Failed,
                _ => null,
            };
        }
    }
}