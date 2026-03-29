//HintName: G.Models.ServerMessageCallDeleteFailedType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the message. "call.deleted" is sent when a call is deleted.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ServerMessageCallDeleteFailedType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.delete.failed")]
        CallDeleteFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerMessageCallDeleteFailedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerMessageCallDeleteFailedType value)
        {
            return value switch
            {
                ServerMessageCallDeleteFailedType.CallDeleteFailed => "call.delete.failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerMessageCallDeleteFailedType? ToEnum(string value)
        {
            return value switch
            {
                "call.delete.failed" => ServerMessageCallDeleteFailedType.CallDeleteFailed,
                _ => null,
            };
        }
    }
}