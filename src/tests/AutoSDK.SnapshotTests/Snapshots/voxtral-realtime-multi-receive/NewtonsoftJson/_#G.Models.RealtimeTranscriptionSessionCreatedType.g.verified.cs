//HintName: G.Models.RealtimeTranscriptionSessionCreatedType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Must be 'session.created'.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RealtimeTranscriptionSessionCreatedType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="session.created")]
        SessionCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeTranscriptionSessionCreatedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeTranscriptionSessionCreatedType value)
        {
            return value switch
            {
                RealtimeTranscriptionSessionCreatedType.SessionCreated => "session.created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeTranscriptionSessionCreatedType? ToEnum(string value)
        {
            return value switch
            {
                "session.created" => RealtimeTranscriptionSessionCreatedType.SessionCreated,
                _ => null,
            };
        }
    }
}