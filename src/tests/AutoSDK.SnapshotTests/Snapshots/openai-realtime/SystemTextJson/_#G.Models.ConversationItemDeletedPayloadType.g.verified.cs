//HintName: G.Models.ConversationItemDeletedPayloadType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type.
    /// </summary>
    public enum ConversationItemDeletedPayloadType
    {
        /// <summary>
        /// 
        /// </summary>
        ConversationItemDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationItemDeletedPayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationItemDeletedPayloadType value)
        {
            return value switch
            {
                ConversationItemDeletedPayloadType.ConversationItemDeleted => "conversation.item.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationItemDeletedPayloadType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.item.deleted" => ConversationItemDeletedPayloadType.ConversationItemDeleted,
                _ => null,
            };
        }
    }
}