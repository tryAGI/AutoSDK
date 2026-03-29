//HintName: G.Models.AgentsGetAgentVariablesResponseMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentsGetAgentVariablesResponseMessage
    {
        /// <summary>
        /// 
        /// </summary>
        AgentNotFound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentsGetAgentVariablesResponseMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentsGetAgentVariablesResponseMessage value)
        {
            return value switch
            {
                AgentsGetAgentVariablesResponseMessage.AgentNotFound => "Agent not found",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentsGetAgentVariablesResponseMessage? ToEnum(string value)
        {
            return value switch
            {
                "Agent not found" => AgentsGetAgentVariablesResponseMessage.AgentNotFound,
                _ => null,
            };
        }
    }
}