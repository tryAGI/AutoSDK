//HintName: G.Models.ConversationCreatedPayloadType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type.
    /// </summary>
    public enum ConversationCreatedPayloadType
    {
        /// <summary>
        /// 
        /// </summary>
        ConversationCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationCreatedPayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationCreatedPayloadType value)
        {
            return value switch
            {
                ConversationCreatedPayloadType.ConversationCreated => "conversation.created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationCreatedPayloadType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.created" => ConversationCreatedPayloadType.ConversationCreated,
                _ => null,
            };
        }
    }
}