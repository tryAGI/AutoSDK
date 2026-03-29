//HintName: G.Models.ClientMessageChatCreatedType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the message. "chat.created" is sent when a new chat is created.
    /// </summary>
    public enum ClientMessageChatCreatedType
    {
        /// <summary>
        /// 
        /// </summary>
        ChatCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClientMessageChatCreatedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClientMessageChatCreatedType value)
        {
            return value switch
            {
                ClientMessageChatCreatedType.ChatCreated => "chat.created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClientMessageChatCreatedType? ToEnum(string value)
        {
            return value switch
            {
                "chat.created" => ClientMessageChatCreatedType.ChatCreated,
                _ => null,
            };
        }
    }
}