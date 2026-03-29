//HintName: G.Models.OutputServerToolItemStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputServerToolItemStatus
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
    public static class OutputServerToolItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputServerToolItemStatus value)
        {
            return value switch
            {
                OutputServerToolItemStatus.Completed => "completed",
                OutputServerToolItemStatus.InProgress => "in_progress",
                OutputServerToolItemStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputServerToolItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => OutputServerToolItemStatus.Completed,
                "in_progress" => OutputServerToolItemStatus.InProgress,
                "incomplete" => OutputServerToolItemStatus.Incomplete,
                _ => null,
            };
        }
    }
}