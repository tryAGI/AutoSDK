//HintName: G.Models.ServerMessageStatusUpdateType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the message. "status-update" is sent whenever the `call.status` changes.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ServerMessageStatusUpdateType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="status-update")]
        StatusUpdate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerMessageStatusUpdateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerMessageStatusUpdateType value)
        {
            return value switch
            {
                ServerMessageStatusUpdateType.StatusUpdate => "status-update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerMessageStatusUpdateType? ToEnum(string value)
        {
            return value switch
            {
                "status-update" => ServerMessageStatusUpdateType.StatusUpdate,
                _ => null,
            };
        }
    }
}