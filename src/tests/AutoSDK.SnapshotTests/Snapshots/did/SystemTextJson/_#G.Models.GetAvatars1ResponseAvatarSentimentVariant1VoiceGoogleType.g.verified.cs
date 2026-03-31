//HintName: G.Models.GetAvatars1ResponseAvatarSentimentVariant1VoiceGoogleType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAvatars1ResponseAvatarSentimentVariant1VoiceGoogleType
    {
        /// <summary>
        /// 
        /// </summary>
        Google,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAvatars1ResponseAvatarSentimentVariant1VoiceGoogleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAvatars1ResponseAvatarSentimentVariant1VoiceGoogleType value)
        {
            return value switch
            {
                GetAvatars1ResponseAvatarSentimentVariant1VoiceGoogleType.Google => "google",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAvatars1ResponseAvatarSentimentVariant1VoiceGoogleType? ToEnum(string value)
        {
            return value switch
            {
                "google" => GetAvatars1ResponseAvatarSentimentVariant1VoiceGoogleType.Google,
                _ => null,
            };
        }
    }
}