//HintName: G.Models.ConversationItemTruncatePayloadType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConversationItemTruncatePayloadType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="conversation.item.truncate")]
        ConversationItemTruncate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationItemTruncatePayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationItemTruncatePayloadType value)
        {
            return value switch
            {
                ConversationItemTruncatePayloadType.ConversationItemTruncate => "conversation.item.truncate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationItemTruncatePayloadType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.item.truncate" => ConversationItemTruncatePayloadType.ConversationItemTruncate,
                _ => null,
            };
        }
    }
}