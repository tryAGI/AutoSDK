//HintName: G.Models.SessionSortableColumns.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SessionSortableColumns
    {
        /// <summary>
        /// 
        /// </summary>
        ErrorRate,
        /// <summary>
        /// 
        /// </summary>
        Feedback,
        /// <summary>
        /// 
        /// </summary>
        LastRunStartTime,
        /// <summary>
        /// 
        /// </summary>
        LatencyP50,
        /// <summary>
        /// 
        /// </summary>
        LatencyP99,
        /// <summary>
        /// 
        /// </summary>
        Name,
        /// <summary>
        /// 
        /// </summary>
        StartTime,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionSortableColumnsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionSortableColumns value)
        {
            return value switch
            {
                SessionSortableColumns.ErrorRate => "error_rate",
                SessionSortableColumns.Feedback => "feedback",
                SessionSortableColumns.LastRunStartTime => "last_run_start_time",
                SessionSortableColumns.LatencyP50 => "latency_p50",
                SessionSortableColumns.LatencyP99 => "latency_p99",
                SessionSortableColumns.Name => "name",
                SessionSortableColumns.StartTime => "start_time",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionSortableColumns? ToEnum(string value)
        {
            return value switch
            {
                "error_rate" => SessionSortableColumns.ErrorRate,
                "feedback" => SessionSortableColumns.Feedback,
                "last_run_start_time" => SessionSortableColumns.LastRunStartTime,
                "latency_p50" => SessionSortableColumns.LatencyP50,
                "latency_p99" => SessionSortableColumns.LatencyP99,
                "name" => SessionSortableColumns.Name,
                "start_time" => SessionSortableColumns.StartTime,
                _ => null,
            };
        }
    }
}