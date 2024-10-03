//HintName: G.Models.DetailedJobOutStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DetailedJobOutStatus
    {
        /// <summary>
        /// 
        /// </summary>
        QUEUED,
        /// <summary>
        /// 
        /// </summary>
        STARTED,
        /// <summary>
        /// 
        /// </summary>
        VALIDATING,
        /// <summary>
        /// 
        /// </summary>
        VALIDATED,
        /// <summary>
        /// 
        /// </summary>
        RUNNING,
        /// <summary>
        /// 
        /// </summary>
        FAILEDVALIDATION,
        /// <summary>
        /// 
        /// </summary>
        FAILED,
        /// <summary>
        /// 
        /// </summary>
        SUCCESS,
        /// <summary>
        /// 
        /// </summary>
        CANCELLED,
        /// <summary>
        /// 
        /// </summary>
        CANCELLATIONREQUESTED,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DetailedJobOutStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DetailedJobOutStatus value)
        {
            return value switch
            {
                DetailedJobOutStatus.QUEUED => "QUEUED",
                DetailedJobOutStatus.STARTED => "STARTED",
                DetailedJobOutStatus.VALIDATING => "VALIDATING",
                DetailedJobOutStatus.VALIDATED => "VALIDATED",
                DetailedJobOutStatus.RUNNING => "RUNNING",
                DetailedJobOutStatus.FAILEDVALIDATION => "FAILED_VALIDATION",
                DetailedJobOutStatus.FAILED => "FAILED",
                DetailedJobOutStatus.SUCCESS => "SUCCESS",
                DetailedJobOutStatus.CANCELLED => "CANCELLED",
                DetailedJobOutStatus.CANCELLATIONREQUESTED => "CANCELLATION_REQUESTED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DetailedJobOutStatus? ToEnum(string value)
        {
            return value switch
            {
                "QUEUED" => DetailedJobOutStatus.QUEUED,
                "STARTED" => DetailedJobOutStatus.STARTED,
                "VALIDATING" => DetailedJobOutStatus.VALIDATING,
                "VALIDATED" => DetailedJobOutStatus.VALIDATED,
                "RUNNING" => DetailedJobOutStatus.RUNNING,
                "FAILED_VALIDATION" => DetailedJobOutStatus.FAILEDVALIDATION,
                "FAILED" => DetailedJobOutStatus.FAILED,
                "SUCCESS" => DetailedJobOutStatus.SUCCESS,
                "CANCELLED" => DetailedJobOutStatus.CANCELLED,
                "CANCELLATION_REQUESTED" => DetailedJobOutStatus.CANCELLATIONREQUESTED,
                _ => null,
            };
        }
    }
}