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
        Name,
        /// <summary>
        /// 
        /// </summary>
        StartTime,
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
        ErrorRate,
        /// <summary>
        /// 
        /// </summary>
        Feedback,
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
                SessionSortableColumns.Name => "name",
                SessionSortableColumns.StartTime => "start_time",
                SessionSortableColumns.LastRunStartTime => "last_run_start_time",
                SessionSortableColumns.LatencyP50 => "latency_p50",
                SessionSortableColumns.LatencyP99 => "latency_p99",
                SessionSortableColumns.ErrorRate => "error_rate",
                SessionSortableColumns.Feedback => "feedback",
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
                "name" => SessionSortableColumns.Name,
                "start_time" => SessionSortableColumns.StartTime,
                "last_run_start_time" => SessionSortableColumns.LastRunStartTime,
                "latency_p50" => SessionSortableColumns.LatencyP50,
                "latency_p99" => SessionSortableColumns.LatencyP99,
                "error_rate" => SessionSortableColumns.ErrorRate,
                "feedback" => SessionSortableColumns.Feedback,
                _ => null,
            };
        }
    }
}