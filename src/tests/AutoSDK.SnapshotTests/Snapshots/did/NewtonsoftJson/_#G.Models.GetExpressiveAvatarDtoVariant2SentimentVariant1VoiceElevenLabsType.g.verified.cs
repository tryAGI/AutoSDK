//HintName: G.Models.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceElevenLabsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceElevenLabsType
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
    public static class GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceElevenLabsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceElevenLabsType value)
        {
            return value switch
            {
                GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceElevenLabsType.Elevenlabs => "elevenlabs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceElevenLabsType? ToEnum(string value)
        {
            return value switch
            {
                "elevenlabs" => GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceElevenLabsType.Elevenlabs,
                _ => null,
            };
        }
    }
}