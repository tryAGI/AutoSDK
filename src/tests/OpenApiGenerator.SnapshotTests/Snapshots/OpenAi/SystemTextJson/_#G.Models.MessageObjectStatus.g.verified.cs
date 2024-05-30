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

    public static class MessageObjectStatusExtensions
    {
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
        public static MessageObjectStatus ToEnum(int value)
        {
            return value switch
            {
                0 => MessageObjectStatus.InProgress,
                1 => MessageObjectStatus.Incomplete,
                2 => MessageObjectStatus.Completed,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}