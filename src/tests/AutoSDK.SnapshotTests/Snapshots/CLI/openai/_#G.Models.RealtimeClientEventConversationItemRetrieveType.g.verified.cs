//HintName: G.Models.RealtimeClientEventConversationItemRetrieveType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type, must be `conversation.item.retrieve`.
    /// </summary>
    public enum RealtimeClientEventConversationItemRetrieveType
    {
        /// <summary>
        /// 
        /// </summary>
        ConversationItemRetrieve,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeClientEventConversationItemRetrieveTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeClientEventConversationItemRetrieveType value)
        {
            return value switch
            {
                RealtimeClientEventConversationItemRetrieveType.ConversationItemRetrieve => "conversation.item.retrieve",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeClientEventConversationItemRetrieveType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.item.retrieve" => RealtimeClientEventConversationItemRetrieveType.ConversationItemRetrieve,
                _ => null,
            };
        }
    }
}