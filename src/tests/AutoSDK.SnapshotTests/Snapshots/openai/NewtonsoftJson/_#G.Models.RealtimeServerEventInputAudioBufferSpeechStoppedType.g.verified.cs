//HintName: G.Models.RealtimeServerEventInputAudioBufferSpeechStoppedType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type, must be `input_audio_buffer.speech_stopped`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RealtimeServerEventInputAudioBufferSpeechStoppedType
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
    public static class RealtimeServerEventInputAudioBufferSpeechStoppedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventInputAudioBufferSpeechStoppedType value)
        {
            return value switch
            {
                RealtimeServerEventInputAudioBufferSpeechStoppedType.InputAudioBufferSpeechStopped => "input_audio_buffer.speech_stopped",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventInputAudioBufferSpeechStoppedType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio_buffer.speech_stopped" => RealtimeServerEventInputAudioBufferSpeechStoppedType.InputAudioBufferSpeechStopped,
                _ => null,
            };
        }
    }
}