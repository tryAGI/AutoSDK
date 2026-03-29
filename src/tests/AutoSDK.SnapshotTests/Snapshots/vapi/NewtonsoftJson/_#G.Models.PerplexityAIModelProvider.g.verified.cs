//HintName: G.Models.PerplexityAIModelProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PerplexityAIModelProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="perplexity-ai")]
        PerplexityAi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PerplexityAIModelProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PerplexityAIModelProvider value)
        {
            return value switch
            {
                PerplexityAIModelProvider.PerplexityAi => "perplexity-ai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PerplexityAIModelProvider? ToEnum(string value)
        {
            return value switch
            {
                "perplexity-ai" => PerplexityAIModelProvider.PerplexityAi,
                _ => null,
            };
        }
    }
}