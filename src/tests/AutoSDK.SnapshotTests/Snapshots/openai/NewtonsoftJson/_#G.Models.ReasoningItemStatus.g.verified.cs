//HintName: G.Models.ReasoningItemStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the item. One of `in_progress`, `completed`, or<br/>
    /// `incomplete`. Populated when items are returned via API.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReasoningItemStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in_progress")]
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="incomplete")]
        Incomplete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReasoningItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasoningItemStatus value)
        {
            return value switch
            {
                ReasoningItemStatus.InProgress => "in_progress",
                ReasoningItemStatus.Completed => "completed",
                ReasoningItemStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => ReasoningItemStatus.InProgress,
                "completed" => ReasoningItemStatus.Completed,
                "incomplete" => ReasoningItemStatus.Incomplete,
                _ => null,
            };
        }
    }
}