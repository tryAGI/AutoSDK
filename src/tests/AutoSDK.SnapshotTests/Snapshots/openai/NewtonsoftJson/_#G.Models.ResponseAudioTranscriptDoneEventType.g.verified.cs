//HintName: G.Models.ResponseAudioTranscriptDoneEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the event. Always `response.audio.transcript.done`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseAudioTranscriptDoneEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.audio.transcript.done")]
        ResponseAudioTranscriptDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseAudioTranscriptDoneEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseAudioTranscriptDoneEventType value)
        {
            return value switch
            {
                ResponseAudioTranscriptDoneEventType.ResponseAudioTranscriptDone => "response.audio.transcript.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseAudioTranscriptDoneEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.audio.transcript.done" => ResponseAudioTranscriptDoneEventType.ResponseAudioTranscriptDone,
                _ => null,
            };
        }
    }
}