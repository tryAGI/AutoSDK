//HintName: G.Models.ListMyAgentsResponseAgentVariant1Provider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The provider of the agent
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListMyAgentsResponseAgentVariant1Provider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="d-id-agents")]
        DIdAgents,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListMyAgentsResponseAgentVariant1ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListMyAgentsResponseAgentVariant1Provider value)
        {
            return value switch
            {
                ListMyAgentsResponseAgentVariant1Provider.DIdAgents => "d-id-agents",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListMyAgentsResponseAgentVariant1Provider? ToEnum(string value)
        {
            return value switch
            {
                "d-id-agents" => ListMyAgentsResponseAgentVariant1Provider.DIdAgents,
                _ => null,
            };
        }
    }
}