//HintName: G.Models.OutputMessageStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the message input. One of `in_progress`, `completed`, or<br/>
    /// `incomplete`. Populated when input items are returned via API.
    /// </summary>
    public enum OutputMessageStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Incomplete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputMessageStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputMessageStatus value)
        {
            return value switch
            {
                OutputMessageStatus.Completed => "completed",
                OutputMessageStatus.InProgress => "in_progress",
                OutputMessageStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputMessageStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => OutputMessageStatus.Completed,
                "in_progress" => OutputMessageStatus.InProgress,
                "incomplete" => OutputMessageStatus.Incomplete,
                _ => null,
            };
        }
    }
}