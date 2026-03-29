//HintName: G.Models.AgentSwapToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentSwapToolType
    {
        /// <summary>
        /// 
        /// </summary>
        AgentSwap,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentSwapToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSwapToolType value)
        {
            return value switch
            {
                AgentSwapToolType.AgentSwap => "agent_swap",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSwapToolType? ToEnum(string value)
        {
            return value switch
            {
                "agent_swap" => AgentSwapToolType.AgentSwap,
                _ => null,
            };
        }
    }
}