//HintName: G.Models.ClassifierJobOutStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The current status of the fine-tuning job.
    /// </summary>
    public enum ClassifierJobOutStatus
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
    public static class ClassifierJobOutStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClassifierJobOutStatus value)
        {
            return value switch
            {
                ClassifierJobOutStatus.CancellationRequested => "CANCELLATION_REQUESTED",
                ClassifierJobOutStatus.Cancelled => "CANCELLED",
                ClassifierJobOutStatus.Failed => "FAILED",
                ClassifierJobOutStatus.FailedValidation => "FAILED_VALIDATION",
                ClassifierJobOutStatus.Queued => "QUEUED",
                ClassifierJobOutStatus.Running => "RUNNING",
                ClassifierJobOutStatus.Started => "STARTED",
                ClassifierJobOutStatus.Success => "SUCCESS",
                ClassifierJobOutStatus.Validated => "VALIDATED",
                ClassifierJobOutStatus.Validating => "VALIDATING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClassifierJobOutStatus? ToEnum(string value)
        {
            return value switch
            {
                "CANCELLATION_REQUESTED" => ClassifierJobOutStatus.CancellationRequested,
                "CANCELLED" => ClassifierJobOutStatus.Cancelled,
                "FAILED" => ClassifierJobOutStatus.Failed,
                "FAILED_VALIDATION" => ClassifierJobOutStatus.FailedValidation,
                "QUEUED" => ClassifierJobOutStatus.Queued,
                "RUNNING" => ClassifierJobOutStatus.Running,
                "STARTED" => ClassifierJobOutStatus.Started,
                "SUCCESS" => ClassifierJobOutStatus.Success,
                "VALIDATED" => ClassifierJobOutStatus.Validated,
                "VALIDATING" => ClassifierJobOutStatus.Validating,
                _ => null,
            };
        }
    }
}