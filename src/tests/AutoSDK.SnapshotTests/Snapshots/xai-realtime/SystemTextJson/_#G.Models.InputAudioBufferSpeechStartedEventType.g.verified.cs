//HintName: G.Models.InputAudioBufferSpeechStartedEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum InputAudioBufferSpeechStartedEventType
    {
        /// <summary>
        /// 
        /// </summary>
        InputAudioBufferSpeechStarted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputAudioBufferSpeechStartedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputAudioBufferSpeechStartedEventType value)
        {
            return value switch
            {
                InputAudioBufferSpeechStartedEventType.InputAudioBufferSpeechStarted => "input_audio_buffer.speech_started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputAudioBufferSpeechStartedEventType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio_buffer.speech_started" => InputAudioBufferSpeechStartedEventType.InputAudioBufferSpeechStarted,
                _ => null,
            };
        }
    }
}