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
        CancellationRequested,
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        FailedValidation,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Running,
        /// <summary>
        /// 
        /// </summary>
        Started,
        /// <summary>
        /// 
        /// </summary>
        Success,
        /// <summary>
        /// 
        /// </summary>
        Validated,
        /// <summary>
        /// 
        /// </summary>
        Validating,
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
                CompletionJobOutStatus.CancellationRequested => "CANCELLATION_REQUESTED",
                CompletionJobOutStatus.Cancelled => "CANCELLED",
                CompletionJobOutStatus.Failed => "FAILED",
                CompletionJobOutStatus.FailedValidation => "FAILED_VALIDATION",
                CompletionJobOutStatus.Queued => "QUEUED",
                CompletionJobOutStatus.Running => "RUNNING",
                CompletionJobOutStatus.Started => "STARTED",
                CompletionJobOutStatus.Success => "SUCCESS",
                CompletionJobOutStatus.Validated => "VALIDATED",
                CompletionJobOutStatus.Validating => "VALIDATING",
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
                "CANCELLATION_REQUESTED" => CompletionJobOutStatus.CancellationRequested,
                "CANCELLED" => CompletionJobOutStatus.Cancelled,
                "FAILED" => CompletionJobOutStatus.Failed,
                "FAILED_VALIDATION" => CompletionJobOutStatus.FailedValidation,
                "QUEUED" => CompletionJobOutStatus.Queued,
                "RUNNING" => CompletionJobOutStatus.Running,
                "STARTED" => CompletionJobOutStatus.Started,
                "SUCCESS" => CompletionJobOutStatus.Success,
                "VALIDATED" => CompletionJobOutStatus.Validated,
                "VALIDATING" => CompletionJobOutStatus.Validating,
                _ => null,
            };
        }
    }
}