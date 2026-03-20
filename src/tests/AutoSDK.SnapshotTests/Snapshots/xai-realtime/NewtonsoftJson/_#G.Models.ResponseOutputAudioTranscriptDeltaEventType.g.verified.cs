//HintName: G.Models.ResponseOutputAudioTranscriptDeltaEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseOutputAudioTranscriptDeltaEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.output_audio_transcript.delta")]
        ResponseOutputAudioTranscriptDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseOutputAudioTranscriptDeltaEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseOutputAudioTranscriptDeltaEventType value)
        {
            return value switch
            {
                ResponseOutputAudioTranscriptDeltaEventType.ResponseOutputAudioTranscriptDelta => "response.output_audio_transcript.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseOutputAudioTranscriptDeltaEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.output_audio_transcript.delta" => ResponseOutputAudioTranscriptDeltaEventType.ResponseOutputAudioTranscriptDelta,
                _ => null,
            };
        }
    }
}