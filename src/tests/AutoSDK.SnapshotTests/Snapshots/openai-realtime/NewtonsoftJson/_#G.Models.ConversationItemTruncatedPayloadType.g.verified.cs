//HintName: G.Models.ConversationItemTruncatedPayloadType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConversationItemTruncatedPayloadType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="conversation.item.truncated")]
        ConversationItemTruncated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationItemTruncatedPayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationItemTruncatedPayloadType value)
        {
            return value switch
            {
                ConversationItemTruncatedPayloadType.ConversationItemTruncated => "conversation.item.truncated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationItemTruncatedPayloadType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.item.truncated" => ConversationItemTruncatedPayloadType.ConversationItemTruncated,
                _ => null,
            };
        }
    }
}