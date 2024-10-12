//HintName: G.Models.BulkExportStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BulkExportStatus
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
    public static class BulkExportStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BulkExportStatus value)
        {
            return value switch
            {
                BulkExportStatus.Cancelled => "Cancelled",
                BulkExportStatus.Completed => "Completed",
                BulkExportStatus.Created => "Created",
                BulkExportStatus.Failed => "Failed",
                BulkExportStatus.FailedRetryable => "FailedRetryable",
                BulkExportStatus.TimedOut => "TimedOut",
                BulkExportStatus.Running => "Running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BulkExportStatus? ToEnum(string value)
        {
            return value switch
            {
                "Cancelled" => BulkExportStatus.Cancelled,
                "Completed" => BulkExportStatus.Completed,
                "Created" => BulkExportStatus.Created,
                "Failed" => BulkExportStatus.Failed,
                "FailedRetryable" => BulkExportStatus.FailedRetryable,
                "TimedOut" => BulkExportStatus.TimedOut,
                "Running" => BulkExportStatus.Running,
                _ => null,
            };
        }
    }
}