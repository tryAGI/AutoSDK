//HintName: G.Models.ListMyAgentsResponseAgentVariant1LlmGoogleProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Large Language Model provider.
    /// </summary>
    public enum ListMyAgentsResponseAgentVariant1LlmGoogleProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Google,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListMyAgentsResponseAgentVariant1LlmGoogleProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListMyAgentsResponseAgentVariant1LlmGoogleProvider value)
        {
            return value switch
            {
                ListMyAgentsResponseAgentVariant1LlmGoogleProvider.Google => "google",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListMyAgentsResponseAgentVariant1LlmGoogleProvider? ToEnum(string value)
        {
            return value switch
            {
                "google" => ListMyAgentsResponseAgentVariant1LlmGoogleProvider.Google,
                _ => null,
            };
        }
    }
}