//HintName: G.Models.BackupCreateResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// phase of backup creation process<br/>
    /// Default Value: STARTED
    /// </summary>
    public enum BackupCreateResponseStatus
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
    public static class BackupCreateResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackupCreateResponseStatus value)
        {
            return value switch
            {
                BackupCreateResponseStatus.Started => "STARTED",
                BackupCreateResponseStatus.Transferring => "TRANSFERRING",
                BackupCreateResponseStatus.Transferred => "TRANSFERRED",
                BackupCreateResponseStatus.Success => "SUCCESS",
                BackupCreateResponseStatus.Failed => "FAILED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackupCreateResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "STARTED" => BackupCreateResponseStatus.Started,
                "TRANSFERRING" => BackupCreateResponseStatus.Transferring,
                "TRANSFERRED" => BackupCreateResponseStatus.Transferred,
                "SUCCESS" => BackupCreateResponseStatus.Success,
                "FAILED" => BackupCreateResponseStatus.Failed,
                _ => null,
            };
        }
    }
}