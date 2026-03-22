//HintName: G.Models.InputMessageStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of item. One of `in_progress`, `completed`, or<br/>
    /// `incomplete`. Populated when items are returned via API.
    /// </summary>
    public enum InputMessageStatus
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
    public static class InputMessageStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputMessageStatus value)
        {
            return value switch
            {
                InputMessageStatus.Completed => "completed",
                InputMessageStatus.InProgress => "in_progress",
                InputMessageStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputMessageStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => InputMessageStatus.Completed,
                "in_progress" => InputMessageStatus.InProgress,
                "incomplete" => InputMessageStatus.Incomplete,
                _ => null,
            };
        }
    }
}