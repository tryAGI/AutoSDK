//HintName: G.Models.AgentResponseDtoVariant1LlmOpenAIProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Large Language Model provider.
    /// </summary>
    public enum AgentResponseDtoVariant1LlmOpenAIProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Openai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentResponseDtoVariant1LlmOpenAIProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentResponseDtoVariant1LlmOpenAIProvider value)
        {
            return value switch
            {
                AgentResponseDtoVariant1LlmOpenAIProvider.Openai => "openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentResponseDtoVariant1LlmOpenAIProvider? ToEnum(string value)
        {
            return value switch
            {
                "openai" => AgentResponseDtoVariant1LlmOpenAIProvider.Openai,
                _ => null,
            };
        }
    }
}