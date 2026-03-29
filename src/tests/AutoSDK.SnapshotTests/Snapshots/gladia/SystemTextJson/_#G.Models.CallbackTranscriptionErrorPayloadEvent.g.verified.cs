//HintName: G.Models.CallbackTranscriptionErrorPayloadEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of event<br/>
    /// Default Value: transcription.error<br/>
    /// Example: transcription.error
    /// </summary>
    public enum CallbackTranscriptionErrorPayloadEvent
    {
        /// <summary>
        /// 
        /// </summary>
        TranscriptionError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CallbackTranscriptionErrorPayloadEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallbackTranscriptionErrorPayloadEvent value)
        {
            return value switch
            {
                CallbackTranscriptionErrorPayloadEvent.TranscriptionError => "transcription.error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallbackTranscriptionErrorPayloadEvent? ToEnum(string value)
        {
            return value switch
            {
                "transcription.error" => CallbackTranscriptionErrorPayloadEvent.TranscriptionError,
                _ => null,
            };
        }
    }
}