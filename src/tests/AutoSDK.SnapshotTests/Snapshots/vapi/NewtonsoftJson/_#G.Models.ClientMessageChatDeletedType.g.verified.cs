//HintName: G.Models.ClientMessageChatDeletedType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the message. "chat.deleted" is sent when a chat is deleted.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ClientMessageChatDeletedType
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
    public static class ClientMessageChatDeletedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClientMessageChatDeletedType value)
        {
            return value switch
            {
                ClientMessageChatDeletedType.ChatDeleted => "chat.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClientMessageChatDeletedType? ToEnum(string value)
        {
            return value switch
            {
                "chat.deleted" => ClientMessageChatDeletedType.ChatDeleted,
                _ => null,
            };
        }
    }
}