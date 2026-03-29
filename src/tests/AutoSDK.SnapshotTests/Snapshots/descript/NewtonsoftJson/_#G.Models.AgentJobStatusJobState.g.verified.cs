//HintName: G.Models.AgentJobStatusJobState.g.cs

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
    public enum AgentJobStatusJobState
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
    public static class AgentJobStatusJobStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentJobStatusJobState value)
        {
            return value switch
            {
                AgentJobStatusJobState.Cancelled => "cancelled",
                AgentJobStatusJobState.Queued => "queued",
                AgentJobStatusJobState.Running => "running",
                AgentJobStatusJobState.Stopped => "stopped",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentJobStatusJobState? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => AgentJobStatusJobState.Cancelled,
                "queued" => AgentJobStatusJobState.Queued,
                "running" => AgentJobStatusJobState.Running,
                "stopped" => AgentJobStatusJobState.Stopped,
                _ => null,
            };
        }
    }
}