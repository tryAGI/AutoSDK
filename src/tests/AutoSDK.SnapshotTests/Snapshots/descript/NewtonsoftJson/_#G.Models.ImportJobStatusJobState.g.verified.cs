//HintName: G.Models.ImportJobStatusJobState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Current state of the job:<br/>
    /// - queued: Job is waiting to start<br/>
    /// - running: Job is actively processing<br/>
    /// - stopped: Job has finished (check result.status for outcome)<br/>
    /// - cancelled: Job was cancelled by user<br/>
    /// Example: stopped
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ImportJobStatusJobState
    {
        /// <summary>
        /// Job was cancelled by user
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cancelled")]
        Cancelled,
        /// <summary>
        /// Job is waiting to start
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="queued")]
        Queued,
        /// <summary>
        /// Job is actively processing
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="running")]
        Running,
        /// <summary>
        /// Job has finished (check result.status for outcome)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="stopped")]
        Stopped,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImportJobStatusJobStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImportJobStatusJobState value)
        {
            return value switch
            {
                ImportJobStatusJobState.Cancelled => "cancelled",
                ImportJobStatusJobState.Queued => "queued",
                ImportJobStatusJobState.Running => "running",
                ImportJobStatusJobState.Stopped => "stopped",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImportJobStatusJobState? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => ImportJobStatusJobState.Cancelled,
                "queued" => ImportJobStatusJobState.Queued,
                "running" => ImportJobStatusJobState.Running,
                "stopped" => ImportJobStatusJobState.Stopped,
                _ => null,
            };
        }
    }
}