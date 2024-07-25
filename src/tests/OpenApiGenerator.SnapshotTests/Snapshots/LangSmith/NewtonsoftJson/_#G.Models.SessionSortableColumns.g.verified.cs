//HintName: G.Models.SessionSortableColumns.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SessionSortableColumns
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="name")]
        Name,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="start_time")]
        StartTime,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="last_run_start_time")]
        LastRunStartTime,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="latency_p50")]
        LatencyP50,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="latency_p99")]
        LatencyP99,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error_rate")]
        ErrorRate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="feedback")]
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