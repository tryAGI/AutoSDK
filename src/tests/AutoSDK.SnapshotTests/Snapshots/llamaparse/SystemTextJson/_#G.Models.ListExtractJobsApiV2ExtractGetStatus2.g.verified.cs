//HintName: G.Models.ListExtractJobsApiV2ExtractGetStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListExtractJobsApiV2ExtractGetStatus2
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
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Running,
        /// <summary>
        /// 
        /// </summary>
        Throttled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListExtractJobsApiV2ExtractGetStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListExtractJobsApiV2ExtractGetStatus2 value)
        {
            return value switch
            {
                ListExtractJobsApiV2ExtractGetStatus2.Cancelled => "CANCELLED",
                ListExtractJobsApiV2ExtractGetStatus2.Completed => "COMPLETED",
                ListExtractJobsApiV2ExtractGetStatus2.Failed => "FAILED",
                ListExtractJobsApiV2ExtractGetStatus2.Pending => "PENDING",
                ListExtractJobsApiV2ExtractGetStatus2.Running => "RUNNING",
                ListExtractJobsApiV2ExtractGetStatus2.Throttled => "THROTTLED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListExtractJobsApiV2ExtractGetStatus2? ToEnum(string value)
        {
            return value switch
            {
                "CANCELLED" => ListExtractJobsApiV2ExtractGetStatus2.Cancelled,
                "COMPLETED" => ListExtractJobsApiV2ExtractGetStatus2.Completed,
                "FAILED" => ListExtractJobsApiV2ExtractGetStatus2.Failed,
                "PENDING" => ListExtractJobsApiV2ExtractGetStatus2.Pending,
                "RUNNING" => ListExtractJobsApiV2ExtractGetStatus2.Running,
                "THROTTLED" => ListExtractJobsApiV2ExtractGetStatus2.Throttled,
                _ => null,
            };
        }
    }
}