//HintName: G.Models.RealtimeServerEventTranscriptionSessionUpdatedType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type, must be `transcription_session.updated`.
    /// </summary>
    public enum RealtimeServerEventTranscriptionSessionUpdatedType
    {
        /// <summary>
        /// 
        /// </summary>
        TranscriptionSessionUpdated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeServerEventTranscriptionSessionUpdatedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventTranscriptionSessionUpdatedType value)
        {
            return value switch
            {
                RealtimeServerEventTranscriptionSessionUpdatedType.TranscriptionSessionUpdated => "transcription_session.updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventTranscriptionSessionUpdatedType? ToEnum(string value)
        {
            return value switch
            {
                "transcription_session.updated" => RealtimeServerEventTranscriptionSessionUpdatedType.TranscriptionSessionUpdated,
                _ => null,
            };
        }
    }
}