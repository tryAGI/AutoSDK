//HintName: G.Models.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceAmazonType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceAmazonType
    {
        /// <summary>
        /// 
        /// </summary>
        Amazon,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceAmazonTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceAmazonType value)
        {
            return value switch
            {
                GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceAmazonType.Amazon => "amazon",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceAmazonType? ToEnum(string value)
        {
            return value switch
            {
                "amazon" => GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceAmazonType.Amazon,
                _ => null,
            };
        }
    }
}