//HintName: G.Models.ConversationItemCreatedPayloadType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type.
    /// </summary>
    public enum ConversationItemCreatedPayloadType
    {
        /// <summary>
        /// 
        /// </summary>
        ConversationItemCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationItemCreatedPayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationItemCreatedPayloadType value)
        {
            return value switch
            {
                ConversationItemCreatedPayloadType.ConversationItemCreated => "conversation.item.created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationItemCreatedPayloadType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.item.created" => ConversationItemCreatedPayloadType.ConversationItemCreated,
                _ => null,
            };
        }
    }
}