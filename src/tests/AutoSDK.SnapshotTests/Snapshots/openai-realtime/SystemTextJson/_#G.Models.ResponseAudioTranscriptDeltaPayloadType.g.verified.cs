//HintName: G.Models.ResponseAudioTranscriptDeltaPayloadType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type.
    /// </summary>
    public enum ResponseAudioTranscriptDeltaPayloadType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseAudioTranscriptDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseAudioTranscriptDeltaPayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseAudioTranscriptDeltaPayloadType value)
        {
            return value switch
            {
                ResponseAudioTranscriptDeltaPayloadType.ResponseAudioTranscriptDelta => "response.audio_transcript.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseAudioTranscriptDeltaPayloadType? ToEnum(string value)
        {
            return value switch
            {
                "response.audio_transcript.delta" => ResponseAudioTranscriptDeltaPayloadType.ResponseAudioTranscriptDelta,
                _ => null,
            };
        }
    }
}