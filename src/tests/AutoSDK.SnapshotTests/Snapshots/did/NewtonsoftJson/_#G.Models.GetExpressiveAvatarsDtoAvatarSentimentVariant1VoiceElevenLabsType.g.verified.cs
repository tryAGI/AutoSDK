//HintName: G.Models.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceElevenLabsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceElevenLabsType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="elevenlabs")]
        Elevenlabs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceElevenLabsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceElevenLabsType value)
        {
            return value switch
            {
                GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceElevenLabsType.Elevenlabs => "elevenlabs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceElevenLabsType? ToEnum(string value)
        {
            return value switch
            {
                "elevenlabs" => GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceElevenLabsType.Elevenlabs,
                _ => null,
            };
        }
    }
}