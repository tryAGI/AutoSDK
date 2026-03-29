//HintName: G.Models.UpdatePresenterAttributesRequestVariant1VoiceElevenLabsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdatePresenterAttributesRequestVariant1VoiceElevenLabsType
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
    public static class UpdatePresenterAttributesRequestVariant1VoiceElevenLabsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdatePresenterAttributesRequestVariant1VoiceElevenLabsType value)
        {
            return value switch
            {
                UpdatePresenterAttributesRequestVariant1VoiceElevenLabsType.Elevenlabs => "elevenlabs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdatePresenterAttributesRequestVariant1VoiceElevenLabsType? ToEnum(string value)
        {
            return value switch
            {
                "elevenlabs" => UpdatePresenterAttributesRequestVariant1VoiceElevenLabsType.Elevenlabs,
                _ => null,
            };
        }
    }
}