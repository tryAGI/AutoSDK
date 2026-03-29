//HintName: G.Models.ListBatchJobsStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListBatchJobsStatus
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
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Queued,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListBatchJobsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListBatchJobsStatus value)
        {
            return value switch
            {
                ListBatchJobsStatus.Completed => "COMPLETED",
                ListBatchJobsStatus.Failed => "FAILED",
                ListBatchJobsStatus.InProgress => "IN_PROGRESS",
                ListBatchJobsStatus.Queued => "QUEUED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListBatchJobsStatus? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETED" => ListBatchJobsStatus.Completed,
                "FAILED" => ListBatchJobsStatus.Failed,
                "IN_PROGRESS" => ListBatchJobsStatus.InProgress,
                "QUEUED" => ListBatchJobsStatus.Queued,
                _ => null,
            };
        }
    }
}