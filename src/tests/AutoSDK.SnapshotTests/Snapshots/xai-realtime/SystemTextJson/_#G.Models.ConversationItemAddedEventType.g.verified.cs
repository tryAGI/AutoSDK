//HintName: G.Models.ConversationItemAddedEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConversationItemAddedEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ConversationItemAdded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationItemAddedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationItemAddedEventType value)
        {
            return value switch
            {
                ConversationItemAddedEventType.ConversationItemAdded => "conversation.item.added",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationItemAddedEventType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.item.added" => ConversationItemAddedEventType.ConversationItemAdded,
                _ => null,
            };
        }
    }
}