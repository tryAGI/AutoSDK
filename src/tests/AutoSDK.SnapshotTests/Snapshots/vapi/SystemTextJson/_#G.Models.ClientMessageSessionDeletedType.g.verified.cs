//HintName: G.Models.ClientMessageSessionDeletedType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the message. "session.deleted" is sent when a session is deleted.
    /// </summary>
    public enum ClientMessageSessionDeletedType
    {
        /// <summary>
        /// 
        /// </summary>
        SessionDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClientMessageSessionDeletedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClientMessageSessionDeletedType value)
        {
            return value switch
            {
                ClientMessageSessionDeletedType.SessionDeleted => "session.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClientMessageSessionDeletedType? ToEnum(string value)
        {
            return value switch
            {
                "session.deleted" => ClientMessageSessionDeletedType.SessionDeleted,
                _ => null,
            };
        }
    }
}