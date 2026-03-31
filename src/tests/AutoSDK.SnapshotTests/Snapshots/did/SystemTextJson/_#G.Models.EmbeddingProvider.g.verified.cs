//HintName: G.Models.EmbeddingProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum EmbeddingProvider
    {
        /// <summary>
        /// 
        /// </summary>
        AzureOpenAi,
        /// <summary>
        /// 
        /// </summary>
        OpenAi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbeddingProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingProvider value)
        {
            return value switch
            {
                EmbeddingProvider.AzureOpenAi => "azure-open-ai",
                EmbeddingProvider.OpenAi => "open-ai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingProvider? ToEnum(string value)
        {
            return value switch
            {
                "azure-open-ai" => EmbeddingProvider.AzureOpenAi,
                "open-ai" => EmbeddingProvider.OpenAi,
                _ => null,
            };
        }
    }
}