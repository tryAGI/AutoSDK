//HintName: G.Models.GetAvatars1ResponseAvatarSentimentVariant1VoiceMicrosoftType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAvatars1ResponseAvatarSentimentVariant1VoiceMicrosoftType
    {
        /// <summary>
        /// 
        /// </summary>
        Microsoft,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAvatars1ResponseAvatarSentimentVariant1VoiceMicrosoftTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAvatars1ResponseAvatarSentimentVariant1VoiceMicrosoftType value)
        {
            return value switch
            {
                GetAvatars1ResponseAvatarSentimentVariant1VoiceMicrosoftType.Microsoft => "microsoft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAvatars1ResponseAvatarSentimentVariant1VoiceMicrosoftType? ToEnum(string value)
        {
            return value switch
            {
                "microsoft" => GetAvatars1ResponseAvatarSentimentVariant1VoiceMicrosoftType.Microsoft,
                _ => null,
            };
        }
    }
}