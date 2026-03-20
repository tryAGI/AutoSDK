//HintName: G.Models.ResponseOutputAudioTranscriptDoneEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseOutputAudioTranscriptDoneEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.output_audio_transcript.done")]
        ResponseOutputAudioTranscriptDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseOutputAudioTranscriptDoneEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseOutputAudioTranscriptDoneEventType value)
        {
            return value switch
            {
                ResponseOutputAudioTranscriptDoneEventType.ResponseOutputAudioTranscriptDone => "response.output_audio_transcript.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseOutputAudioTranscriptDoneEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.output_audio_transcript.done" => ResponseOutputAudioTranscriptDoneEventType.ResponseOutputAudioTranscriptDone,
                _ => null,
            };
        }
    }
}