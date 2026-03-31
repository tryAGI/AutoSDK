//HintName: G.Models.AgentResponseDtoVariant1LlmDIdProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Large Language Model provider.
    /// </summary>
    public enum AgentResponseDtoVariant1LlmDIdProvider
    {
        /// <summary>
        /// 
        /// </summary>
        DId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentResponseDtoVariant1LlmDIdProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentResponseDtoVariant1LlmDIdProvider value)
        {
            return value switch
            {
                AgentResponseDtoVariant1LlmDIdProvider.DId => "d-id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentResponseDtoVariant1LlmDIdProvider? ToEnum(string value)
        {
            return value switch
            {
                "d-id" => AgentResponseDtoVariant1LlmDIdProvider.DId,
                _ => null,
            };
        }
    }
}