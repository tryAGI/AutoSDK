//HintName: G.Models.RealtimeServerEventInputAudioBufferSpeechStartedType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type, must be `input_audio_buffer.speech_started`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RealtimeServerEventInputAudioBufferSpeechStartedType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="input_audio_buffer.speech_started")]
        InputAudioBufferSpeechStarted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeServerEventInputAudioBufferSpeechStartedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventInputAudioBufferSpeechStartedType value)
        {
            return value switch
            {
                RealtimeServerEventInputAudioBufferSpeechStartedType.InputAudioBufferSpeechStarted => "input_audio_buffer.speech_started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventInputAudioBufferSpeechStartedType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio_buffer.speech_started" => RealtimeServerEventInputAudioBufferSpeechStartedType.InputAudioBufferSpeechStarted,
                _ => null,
            };
        }
    }
}