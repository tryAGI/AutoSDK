//HintName: G.Models.CompletionDetailedJobOutStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CompletionDetailedJobOutStatus
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
    public static class CompletionDetailedJobOutStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompletionDetailedJobOutStatus value)
        {
            return value switch
            {
                CompletionDetailedJobOutStatus.QUEUED => "QUEUED",
                CompletionDetailedJobOutStatus.STARTED => "STARTED",
                CompletionDetailedJobOutStatus.VALIDATING => "VALIDATING",
                CompletionDetailedJobOutStatus.VALIDATED => "VALIDATED",
                CompletionDetailedJobOutStatus.RUNNING => "RUNNING",
                CompletionDetailedJobOutStatus.FAILEDVALIDATION => "FAILED_VALIDATION",
                CompletionDetailedJobOutStatus.FAILED => "FAILED",
                CompletionDetailedJobOutStatus.SUCCESS => "SUCCESS",
                CompletionDetailedJobOutStatus.CANCELLED => "CANCELLED",
                CompletionDetailedJobOutStatus.CANCELLATIONREQUESTED => "CANCELLATION_REQUESTED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompletionDetailedJobOutStatus? ToEnum(string value)
        {
            return value switch
            {
                "QUEUED" => CompletionDetailedJobOutStatus.QUEUED,
                "STARTED" => CompletionDetailedJobOutStatus.STARTED,
                "VALIDATING" => CompletionDetailedJobOutStatus.VALIDATING,
                "VALIDATED" => CompletionDetailedJobOutStatus.VALIDATED,
                "RUNNING" => CompletionDetailedJobOutStatus.RUNNING,
                "FAILED_VALIDATION" => CompletionDetailedJobOutStatus.FAILEDVALIDATION,
                "FAILED" => CompletionDetailedJobOutStatus.FAILED,
                "SUCCESS" => CompletionDetailedJobOutStatus.SUCCESS,
                "CANCELLED" => CompletionDetailedJobOutStatus.CANCELLED,
                "CANCELLATION_REQUESTED" => CompletionDetailedJobOutStatus.CANCELLATIONREQUESTED,
                _ => null,
            };
        }
    }
}