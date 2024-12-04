//HintName: G.Models.RealtimeClientEventConversationItemCreateType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type, must be `conversation.item.create`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RealtimeClientEventConversationItemCreateType
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
    public static class RealtimeClientEventConversationItemCreateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeClientEventConversationItemCreateType value)
        {
            return value switch
            {
                RealtimeClientEventConversationItemCreateType.ConversationItemCreate => "conversation.item.create",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeClientEventConversationItemCreateType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.item.create" => RealtimeClientEventConversationItemCreateType.ConversationItemCreate,
                _ => null,
            };
        }
    }
}