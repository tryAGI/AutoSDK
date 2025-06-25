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
    public static class BackupCreateResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackupCreateResponseStatus value)
        {
            return value switch
            {
                BackupCreateResponseStatus.STARTED => "STARTED",
                BackupCreateResponseStatus.TRANSFERRING => "TRANSFERRING",
                BackupCreateResponseStatus.TRANSFERRED => "TRANSFERRED",
                BackupCreateResponseStatus.SUCCESS => "SUCCESS",
                BackupCreateResponseStatus.FAILED => "FAILED",
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
                "STARTED" => BackupCreateResponseStatus.STARTED,
                "TRANSFERRING" => BackupCreateResponseStatus.TRANSFERRING,
                "TRANSFERRED" => BackupCreateResponseStatus.TRANSFERRED,
                "SUCCESS" => BackupCreateResponseStatus.SUCCESS,
                "FAILED" => BackupCreateResponseStatus.FAILED,
                _ => null,
            };
        }
    }
}