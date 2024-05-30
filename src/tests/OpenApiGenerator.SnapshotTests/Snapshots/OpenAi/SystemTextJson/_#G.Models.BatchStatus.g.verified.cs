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

    public static class BatchStatusExtensions
    {
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
        public static BatchStatus ToEnum(string value)
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
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static BatchStatus ToEnum(int value)
        {
            return value switch
            {
                0 => BatchStatus.Validating,
                1 => BatchStatus.Failed,
                2 => BatchStatus.InProgress,
                3 => BatchStatus.Finalizing,
                4 => BatchStatus.Completed,
                5 => BatchStatus.Expired,
                6 => BatchStatus.Cancelling,
                7 => BatchStatus.Cancelled,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}