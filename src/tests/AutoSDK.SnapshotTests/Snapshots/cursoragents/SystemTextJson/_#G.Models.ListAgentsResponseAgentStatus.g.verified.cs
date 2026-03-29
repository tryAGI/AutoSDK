//HintName: G.Models.ListAgentsResponseAgentStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Current status of the cloud agent<br/>
    /// Example: RUNNING
    /// </summary>
    public enum ListAgentsResponseAgentStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Creating,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Expired,
        /// <summary>
        /// 
        /// </summary>
        Finished,
        /// <summary>
        /// 
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListAgentsResponseAgentStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAgentsResponseAgentStatus value)
        {
            return value switch
            {
                ListAgentsResponseAgentStatus.Creating => "CREATING",
                ListAgentsResponseAgentStatus.Error => "ERROR",
                ListAgentsResponseAgentStatus.Expired => "EXPIRED",
                ListAgentsResponseAgentStatus.Finished => "FINISHED",
                ListAgentsResponseAgentStatus.Running => "RUNNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAgentsResponseAgentStatus? ToEnum(string value)
        {
            return value switch
            {
                "CREATING" => ListAgentsResponseAgentStatus.Creating,
                "ERROR" => ListAgentsResponseAgentStatus.Error,
                "EXPIRED" => ListAgentsResponseAgentStatus.Expired,
                "FINISHED" => ListAgentsResponseAgentStatus.Finished,
                "RUNNING" => ListAgentsResponseAgentStatus.Running,
                _ => null,
            };
        }
    }
}