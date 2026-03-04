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
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Started,
        /// <summary>
        /// 
        /// </summary>
        Validating,
        /// <summary>
        /// 
        /// </summary>
        Validated,
        /// <summary>
        /// 
        /// </summary>
        Running,
        /// <summary>
        /// 
        /// </summary>
        FailedValidation,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Success,
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        CancellationRequested,
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
                CompletionDetailedJobOutStatus.Queued => "QUEUED",
                CompletionDetailedJobOutStatus.Started => "STARTED",
                CompletionDetailedJobOutStatus.Validating => "VALIDATING",
                CompletionDetailedJobOutStatus.Validated => "VALIDATED",
                CompletionDetailedJobOutStatus.Running => "RUNNING",
                CompletionDetailedJobOutStatus.FailedValidation => "FAILED_VALIDATION",
                CompletionDetailedJobOutStatus.Failed => "FAILED",
                CompletionDetailedJobOutStatus.Success => "SUCCESS",
                CompletionDetailedJobOutStatus.Cancelled => "CANCELLED",
                CompletionDetailedJobOutStatus.CancellationRequested => "CANCELLATION_REQUESTED",
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
                "QUEUED" => CompletionDetailedJobOutStatus.Queued,
                "STARTED" => CompletionDetailedJobOutStatus.Started,
                "VALIDATING" => CompletionDetailedJobOutStatus.Validating,
                "VALIDATED" => CompletionDetailedJobOutStatus.Validated,
                "RUNNING" => CompletionDetailedJobOutStatus.Running,
                "FAILED_VALIDATION" => CompletionDetailedJobOutStatus.FailedValidation,
                "FAILED" => CompletionDetailedJobOutStatus.Failed,
                "SUCCESS" => CompletionDetailedJobOutStatus.Success,
                "CANCELLED" => CompletionDetailedJobOutStatus.Cancelled,
                "CANCELLATION_REQUESTED" => CompletionDetailedJobOutStatus.CancellationRequested,
                _ => null,
            };
        }
    }
}