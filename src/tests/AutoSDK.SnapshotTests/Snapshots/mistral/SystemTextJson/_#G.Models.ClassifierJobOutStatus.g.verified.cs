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
    public static class ClassifierJobOutStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClassifierJobOutStatus value)
        {
            return value switch
            {
                ClassifierJobOutStatus.Queued => "QUEUED",
                ClassifierJobOutStatus.Started => "STARTED",
                ClassifierJobOutStatus.Validating => "VALIDATING",
                ClassifierJobOutStatus.Validated => "VALIDATED",
                ClassifierJobOutStatus.Running => "RUNNING",
                ClassifierJobOutStatus.FailedValidation => "FAILED_VALIDATION",
                ClassifierJobOutStatus.Failed => "FAILED",
                ClassifierJobOutStatus.Success => "SUCCESS",
                ClassifierJobOutStatus.Cancelled => "CANCELLED",
                ClassifierJobOutStatus.CancellationRequested => "CANCELLATION_REQUESTED",
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
                "QUEUED" => ClassifierJobOutStatus.Queued,
                "STARTED" => ClassifierJobOutStatus.Started,
                "VALIDATING" => ClassifierJobOutStatus.Validating,
                "VALIDATED" => ClassifierJobOutStatus.Validated,
                "RUNNING" => ClassifierJobOutStatus.Running,
                "FAILED_VALIDATION" => ClassifierJobOutStatus.FailedValidation,
                "FAILED" => ClassifierJobOutStatus.Failed,
                "SUCCESS" => ClassifierJobOutStatus.Success,
                "CANCELLED" => ClassifierJobOutStatus.Cancelled,
                "CANCELLATION_REQUESTED" => ClassifierJobOutStatus.CancellationRequested,
                _ => null,
            };
        }
    }
}