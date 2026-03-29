//HintName: G.Models.AgentResponseDtoVariant1Provider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The provider of the agent
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentResponseDtoVariant1Provider
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
    public static class AgentResponseDtoVariant1ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentResponseDtoVariant1Provider value)
        {
            return value switch
            {
                AgentResponseDtoVariant1Provider.DIdAgents => "d-id-agents",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentResponseDtoVariant1Provider? ToEnum(string value)
        {
            return value switch
            {
                "d-id-agents" => AgentResponseDtoVariant1Provider.DIdAgents,
                _ => null,
            };
        }
    }
}