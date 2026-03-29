//HintName: G.Models.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceGoogleType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceGoogleType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="google")]
        Google,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceGoogleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceGoogleType value)
        {
            return value switch
            {
                GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceGoogleType.Google => "google",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceGoogleType? ToEnum(string value)
        {
            return value switch
            {
                "google" => GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceGoogleType.Google,
                _ => null,
            };
        }
    }
}