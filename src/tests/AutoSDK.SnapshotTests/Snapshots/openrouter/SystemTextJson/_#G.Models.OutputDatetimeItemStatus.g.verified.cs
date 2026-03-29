//HintName: G.Models.OutputDatetimeItemStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputDatetimeItemStatus
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
    public static class OutputDatetimeItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputDatetimeItemStatus value)
        {
            return value switch
            {
                OutputDatetimeItemStatus.Completed => "completed",
                OutputDatetimeItemStatus.InProgress => "in_progress",
                OutputDatetimeItemStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputDatetimeItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => OutputDatetimeItemStatus.Completed,
                "in_progress" => OutputDatetimeItemStatus.InProgress,
                "incomplete" => OutputDatetimeItemStatus.Incomplete,
                _ => null,
            };
        }
    }
}