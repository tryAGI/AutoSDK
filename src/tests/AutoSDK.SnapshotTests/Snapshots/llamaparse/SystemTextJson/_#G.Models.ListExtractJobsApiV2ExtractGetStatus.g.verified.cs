//HintName: G.Models.ListExtractJobsApiV2ExtractGetStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListExtractJobsApiV2ExtractGetStatus
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
    public static class ListExtractJobsApiV2ExtractGetStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListExtractJobsApiV2ExtractGetStatus value)
        {
            return value switch
            {
                ListExtractJobsApiV2ExtractGetStatus.Cancelled => "CANCELLED",
                ListExtractJobsApiV2ExtractGetStatus.Completed => "COMPLETED",
                ListExtractJobsApiV2ExtractGetStatus.Failed => "FAILED",
                ListExtractJobsApiV2ExtractGetStatus.Pending => "PENDING",
                ListExtractJobsApiV2ExtractGetStatus.Running => "RUNNING",
                ListExtractJobsApiV2ExtractGetStatus.Throttled => "THROTTLED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListExtractJobsApiV2ExtractGetStatus? ToEnum(string value)
        {
            return value switch
            {
                "CANCELLED" => ListExtractJobsApiV2ExtractGetStatus.Cancelled,
                "COMPLETED" => ListExtractJobsApiV2ExtractGetStatus.Completed,
                "FAILED" => ListExtractJobsApiV2ExtractGetStatus.Failed,
                "PENDING" => ListExtractJobsApiV2ExtractGetStatus.Pending,
                "RUNNING" => ListExtractJobsApiV2ExtractGetStatus.Running,
                "THROTTLED" => ListExtractJobsApiV2ExtractGetStatus.Throttled,
                _ => null,
            };
        }
    }
}