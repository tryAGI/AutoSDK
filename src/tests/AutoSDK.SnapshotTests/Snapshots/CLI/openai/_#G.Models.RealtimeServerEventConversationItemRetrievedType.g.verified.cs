//HintName: G.Models.RealtimeServerEventConversationItemRetrievedType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type, must be `conversation.item.retrieved`.
    /// </summary>
    public enum RealtimeServerEventConversationItemRetrievedType
    {
        /// <summary>
        /// 
        /// </summary>
        ConversationItemRetrieved,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeServerEventConversationItemRetrievedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventConversationItemRetrievedType value)
        {
            return value switch
            {
                RealtimeServerEventConversationItemRetrievedType.ConversationItemRetrieved => "conversation.item.retrieved",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventConversationItemRetrievedType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.item.retrieved" => RealtimeServerEventConversationItemRetrievedType.ConversationItemRetrieved,
                _ => null,
            };
        }
    }
}