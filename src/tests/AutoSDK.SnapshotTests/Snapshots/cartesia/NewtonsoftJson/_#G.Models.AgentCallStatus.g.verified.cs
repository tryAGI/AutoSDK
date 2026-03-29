//HintName: G.Models.AgentCallStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of an agent call.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentCallStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="active")]
        Active,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cancelled")]
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failed")]
        Failed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentCallStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentCallStatus value)
        {
            return value switch
            {
                AgentCallStatus.Active => "active",
                AgentCallStatus.Cancelled => "cancelled",
                AgentCallStatus.Completed => "completed",
                AgentCallStatus.Failed => "failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentCallStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => AgentCallStatus.Active,
                "cancelled" => AgentCallStatus.Cancelled,
                "completed" => AgentCallStatus.Completed,
                "failed" => AgentCallStatus.Failed,
                _ => null,
            };
        }
    }
}