//HintName: G.Models.ServerMessageChatCreatedType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the message. "chat.created" is sent when a new chat is created.
    /// </summary>
    public enum ServerMessageChatCreatedType
    {
        /// <summary>
        /// 
        /// </summary>
        ChatCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerMessageChatCreatedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerMessageChatCreatedType value)
        {
            return value switch
            {
                ServerMessageChatCreatedType.ChatCreated => "chat.created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerMessageChatCreatedType? ToEnum(string value)
        {
            return value switch
            {
                "chat.created" => ServerMessageChatCreatedType.ChatCreated,
                _ => null,
            };
        }
    }
}