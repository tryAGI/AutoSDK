//HintName: G.Models.RealtimeServerEventResponseAudioTranscriptDeltaType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type, must be `response.audio_transcript.delta`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RealtimeServerEventResponseAudioTranscriptDeltaType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.audio_transcript.delta")]
        ResponseAudioTranscriptDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeServerEventResponseAudioTranscriptDeltaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventResponseAudioTranscriptDeltaType value)
        {
            return value switch
            {
                RealtimeServerEventResponseAudioTranscriptDeltaType.ResponseAudioTranscriptDelta => "response.audio_transcript.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventResponseAudioTranscriptDeltaType? ToEnum(string value)
        {
            return value switch
            {
                "response.audio_transcript.delta" => RealtimeServerEventResponseAudioTranscriptDeltaType.ResponseAudioTranscriptDelta,
                _ => null,
            };
        }
    }
}