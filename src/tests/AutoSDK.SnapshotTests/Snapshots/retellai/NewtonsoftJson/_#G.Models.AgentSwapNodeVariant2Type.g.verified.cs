//HintName: G.Models.AgentSwapNodeVariant2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of the node
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentSwapNodeVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="agent_swap")]
        AgentSwap,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentSwapNodeVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSwapNodeVariant2Type value)
        {
            return value switch
            {
                AgentSwapNodeVariant2Type.AgentSwap => "agent_swap",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSwapNodeVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "agent_swap" => AgentSwapNodeVariant2Type.AgentSwap,
                _ => null,
            };
        }
    }
}