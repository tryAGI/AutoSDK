//HintName: G.Models.RealtimeServerEventSessionCreatedType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type, must be `session.created`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RealtimeServerEventSessionCreatedType
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
    public static class RealtimeServerEventSessionCreatedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventSessionCreatedType value)
        {
            return value switch
            {
                RealtimeServerEventSessionCreatedType.SessionCreated => "session.created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventSessionCreatedType? ToEnum(string value)
        {
            return value switch
            {
                "session.created" => RealtimeServerEventSessionCreatedType.SessionCreated,
                _ => null,
            };
        }
    }
}