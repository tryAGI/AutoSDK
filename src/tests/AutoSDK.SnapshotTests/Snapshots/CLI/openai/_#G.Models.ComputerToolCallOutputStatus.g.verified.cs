//HintName: G.Models.ComputerToolCallOutputStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the message input. One of `in_progress`, `completed`, or<br/>
    /// `incomplete`. Populated when input items are returned via API.
    /// </summary>
    public enum ComputerToolCallOutputStatus
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
    public static class ComputerToolCallOutputStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComputerToolCallOutputStatus value)
        {
            return value switch
            {
                ComputerToolCallOutputStatus.InProgress => "in_progress",
                ComputerToolCallOutputStatus.Completed => "completed",
                ComputerToolCallOutputStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComputerToolCallOutputStatus? ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => ComputerToolCallOutputStatus.InProgress,
                "completed" => ComputerToolCallOutputStatus.Completed,
                "incomplete" => ComputerToolCallOutputStatus.Incomplete,
                _ => null,
            };
        }
    }
}