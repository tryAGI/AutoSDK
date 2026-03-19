//HintName: G.Models.SessionStartedPayloadMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Must be 'session_started'.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SessionStartedPayloadMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="session_started")]
        SessionStarted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionStartedPayloadMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionStartedPayloadMessageType value)
        {
            return value switch
            {
                SessionStartedPayloadMessageType.SessionStarted => "session_started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionStartedPayloadMessageType? ToEnum(string value)
        {
            return value switch
            {
                "session_started" => SessionStartedPayloadMessageType.SessionStarted,
                _ => null,
            };
        }
    }
}