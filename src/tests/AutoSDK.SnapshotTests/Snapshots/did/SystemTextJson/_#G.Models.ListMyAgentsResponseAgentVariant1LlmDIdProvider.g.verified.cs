//HintName: G.Models.ListMyAgentsResponseAgentVariant1LlmDIdProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Large Language Model provider.
    /// </summary>
    public enum ListMyAgentsResponseAgentVariant1LlmDIdProvider
    {
        /// <summary>
        /// 
        /// </summary>
        DId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListMyAgentsResponseAgentVariant1LlmDIdProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListMyAgentsResponseAgentVariant1LlmDIdProvider value)
        {
            return value switch
            {
                ListMyAgentsResponseAgentVariant1LlmDIdProvider.DId => "d-id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListMyAgentsResponseAgentVariant1LlmDIdProvider? ToEnum(string value)
        {
            return value switch
            {
                "d-id" => ListMyAgentsResponseAgentVariant1LlmDIdProvider.DId,
                _ => null,
            };
        }
    }
}