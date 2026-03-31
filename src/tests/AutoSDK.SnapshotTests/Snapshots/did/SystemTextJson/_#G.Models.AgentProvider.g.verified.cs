//HintName: G.Models.AgentProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The provider of the agent
    /// </summary>
    public enum AgentProvider
    {
        /// <summary>
        /// 
        /// </summary>
        DIdAgents,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentProvider value)
        {
            return value switch
            {
                AgentProvider.DIdAgents => "d-id-agents",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentProvider? ToEnum(string value)
        {
            return value switch
            {
                "d-id-agents" => AgentProvider.DIdAgents,
                _ => null,
            };
        }
    }
}