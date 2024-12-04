//HintName: G.Models.RealtimeServerEventConversationCreatedType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type, must be `conversation.created`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RealtimeServerEventConversationCreatedType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="conversation.created")]
        ConversationCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeServerEventConversationCreatedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventConversationCreatedType value)
        {
            return value switch
            {
                RealtimeServerEventConversationCreatedType.ConversationCreated => "conversation.created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventConversationCreatedType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.created" => RealtimeServerEventConversationCreatedType.ConversationCreated,
                _ => null,
            };
        }
    }
}