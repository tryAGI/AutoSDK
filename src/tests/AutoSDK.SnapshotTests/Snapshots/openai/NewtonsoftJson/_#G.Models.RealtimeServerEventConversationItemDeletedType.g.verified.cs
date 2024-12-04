//HintName: G.Models.RealtimeServerEventConversationItemDeletedType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type, must be `conversation.item.deleted`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RealtimeServerEventConversationItemDeletedType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="conversation.item.deleted")]
        ConversationItemDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeServerEventConversationItemDeletedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventConversationItemDeletedType value)
        {
            return value switch
            {
                RealtimeServerEventConversationItemDeletedType.ConversationItemDeleted => "conversation.item.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventConversationItemDeletedType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.item.deleted" => RealtimeServerEventConversationItemDeletedType.ConversationItemDeleted,
                _ => null,
            };
        }
    }
}