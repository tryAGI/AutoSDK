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
        InProgress,
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
    public static class InputMessageStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputMessageStatus value)
        {
            return value switch
            {
                InputMessageStatus.InProgress => "in_progress",
                InputMessageStatus.Completed => "completed",
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
                "in_progress" => InputMessageStatus.InProgress,
                "completed" => InputMessageStatus.Completed,
                "incomplete" => InputMessageStatus.Incomplete,
                _ => null,
            };
        }
    }
}