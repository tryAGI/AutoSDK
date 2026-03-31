//HintName: G.Models.AgentCreateDtoLlmVariant2Provider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Large Language Model provider.
    /// </summary>
    public enum AgentCreateDtoLlmVariant2Provider
    {
        /// <summary>
        /// 
        /// </summary>
        Custom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentCreateDtoLlmVariant2ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentCreateDtoLlmVariant2Provider value)
        {
            return value switch
            {
                AgentCreateDtoLlmVariant2Provider.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentCreateDtoLlmVariant2Provider? ToEnum(string value)
        {
            return value switch
            {
                "custom" => AgentCreateDtoLlmVariant2Provider.Custom,
                _ => null,
            };
        }
    }
}