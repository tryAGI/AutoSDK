//HintName: G.Models.BulkExportRunStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BulkExportRunStatus
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
        Created,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        FailedRetryable,
        /// <summary>
        /// 
        /// </summary>
        TimedOut,
        /// <summary>
        /// 
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BulkExportRunStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BulkExportRunStatus value)
        {
            return value switch
            {
                BulkExportRunStatus.Cancelled => "Cancelled",
                BulkExportRunStatus.Completed => "Completed",
                BulkExportRunStatus.Created => "Created",
                BulkExportRunStatus.Failed => "Failed",
                BulkExportRunStatus.FailedRetryable => "FailedRetryable",
                BulkExportRunStatus.TimedOut => "TimedOut",
                BulkExportRunStatus.Running => "Running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BulkExportRunStatus? ToEnum(string value)
        {
            return value switch
            {
                "Cancelled" => BulkExportRunStatus.Cancelled,
                "Completed" => BulkExportRunStatus.Completed,
                "Created" => BulkExportRunStatus.Created,
                "Failed" => BulkExportRunStatus.Failed,
                "FailedRetryable" => BulkExportRunStatus.FailedRetryable,
                "TimedOut" => BulkExportRunStatus.TimedOut,
                "Running" => BulkExportRunStatus.Running,
                _ => null,
            };
        }
    }
}