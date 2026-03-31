//HintName: G.Models.GetAvatarByIdResponseSentimentVariant1VoiceAmazonType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAvatarByIdResponseSentimentVariant1VoiceAmazonType
    {
        /// <summary>
        /// 
        /// </summary>
        Amazon,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAvatarByIdResponseSentimentVariant1VoiceAmazonTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAvatarByIdResponseSentimentVariant1VoiceAmazonType value)
        {
            return value switch
            {
                GetAvatarByIdResponseSentimentVariant1VoiceAmazonType.Amazon => "amazon",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAvatarByIdResponseSentimentVariant1VoiceAmazonType? ToEnum(string value)
        {
            return value switch
            {
                "amazon" => GetAvatarByIdResponseSentimentVariant1VoiceAmazonType.Amazon,
                _ => null,
            };
        }
    }
}