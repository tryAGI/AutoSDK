//HintName: G.Models.ChatStartEventDataEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatStartEventDataEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ChatStart,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatStartEventDataEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatStartEventDataEventType value)
        {
            return value switch
            {
                ChatStartEventDataEventType.ChatStart => "chat/start",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatStartEventDataEventType? ToEnum(string value)
        {
            return value switch
            {
                "chat/start" => ChatStartEventDataEventType.ChatStart,
                _ => null,
            };
        }
    }
}