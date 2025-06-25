//HintName: G.Models.RealtimeConversationItemWithReferenceStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the item (`completed`, `incomplete`). These have no effect <br/>
    /// on the conversation, but are accepted for consistency with the <br/>
    /// `conversation.item.created` event.
    /// </summary>
    public enum RealtimeConversationItemWithReferenceStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Incomplete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeConversationItemWithReferenceStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeConversationItemWithReferenceStatus value)
        {
            return value switch
            {
                RealtimeConversationItemWithReferenceStatus.Completed => "completed",
                RealtimeConversationItemWithReferenceStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeConversationItemWithReferenceStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => RealtimeConversationItemWithReferenceStatus.Completed,
                "incomplete" => RealtimeConversationItemWithReferenceStatus.Incomplete,
                _ => null,
            };
        }
    }
}