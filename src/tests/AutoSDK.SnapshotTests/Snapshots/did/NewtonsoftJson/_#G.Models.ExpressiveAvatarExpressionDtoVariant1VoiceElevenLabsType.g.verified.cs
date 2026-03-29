//HintName: G.Models.ExpressiveAvatarExpressionDtoVariant1VoiceElevenLabsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExpressiveAvatarExpressionDtoVariant1VoiceElevenLabsType
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
    public static class ExpressiveAvatarExpressionDtoVariant1VoiceElevenLabsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExpressiveAvatarExpressionDtoVariant1VoiceElevenLabsType value)
        {
            return value switch
            {
                ExpressiveAvatarExpressionDtoVariant1VoiceElevenLabsType.Elevenlabs => "elevenlabs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExpressiveAvatarExpressionDtoVariant1VoiceElevenLabsType? ToEnum(string value)
        {
            return value switch
            {
                "elevenlabs" => ExpressiveAvatarExpressionDtoVariant1VoiceElevenLabsType.Elevenlabs,
                _ => null,
            };
        }
    }
}