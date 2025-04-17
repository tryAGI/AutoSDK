//HintName: G.Models.BatchJobStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BatchJobStatus
    {
        /// <summary>
        /// 
        /// </summary>
        QUEUED,
        /// <summary>
        /// 
        /// </summary>
        RUNNING,
        /// <summary>
        /// 
        /// </summary>
        SUCCESS,
        /// <summary>
        /// 
        /// </summary>
        FAILED,
        /// <summary>
        /// 
        /// </summary>
        TIMEOUTEXCEEDED,
        /// <summary>
        /// 
        /// </summary>
        CANCELLATIONREQUESTED,
        /// <summary>
        /// 
        /// </summary>
        CANCELLED,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchJobStatus value)
        {
            return value switch
            {
                BatchJobStatus.QUEUED => "QUEUED",
                BatchJobStatus.RUNNING => "RUNNING",
                BatchJobStatus.SUCCESS => "SUCCESS",
                BatchJobStatus.FAILED => "FAILED",
                BatchJobStatus.TIMEOUTEXCEEDED => "TIMEOUT_EXCEEDED",
                BatchJobStatus.CANCELLATIONREQUESTED => "CANCELLATION_REQUESTED",
                BatchJobStatus.CANCELLED => "CANCELLED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "QUEUED" => BatchJobStatus.QUEUED,
                "RUNNING" => BatchJobStatus.RUNNING,
                "SUCCESS" => BatchJobStatus.SUCCESS,
                "FAILED" => BatchJobStatus.FAILED,
                "TIMEOUT_EXCEEDED" => BatchJobStatus.TIMEOUTEXCEEDED,
                "CANCELLATION_REQUESTED" => BatchJobStatus.CANCELLATIONREQUESTED,
                "CANCELLED" => BatchJobStatus.CANCELLED,
                _ => null,
            };
        }
    }
}