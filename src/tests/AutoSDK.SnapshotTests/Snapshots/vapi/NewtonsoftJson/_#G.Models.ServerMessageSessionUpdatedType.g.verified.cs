//HintName: G.Models.ServerMessageSessionUpdatedType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the message. "session.updated" is sent when a session is updated.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ServerMessageSessionUpdatedType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="session.updated")]
        SessionUpdated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerMessageSessionUpdatedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerMessageSessionUpdatedType value)
        {
            return value switch
            {
                ServerMessageSessionUpdatedType.SessionUpdated => "session.updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerMessageSessionUpdatedType? ToEnum(string value)
        {
            return value switch
            {
                "session.updated" => ServerMessageSessionUpdatedType.SessionUpdated,
                _ => null,
            };
        }
    }
}