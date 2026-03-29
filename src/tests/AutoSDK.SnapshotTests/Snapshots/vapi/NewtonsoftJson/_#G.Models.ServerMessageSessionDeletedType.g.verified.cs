//HintName: G.Models.ServerMessageSessionDeletedType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the message. "session.deleted" is sent when a session is deleted.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ServerMessageSessionDeletedType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="session.deleted")]
        SessionDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerMessageSessionDeletedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerMessageSessionDeletedType value)
        {
            return value switch
            {
                ServerMessageSessionDeletedType.SessionDeleted => "session.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerMessageSessionDeletedType? ToEnum(string value)
        {
            return value switch
            {
                "session.deleted" => ServerMessageSessionDeletedType.SessionDeleted,
                _ => null,
            };
        }
    }
}