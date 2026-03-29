//HintName: G.Models.ListMyAgentsResponseAgentVariant1LlmOpenAIProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Large Language Model provider.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListMyAgentsResponseAgentVariant1LlmOpenAIProvider
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
    public static class ListMyAgentsResponseAgentVariant1LlmOpenAIProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListMyAgentsResponseAgentVariant1LlmOpenAIProvider value)
        {
            return value switch
            {
                ListMyAgentsResponseAgentVariant1LlmOpenAIProvider.Openai => "openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListMyAgentsResponseAgentVariant1LlmOpenAIProvider? ToEnum(string value)
        {
            return value switch
            {
                "openai" => ListMyAgentsResponseAgentVariant1LlmOpenAIProvider.Openai,
                _ => null,
            };
        }
    }
}