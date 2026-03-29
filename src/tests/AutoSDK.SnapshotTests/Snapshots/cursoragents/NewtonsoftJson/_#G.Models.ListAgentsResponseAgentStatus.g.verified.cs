//HintName: G.Models.ListAgentsResponseAgentStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Current status of the cloud agent<br/>
    /// Example: RUNNING
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListAgentsResponseAgentStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CREATING")]
        Creating,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ERROR")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="EXPIRED")]
        Expired,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FINISHED")]
        Finished,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="RUNNING")]
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