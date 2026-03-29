//HintName: G.Models.ServerMessageChatDeletedType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the message. "chat.deleted" is sent when a chat is deleted.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ServerMessageChatDeletedType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chat.deleted")]
        ChatDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerMessageChatDeletedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerMessageChatDeletedType value)
        {
            return value switch
            {
                ServerMessageChatDeletedType.ChatDeleted => "chat.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerMessageChatDeletedType? ToEnum(string value)
        {
            return value switch
            {
                "chat.deleted" => ServerMessageChatDeletedType.ChatDeleted,
                _ => null,
            };
        }
    }
}