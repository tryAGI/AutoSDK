//HintName: G.Models.InputAudioTranscriptionCompletedEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum InputAudioTranscriptionCompletedEventType
    {
        /// <summary>
        /// 
        /// </summary>
        InputAudioTranscriptionCompleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputAudioTranscriptionCompletedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputAudioTranscriptionCompletedEventType value)
        {
            return value switch
            {
                InputAudioTranscriptionCompletedEventType.InputAudioTranscriptionCompleted => "input_audio_transcription.completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputAudioTranscriptionCompletedEventType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio_transcription.completed" => InputAudioTranscriptionCompletedEventType.InputAudioTranscriptionCompleted,
                _ => null,
            };
        }
    }
}