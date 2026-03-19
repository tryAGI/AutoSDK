//HintName: G.Models.ResponseAudioTranscriptDonePayloadType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type.
    /// </summary>
    public enum ResponseAudioTranscriptDonePayloadType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseAudioTranscriptDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseAudioTranscriptDonePayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseAudioTranscriptDonePayloadType value)
        {
            return value switch
            {
                ResponseAudioTranscriptDonePayloadType.ResponseAudioTranscriptDone => "response.audio_transcript.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseAudioTranscriptDonePayloadType? ToEnum(string value)
        {
            return value switch
            {
                "response.audio_transcript.done" => ResponseAudioTranscriptDonePayloadType.ResponseAudioTranscriptDone,
                _ => null,
            };
        }
    }
}