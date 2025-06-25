//HintName: G.Models.RealtimeServerEventConversationItemTruncatedType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type, must be `conversation.item.truncated`.
    /// </summary>
    public enum RealtimeServerEventConversationItemTruncatedType
    {
        /// <summary>
        /// 
        /// </summary>
        ConversationItemTruncated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeServerEventConversationItemTruncatedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventConversationItemTruncatedType value)
        {
            return value switch
            {
                RealtimeServerEventConversationItemTruncatedType.ConversationItemTruncated => "conversation.item.truncated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventConversationItemTruncatedType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.item.truncated" => RealtimeServerEventConversationItemTruncatedType.ConversationItemTruncated,
                _ => null,
            };
        }
    }
}