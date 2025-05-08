//HintName: G.Models.RealtimeClientEventTranscriptionSessionUpdateType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type, must be `transcription_session.update`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RealtimeClientEventTranscriptionSessionUpdateType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="transcription_session.update")]
        TranscriptionSessionUpdate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeClientEventTranscriptionSessionUpdateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeClientEventTranscriptionSessionUpdateType value)
        {
            return value switch
            {
                RealtimeClientEventTranscriptionSessionUpdateType.TranscriptionSessionUpdate => "transcription_session.update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeClientEventTranscriptionSessionUpdateType? ToEnum(string value)
        {
            return value switch
            {
                "transcription_session.update" => RealtimeClientEventTranscriptionSessionUpdateType.TranscriptionSessionUpdate,
                _ => null,
            };
        }
    }
}