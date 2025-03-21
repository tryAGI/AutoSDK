//HintName: G.Models.ResponseAudioTranscriptDeltaEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the event. Always `response.audio.transcript.delta`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseAudioTranscriptDeltaEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.audio.transcript.delta")]
        ResponseAudioTranscriptDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseAudioTranscriptDeltaEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseAudioTranscriptDeltaEventType value)
        {
            return value switch
            {
                ResponseAudioTranscriptDeltaEventType.ResponseAudioTranscriptDelta => "response.audio.transcript.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseAudioTranscriptDeltaEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.audio.transcript.delta" => ResponseAudioTranscriptDeltaEventType.ResponseAudioTranscriptDelta,
                _ => null,
            };
        }
    }
}