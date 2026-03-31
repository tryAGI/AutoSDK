//HintName: G.Models.ChatEndEventDataEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatEndEventDataEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ChatEnd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatEndEventDataEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatEndEventDataEventType value)
        {
            return value switch
            {
                ChatEndEventDataEventType.ChatEnd => "chat/end",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatEndEventDataEventType? ToEnum(string value)
        {
            return value switch
            {
                "chat/end" => ChatEndEventDataEventType.ChatEnd,
                _ => null,
            };
        }
    }
}