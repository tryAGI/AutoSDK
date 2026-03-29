//HintName: G.Models.ClientMessageCallDeletedType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the message. "call.deleted" is sent when a call is deleted.
    /// </summary>
    public enum ClientMessageCallDeletedType
    {
        /// <summary>
        /// 
        /// </summary>
        CallDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClientMessageCallDeletedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClientMessageCallDeletedType value)
        {
            return value switch
            {
                ClientMessageCallDeletedType.CallDeleted => "call.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClientMessageCallDeletedType? ToEnum(string value)
        {
            return value switch
            {
                "call.deleted" => ClientMessageCallDeletedType.CallDeleted,
                _ => null,
            };
        }
    }
}