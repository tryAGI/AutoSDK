//HintName: G.Models.SpeakV1ServerEventDiscriminatorMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SpeakV1ServerEventDiscriminatorMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="audio_response")]
        AudioResponse,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="speak_metadata")]
        SpeakMetadata,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeakV1ServerEventDiscriminatorMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeakV1ServerEventDiscriminatorMessageType value)
        {
            return value switch
            {
                SpeakV1ServerEventDiscriminatorMessageType.AudioResponse => "audio_response",
                SpeakV1ServerEventDiscriminatorMessageType.SpeakMetadata => "speak_metadata",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeakV1ServerEventDiscriminatorMessageType? ToEnum(string value)
        {
            return value switch
            {
                "audio_response" => SpeakV1ServerEventDiscriminatorMessageType.AudioResponse,
                "speak_metadata" => SpeakV1ServerEventDiscriminatorMessageType.SpeakMetadata,
                _ => null,
            };
        }
    }
}