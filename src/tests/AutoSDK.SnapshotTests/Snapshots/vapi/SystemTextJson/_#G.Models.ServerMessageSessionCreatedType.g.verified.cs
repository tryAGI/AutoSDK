//HintName: G.Models.ServerMessageSessionCreatedType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the message. "session.created" is sent when a new session is created.
    /// </summary>
    public enum ServerMessageSessionCreatedType
    {
        /// <summary>
        /// 
        /// </summary>
        SessionCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerMessageSessionCreatedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerMessageSessionCreatedType value)
        {
            return value switch
            {
                ServerMessageSessionCreatedType.SessionCreated => "session.created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerMessageSessionCreatedType? ToEnum(string value)
        {
            return value switch
            {
                "session.created" => ServerMessageSessionCreatedType.SessionCreated,
                _ => null,
            };
        }
    }
}