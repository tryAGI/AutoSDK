//HintName: G.Models.RealtimeServerEventConversationItemCreatedType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type, must be `conversation.item.created`.
    /// </summary>
    public enum RealtimeServerEventConversationItemCreatedType
    {
        /// <summary>
        /// 
        /// </summary>
        ConversationItemCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeServerEventConversationItemCreatedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventConversationItemCreatedType value)
        {
            return value switch
            {
                RealtimeServerEventConversationItemCreatedType.ConversationItemCreated => "conversation.item.created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventConversationItemCreatedType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.item.created" => RealtimeServerEventConversationItemCreatedType.ConversationItemCreated,
                _ => null,
            };
        }
    }
}