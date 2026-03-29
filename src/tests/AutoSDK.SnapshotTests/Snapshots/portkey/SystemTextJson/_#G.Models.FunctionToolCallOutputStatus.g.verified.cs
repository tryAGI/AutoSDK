//HintName: G.Models.FunctionToolCallOutputStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the item. One of `in_progress`, `completed`, or<br/>
    /// `incomplete`. Populated when items are returned via API.
    /// </summary>
    public enum FunctionToolCallOutputStatus
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
    public static class FunctionToolCallOutputStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionToolCallOutputStatus value)
        {
            return value switch
            {
                FunctionToolCallOutputStatus.Completed => "completed",
                FunctionToolCallOutputStatus.InProgress => "in_progress",
                FunctionToolCallOutputStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionToolCallOutputStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => FunctionToolCallOutputStatus.Completed,
                "in_progress" => FunctionToolCallOutputStatus.InProgress,
                "incomplete" => FunctionToolCallOutputStatus.Incomplete,
                _ => null,
            };
        }
    }
}