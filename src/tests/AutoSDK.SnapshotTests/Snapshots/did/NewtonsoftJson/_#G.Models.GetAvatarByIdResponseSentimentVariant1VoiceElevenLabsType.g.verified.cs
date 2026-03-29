//HintName: G.Models.GetAvatarByIdResponseSentimentVariant1VoiceElevenLabsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetAvatarByIdResponseSentimentVariant1VoiceElevenLabsType
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
    public static class GetAvatarByIdResponseSentimentVariant1VoiceElevenLabsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAvatarByIdResponseSentimentVariant1VoiceElevenLabsType value)
        {
            return value switch
            {
                GetAvatarByIdResponseSentimentVariant1VoiceElevenLabsType.Elevenlabs => "elevenlabs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAvatarByIdResponseSentimentVariant1VoiceElevenLabsType? ToEnum(string value)
        {
            return value switch
            {
                "elevenlabs" => GetAvatarByIdResponseSentimentVariant1VoiceElevenLabsType.Elevenlabs,
                _ => null,
            };
        }
    }
}