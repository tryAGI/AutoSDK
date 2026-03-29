//HintName: G.Models.PerplexityAICredentialProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PerplexityAICredentialProvider
    {
        /// <summary>
        /// 
        /// </summary>
        PerplexityAi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PerplexityAICredentialProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PerplexityAICredentialProvider value)
        {
            return value switch
            {
                PerplexityAICredentialProvider.PerplexityAi => "perplexity-ai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PerplexityAICredentialProvider? ToEnum(string value)
        {
            return value switch
            {
                "perplexity-ai" => PerplexityAICredentialProvider.PerplexityAi,
                _ => null,
            };
        }
    }
}