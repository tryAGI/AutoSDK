//HintName: G.Models.CompletionJobOutStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The current status of the fine-tuning job.
    /// </summary>
    public enum CompletionJobOutStatus
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
    public static class CompletionJobOutStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompletionJobOutStatus value)
        {
            return value switch
            {
                CompletionJobOutStatus.QUEUED => "QUEUED",
                CompletionJobOutStatus.STARTED => "STARTED",
                CompletionJobOutStatus.VALIDATING => "VALIDATING",
                CompletionJobOutStatus.VALIDATED => "VALIDATED",
                CompletionJobOutStatus.RUNNING => "RUNNING",
                CompletionJobOutStatus.FAILEDVALIDATION => "FAILED_VALIDATION",
                CompletionJobOutStatus.FAILED => "FAILED",
                CompletionJobOutStatus.SUCCESS => "SUCCESS",
                CompletionJobOutStatus.CANCELLED => "CANCELLED",
                CompletionJobOutStatus.CANCELLATIONREQUESTED => "CANCELLATION_REQUESTED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompletionJobOutStatus? ToEnum(string value)
        {
            return value switch
            {
                "QUEUED" => CompletionJobOutStatus.QUEUED,
                "STARTED" => CompletionJobOutStatus.STARTED,
                "VALIDATING" => CompletionJobOutStatus.VALIDATING,
                "VALIDATED" => CompletionJobOutStatus.VALIDATED,
                "RUNNING" => CompletionJobOutStatus.RUNNING,
                "FAILED_VALIDATION" => CompletionJobOutStatus.FAILEDVALIDATION,
                "FAILED" => CompletionJobOutStatus.FAILED,
                "SUCCESS" => CompletionJobOutStatus.SUCCESS,
                "CANCELLED" => CompletionJobOutStatus.CANCELLED,
                "CANCELLATION_REQUESTED" => CompletionJobOutStatus.CANCELLATIONREQUESTED,
                _ => null,
            };
        }
    }
}