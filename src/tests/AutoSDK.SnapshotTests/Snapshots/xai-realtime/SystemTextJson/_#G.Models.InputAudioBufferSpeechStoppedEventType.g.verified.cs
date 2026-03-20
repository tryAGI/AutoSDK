//HintName: G.Models.InputAudioBufferSpeechStoppedEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum InputAudioBufferSpeechStoppedEventType
    {
        /// <summary>
        /// 
        /// </summary>
        InputAudioBufferSpeechStopped,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputAudioBufferSpeechStoppedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputAudioBufferSpeechStoppedEventType value)
        {
            return value switch
            {
                InputAudioBufferSpeechStoppedEventType.InputAudioBufferSpeechStopped => "input_audio_buffer.speech_stopped",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputAudioBufferSpeechStoppedEventType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio_buffer.speech_stopped" => InputAudioBufferSpeechStoppedEventType.InputAudioBufferSpeechStopped,
                _ => null,
            };
        }
    }
}