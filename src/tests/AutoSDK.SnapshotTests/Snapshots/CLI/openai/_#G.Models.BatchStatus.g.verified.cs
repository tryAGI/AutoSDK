//HintName: G.Models.BatchStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The current status of the batch.
    /// </summary>
    public enum BatchStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Validating,
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
        Finalizing,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Expired,
        /// <summary>
        /// 
        /// </summary>
        Cancelling,
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchStatus value)
        {
            return value switch
            {
                BatchStatus.Validating => "validating",
                BatchStatus.Failed => "failed",
                BatchStatus.InProgress => "in_progress",
                BatchStatus.Finalizing => "finalizing",
                BatchStatus.Completed => "completed",
                BatchStatus.Expired => "expired",
                BatchStatus.Cancelling => "cancelling",
                BatchStatus.Cancelled => "cancelled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchStatus? ToEnum(string value)
        {
            return value switch
            {
                "validating" => BatchStatus.Validating,
                "failed" => BatchStatus.Failed,
                "in_progress" => BatchStatus.InProgress,
                "finalizing" => BatchStatus.Finalizing,
                "completed" => BatchStatus.Completed,
                "expired" => BatchStatus.Expired,
                "cancelling" => BatchStatus.Cancelling,
                "cancelled" => BatchStatus.Cancelled,
                _ => null,
            };
        }
    }
}