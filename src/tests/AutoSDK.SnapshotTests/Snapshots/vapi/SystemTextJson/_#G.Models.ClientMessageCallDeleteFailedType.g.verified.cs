//HintName: G.Models.ClientMessageCallDeleteFailedType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the message. "call.deleted" is sent when a call is deleted.
    /// </summary>
    public enum ClientMessageCallDeleteFailedType
    {
        /// <summary>
        /// 
        /// </summary>
        CallDeleteFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClientMessageCallDeleteFailedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClientMessageCallDeleteFailedType value)
        {
            return value switch
            {
                ClientMessageCallDeleteFailedType.CallDeleteFailed => "call.delete.failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClientMessageCallDeleteFailedType? ToEnum(string value)
        {
            return value switch
            {
                "call.delete.failed" => ClientMessageCallDeleteFailedType.CallDeleteFailed,
                _ => null,
            };
        }
    }
}