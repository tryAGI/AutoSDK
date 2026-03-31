//HintName: G.Models.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceGoogleType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceGoogleType
    {
        /// <summary>
        /// 
        /// </summary>
        Google,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceGoogleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceGoogleType value)
        {
            return value switch
            {
                GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceGoogleType.Google => "google",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceGoogleType? ToEnum(string value)
        {
            return value switch
            {
                "google" => GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceGoogleType.Google,
                _ => null,
            };
        }
    }
}