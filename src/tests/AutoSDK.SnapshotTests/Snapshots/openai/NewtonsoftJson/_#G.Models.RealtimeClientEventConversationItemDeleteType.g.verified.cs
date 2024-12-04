//HintName: G.Models.RealtimeClientEventConversationItemDeleteType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type, must be `conversation.item.delete`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RealtimeClientEventConversationItemDeleteType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="conversation.item.delete")]
        ConversationItemDelete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeClientEventConversationItemDeleteTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeClientEventConversationItemDeleteType value)
        {
            return value switch
            {
                RealtimeClientEventConversationItemDeleteType.ConversationItemDelete => "conversation.item.delete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeClientEventConversationItemDeleteType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.item.delete" => RealtimeClientEventConversationItemDeleteType.ConversationItemDelete,
                _ => null,
            };
        }
    }
}