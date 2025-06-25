//HintName: G.Models.ComputerToolCallStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the item. One of `in_progress`, `completed`, or<br/>
    /// `incomplete`. Populated when items are returned via API.
    /// </summary>
    public enum ComputerToolCallStatus
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
    public static class ComputerToolCallStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComputerToolCallStatus value)
        {
            return value switch
            {
                ComputerToolCallStatus.InProgress => "in_progress",
                ComputerToolCallStatus.Completed => "completed",
                ComputerToolCallStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComputerToolCallStatus? ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => ComputerToolCallStatus.InProgress,
                "completed" => ComputerToolCallStatus.Completed,
                "incomplete" => ComputerToolCallStatus.Incomplete,
                _ => null,
            };
        }
    }
}