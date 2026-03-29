//HintName: G.Models.ClipPresenterDtoVoiceElevenLabsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ClipPresenterDtoVoiceElevenLabsType
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
    public static class ClipPresenterDtoVoiceElevenLabsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClipPresenterDtoVoiceElevenLabsType value)
        {
            return value switch
            {
                ClipPresenterDtoVoiceElevenLabsType.Elevenlabs => "elevenlabs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClipPresenterDtoVoiceElevenLabsType? ToEnum(string value)
        {
            return value switch
            {
                "elevenlabs" => ClipPresenterDtoVoiceElevenLabsType.Elevenlabs,
                _ => null,
            };
        }
    }
}