//HintName: G.Models.ChatMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        Chatmessage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatMessageType value)
        {
            return value switch
            {
                ChatMessageType.Chatmessage => "chatmessage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatMessageType? ToEnum(string value)
        {
            return value switch
            {
                "chatmessage" => ChatMessageType.Chatmessage,
                _ => null,
            };
        }
    }
}