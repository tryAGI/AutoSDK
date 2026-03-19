//HintName: G.Models.ConversationItemDeletePayloadType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type.
    /// </summary>
    public enum ConversationItemDeletePayloadType
    {
        /// <summary>
        /// 
        /// </summary>
        ConversationItemDelete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationItemDeletePayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationItemDeletePayloadType value)
        {
            return value switch
            {
                ConversationItemDeletePayloadType.ConversationItemDelete => "conversation.item.delete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationItemDeletePayloadType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.item.delete" => ConversationItemDeletePayloadType.ConversationItemDelete,
                _ => null,
            };
        }
    }
}