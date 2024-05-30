//HintName: G.Models.MessageObjectStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the message, which can be either `in_progress`, `incomplete`, or `completed`.
    /// </summary>
    public enum MessageObjectStatus
    {
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Incomplete,
        /// <summary>
        /// 
        /// </summary>
        Completed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageObjectStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageObjectStatus value)
        {
            return value switch
            {
                MessageObjectStatus.InProgress => "in_progress",
                MessageObjectStatus.Incomplete => "incomplete",
                MessageObjectStatus.Completed => "completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageObjectStatus ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => MessageObjectStatus.InProgress,
                "incomplete" => MessageObjectStatus.Incomplete,
                "completed" => MessageObjectStatus.Completed,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}