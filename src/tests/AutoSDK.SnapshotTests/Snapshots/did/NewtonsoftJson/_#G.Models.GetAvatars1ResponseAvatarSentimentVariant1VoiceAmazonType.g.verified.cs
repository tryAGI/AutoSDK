//HintName: G.Models.GetAvatars1ResponseAvatarSentimentVariant1VoiceAmazonType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetAvatars1ResponseAvatarSentimentVariant1VoiceAmazonType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="amazon")]
        Amazon,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAvatars1ResponseAvatarSentimentVariant1VoiceAmazonTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAvatars1ResponseAvatarSentimentVariant1VoiceAmazonType value)
        {
            return value switch
            {
                GetAvatars1ResponseAvatarSentimentVariant1VoiceAmazonType.Amazon => "amazon",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAvatars1ResponseAvatarSentimentVariant1VoiceAmazonType? ToEnum(string value)
        {
            return value switch
            {
                "amazon" => GetAvatars1ResponseAvatarSentimentVariant1VoiceAmazonType.Amazon,
                _ => null,
            };
        }
    }
}