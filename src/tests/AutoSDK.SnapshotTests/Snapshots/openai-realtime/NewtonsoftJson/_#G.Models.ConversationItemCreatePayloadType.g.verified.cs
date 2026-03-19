//HintName: G.Models.ConversationItemCreatePayloadType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConversationItemCreatePayloadType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="conversation.item.create")]
        ConversationItemCreate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationItemCreatePayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationItemCreatePayloadType value)
        {
            return value switch
            {
                ConversationItemCreatePayloadType.ConversationItemCreate => "conversation.item.create",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationItemCreatePayloadType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.item.create" => ConversationItemCreatePayloadType.ConversationItemCreate,
                _ => null,
            };
        }
    }
}