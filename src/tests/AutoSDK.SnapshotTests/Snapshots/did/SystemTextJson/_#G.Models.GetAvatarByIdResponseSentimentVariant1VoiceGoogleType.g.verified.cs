//HintName: G.Models.GetAvatarByIdResponseSentimentVariant1VoiceGoogleType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAvatarByIdResponseSentimentVariant1VoiceGoogleType
    {
        /// <summary>
        /// 
        /// </summary>
        Google,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAvatarByIdResponseSentimentVariant1VoiceGoogleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAvatarByIdResponseSentimentVariant1VoiceGoogleType value)
        {
            return value switch
            {
                GetAvatarByIdResponseSentimentVariant1VoiceGoogleType.Google => "google",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAvatarByIdResponseSentimentVariant1VoiceGoogleType? ToEnum(string value)
        {
            return value switch
            {
                "google" => GetAvatarByIdResponseSentimentVariant1VoiceGoogleType.Google,
                _ => null,
            };
        }
    }
}