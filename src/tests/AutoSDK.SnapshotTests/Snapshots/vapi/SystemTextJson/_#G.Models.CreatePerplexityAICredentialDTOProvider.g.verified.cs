//HintName: G.Models.CreatePerplexityAICredentialDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreatePerplexityAICredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        PerplexityAi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreatePerplexityAICredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePerplexityAICredentialDTOProvider value)
        {
            return value switch
            {
                CreatePerplexityAICredentialDTOProvider.PerplexityAi => "perplexity-ai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePerplexityAICredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "perplexity-ai" => CreatePerplexityAICredentialDTOProvider.PerplexityAi,
                _ => null,
            };
        }
    }
}