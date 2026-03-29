//HintName: G.Models.ListParseJobsApiV2ParseGetStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListParseJobsApiV2ParseGetStatus2
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListParseJobsApiV2ParseGetStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListParseJobsApiV2ParseGetStatus2 value)
        {
            return value switch
            {
                ListParseJobsApiV2ParseGetStatus2.Cancelled => "CANCELLED",
                ListParseJobsApiV2ParseGetStatus2.Completed => "COMPLETED",
                ListParseJobsApiV2ParseGetStatus2.Failed => "FAILED",
                ListParseJobsApiV2ParseGetStatus2.Pending => "PENDING",
                ListParseJobsApiV2ParseGetStatus2.Running => "RUNNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListParseJobsApiV2ParseGetStatus2? ToEnum(string value)
        {
            return value switch
            {
                "CANCELLED" => ListParseJobsApiV2ParseGetStatus2.Cancelled,
                "COMPLETED" => ListParseJobsApiV2ParseGetStatus2.Completed,
                "FAILED" => ListParseJobsApiV2ParseGetStatus2.Failed,
                "PENDING" => ListParseJobsApiV2ParseGetStatus2.Pending,
                "RUNNING" => ListParseJobsApiV2ParseGetStatus2.Running,
                _ => null,
            };
        }
    }
}