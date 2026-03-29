//HintName: G.Models.AgentCreateDtoLlmVariant1Provider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Large Language Model provider.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentCreateDtoLlmVariant1Provider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openai")]
        Openai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentCreateDtoLlmVariant1ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentCreateDtoLlmVariant1Provider value)
        {
            return value switch
            {
                AgentCreateDtoLlmVariant1Provider.Openai => "openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentCreateDtoLlmVariant1Provider? ToEnum(string value)
        {
            return value switch
            {
                "openai" => AgentCreateDtoLlmVariant1Provider.Openai,
                _ => null,
            };
        }
    }
}