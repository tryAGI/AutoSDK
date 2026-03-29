//HintName: G.Models.BatchFileStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Status of an individual file in a batch job.
    /// </summary>
    public enum BatchFileStatus
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
        Processing,
        /// <summary>
        /// 
        /// </summary>
        Skipped,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchFileStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchFileStatus value)
        {
            return value switch
            {
                BatchFileStatus.Cancelled => "cancelled",
                BatchFileStatus.Completed => "completed",
                BatchFileStatus.Failed => "failed",
                BatchFileStatus.Pending => "pending",
                BatchFileStatus.Processing => "processing",
                BatchFileStatus.Skipped => "skipped",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchFileStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => BatchFileStatus.Cancelled,
                "completed" => BatchFileStatus.Completed,
                "failed" => BatchFileStatus.Failed,
                "pending" => BatchFileStatus.Pending,
                "processing" => BatchFileStatus.Processing,
                "skipped" => BatchFileStatus.Skipped,
                _ => null,
            };
        }
    }
}