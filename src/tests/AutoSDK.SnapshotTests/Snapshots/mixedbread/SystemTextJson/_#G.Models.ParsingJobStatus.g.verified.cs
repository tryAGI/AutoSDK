//HintName: G.Models.ParsingJobStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ParsingJobStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ParsingJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ParsingJobStatus value)
        {
            return value switch
            {
                ParsingJobStatus.Cancelled => "cancelled",
                ParsingJobStatus.Completed => "completed",
                ParsingJobStatus.Failed => "failed",
                ParsingJobStatus.InProgress => "in_progress",
                ParsingJobStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ParsingJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => ParsingJobStatus.Cancelled,
                "completed" => ParsingJobStatus.Completed,
                "failed" => ParsingJobStatus.Failed,
                "in_progress" => ParsingJobStatus.InProgress,
                "pending" => ParsingJobStatus.Pending,
                _ => null,
            };
        }
    }
}