//HintName: G.Models.InputAudioBufferSpeechStoppedPayloadType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum InputAudioBufferSpeechStoppedPayloadType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="input_audio_buffer.speech_stopped")]
        InputAudioBufferSpeechStopped,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputAudioBufferSpeechStoppedPayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputAudioBufferSpeechStoppedPayloadType value)
        {
            return value switch
            {
                InputAudioBufferSpeechStoppedPayloadType.InputAudioBufferSpeechStopped => "input_audio_buffer.speech_stopped",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputAudioBufferSpeechStoppedPayloadType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio_buffer.speech_stopped" => InputAudioBufferSpeechStoppedPayloadType.InputAudioBufferSpeechStopped,
                _ => null,
            };
        }
    }
}