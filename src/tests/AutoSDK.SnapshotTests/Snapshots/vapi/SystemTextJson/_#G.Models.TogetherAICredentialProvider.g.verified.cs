//HintName: G.Models.TogetherAICredentialProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TogetherAICredentialProvider
    {
        /// <summary>
        /// 
        /// </summary>
        TogetherAi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TogetherAICredentialProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TogetherAICredentialProvider value)
        {
            return value switch
            {
                TogetherAICredentialProvider.TogetherAi => "together-ai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TogetherAICredentialProvider? ToEnum(string value)
        {
            return value switch
            {
                "together-ai" => TogetherAICredentialProvider.TogetherAi,
                _ => null,
            };
        }
    }
}