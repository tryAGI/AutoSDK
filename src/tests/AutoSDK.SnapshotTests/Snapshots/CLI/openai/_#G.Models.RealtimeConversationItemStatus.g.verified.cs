//HintName: G.Models.RealtimeConversationItemStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the item (`completed`, `incomplete`). These have no effect <br/>
    /// on the conversation, but are accepted for consistency with the <br/>
    /// `conversation.item.created` event.
    /// </summary>
    public enum RealtimeConversationItemStatus
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
    public static class RealtimeConversationItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeConversationItemStatus value)
        {
            return value switch
            {
                RealtimeConversationItemStatus.Completed => "completed",
                RealtimeConversationItemStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeConversationItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => RealtimeConversationItemStatus.Completed,
                "incomplete" => RealtimeConversationItemStatus.Incomplete,
                _ => null,
            };
        }
    }
}