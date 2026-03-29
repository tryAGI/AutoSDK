//HintName: G.Models.ClientMessageSessionUpdatedType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the message. "session.updated" is sent when a session is updated.
    /// </summary>
    public enum ClientMessageSessionUpdatedType
    {
        /// <summary>
        /// 
        /// </summary>
        SessionUpdated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClientMessageSessionUpdatedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClientMessageSessionUpdatedType value)
        {
            return value switch
            {
                ClientMessageSessionUpdatedType.SessionUpdated => "session.updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClientMessageSessionUpdatedType? ToEnum(string value)
        {
            return value switch
            {
                "session.updated" => ClientMessageSessionUpdatedType.SessionUpdated,
                _ => null,
            };
        }
    }
}