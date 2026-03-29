//HintName: G.Models.SmallestAICredentialProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SmallestAICredentialProvider
    {
        /// <summary>
        /// 
        /// </summary>
        SmallestAi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SmallestAICredentialProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SmallestAICredentialProvider value)
        {
            return value switch
            {
                SmallestAICredentialProvider.SmallestAi => "smallest-ai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SmallestAICredentialProvider? ToEnum(string value)
        {
            return value switch
            {
                "smallest-ai" => SmallestAICredentialProvider.SmallestAi,
                _ => null,
            };
        }
    }
}