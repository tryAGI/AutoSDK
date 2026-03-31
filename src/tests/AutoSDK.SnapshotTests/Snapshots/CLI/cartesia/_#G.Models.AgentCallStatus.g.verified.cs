//HintName: G.Models.AgentCallStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of an agent call.
    /// </summary>
    public enum AgentCallStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
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