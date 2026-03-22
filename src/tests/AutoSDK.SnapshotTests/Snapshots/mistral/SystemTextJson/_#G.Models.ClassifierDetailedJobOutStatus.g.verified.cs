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
    public static class ClassifierDetailedJobOutStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClassifierDetailedJobOutStatus value)
        {
            return value switch
            {
                ClassifierDetailedJobOutStatus.CancellationRequested => "CANCELLATION_REQUESTED",
                ClassifierDetailedJobOutStatus.Cancelled => "CANCELLED",
                ClassifierDetailedJobOutStatus.Failed => "FAILED",
                ClassifierDetailedJobOutStatus.FailedValidation => "FAILED_VALIDATION",
                ClassifierDetailedJobOutStatus.Queued => "QUEUED",
                ClassifierDetailedJobOutStatus.Running => "RUNNING",
                ClassifierDetailedJobOutStatus.Started => "STARTED",
                ClassifierDetailedJobOutStatus.Success => "SUCCESS",
                ClassifierDetailedJobOutStatus.Validated => "VALIDATED",
                ClassifierDetailedJobOutStatus.Validating => "VALIDATING",
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
                "CANCELLATION_REQUESTED" => ClassifierDetailedJobOutStatus.CancellationRequested,
                "CANCELLED" => ClassifierDetailedJobOutStatus.Cancelled,
                "FAILED" => ClassifierDetailedJobOutStatus.Failed,
                "FAILED_VALIDATION" => ClassifierDetailedJobOutStatus.FailedValidation,
                "QUEUED" => ClassifierDetailedJobOutStatus.Queued,
                "RUNNING" => ClassifierDetailedJobOutStatus.Running,
                "STARTED" => ClassifierDetailedJobOutStatus.Started,
                "SUCCESS" => ClassifierDetailedJobOutStatus.Success,
                "VALIDATED" => ClassifierDetailedJobOutStatus.Validated,
                "VALIDATING" => ClassifierDetailedJobOutStatus.Validating,
                _ => null,
            };
        }
    }
}