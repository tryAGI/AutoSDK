//HintName: G.Models.ListClassifyJobsApiV2ClassifyGetStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListClassifyJobsApiV2ClassifyGetStatus
    {
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
    public static class ListClassifyJobsApiV2ClassifyGetStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListClassifyJobsApiV2ClassifyGetStatus value)
        {
            return value switch
            {
                ListClassifyJobsApiV2ClassifyGetStatus.Completed => "COMPLETED",
                ListClassifyJobsApiV2ClassifyGetStatus.Failed => "FAILED",
                ListClassifyJobsApiV2ClassifyGetStatus.Pending => "PENDING",
                ListClassifyJobsApiV2ClassifyGetStatus.Running => "RUNNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListClassifyJobsApiV2ClassifyGetStatus? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETED" => ListClassifyJobsApiV2ClassifyGetStatus.Completed,
                "FAILED" => ListClassifyJobsApiV2ClassifyGetStatus.Failed,
                "PENDING" => ListClassifyJobsApiV2ClassifyGetStatus.Pending,
                "RUNNING" => ListClassifyJobsApiV2ClassifyGetStatus.Running,
                _ => null,
            };
        }
    }
}