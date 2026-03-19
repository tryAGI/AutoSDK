//HintName: G.Models.ConversationItemStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the item.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConversationItemStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in_progress")]
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="incomplete")]
        Incomplete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationItemStatus value)
        {
            return value switch
            {
                ConversationItemStatus.Completed => "completed",
                ConversationItemStatus.InProgress => "in_progress",
                ConversationItemStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ConversationItemStatus.Completed,
                "in_progress" => ConversationItemStatus.InProgress,
                "incomplete" => ConversationItemStatus.Incomplete,
                _ => null,
            };
        }
    }
}