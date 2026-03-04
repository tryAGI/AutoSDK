//HintName: G.Models.ClassifierDetailedJobOutStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ClassifierDetailedJobOutStatus
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
    public static class ClassifierDetailedJobOutStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClassifierDetailedJobOutStatus value)
        {
            return value switch
            {
                ClassifierDetailedJobOutStatus.Queued => "QUEUED",
                ClassifierDetailedJobOutStatus.Started => "STARTED",
                ClassifierDetailedJobOutStatus.Validating => "VALIDATING",
                ClassifierDetailedJobOutStatus.Validated => "VALIDATED",
                ClassifierDetailedJobOutStatus.Running => "RUNNING",
                ClassifierDetailedJobOutStatus.FailedValidation => "FAILED_VALIDATION",
                ClassifierDetailedJobOutStatus.Failed => "FAILED",
                ClassifierDetailedJobOutStatus.Success => "SUCCESS",
                ClassifierDetailedJobOutStatus.Cancelled => "CANCELLED",
                ClassifierDetailedJobOutStatus.CancellationRequested => "CANCELLATION_REQUESTED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClassifierDetailedJobOutStatus? ToEnum(string value)
        {
            return value switch
            {
                "QUEUED" => ClassifierDetailedJobOutStatus.Queued,
                "STARTED" => ClassifierDetailedJobOutStatus.Started,
                "VALIDATING" => ClassifierDetailedJobOutStatus.Validating,
                "VALIDATED" => ClassifierDetailedJobOutStatus.Validated,
                "RUNNING" => ClassifierDetailedJobOutStatus.Running,
                "FAILED_VALIDATION" => ClassifierDetailedJobOutStatus.FailedValidation,
                "FAILED" => ClassifierDetailedJobOutStatus.Failed,
                "SUCCESS" => ClassifierDetailedJobOutStatus.Success,
                "CANCELLED" => ClassifierDetailedJobOutStatus.Cancelled,
                "CANCELLATION_REQUESTED" => ClassifierDetailedJobOutStatus.CancellationRequested,
                _ => null,
            };
        }
    }
}