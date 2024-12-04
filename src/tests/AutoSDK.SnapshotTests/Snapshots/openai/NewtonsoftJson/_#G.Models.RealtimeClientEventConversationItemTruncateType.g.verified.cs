//HintName: G.Models.RealtimeClientEventConversationItemTruncateType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type, must be `conversation.item.truncate`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RealtimeClientEventConversationItemTruncateType
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
    public static class RealtimeClientEventConversationItemTruncateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeClientEventConversationItemTruncateType value)
        {
            return value switch
            {
                RealtimeClientEventConversationItemTruncateType.ConversationItemTruncate => "conversation.item.truncate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeClientEventConversationItemTruncateType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.item.truncate" => RealtimeClientEventConversationItemTruncateType.ConversationItemTruncate,
                _ => null,
            };
        }
    }
}