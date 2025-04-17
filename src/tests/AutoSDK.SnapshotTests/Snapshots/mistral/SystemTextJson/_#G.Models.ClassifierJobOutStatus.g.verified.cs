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
    public static class ClassifierJobOutStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClassifierJobOutStatus value)
        {
            return value switch
            {
                ClassifierJobOutStatus.QUEUED => "QUEUED",
                ClassifierJobOutStatus.STARTED => "STARTED",
                ClassifierJobOutStatus.VALIDATING => "VALIDATING",
                ClassifierJobOutStatus.VALIDATED => "VALIDATED",
                ClassifierJobOutStatus.RUNNING => "RUNNING",
                ClassifierJobOutStatus.FAILEDVALIDATION => "FAILED_VALIDATION",
                ClassifierJobOutStatus.FAILED => "FAILED",
                ClassifierJobOutStatus.SUCCESS => "SUCCESS",
                ClassifierJobOutStatus.CANCELLED => "CANCELLED",
                ClassifierJobOutStatus.CANCELLATIONREQUESTED => "CANCELLATION_REQUESTED",
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
                "QUEUED" => ClassifierJobOutStatus.QUEUED,
                "STARTED" => ClassifierJobOutStatus.STARTED,
                "VALIDATING" => ClassifierJobOutStatus.VALIDATING,
                "VALIDATED" => ClassifierJobOutStatus.VALIDATED,
                "RUNNING" => ClassifierJobOutStatus.RUNNING,
                "FAILED_VALIDATION" => ClassifierJobOutStatus.FAILEDVALIDATION,
                "FAILED" => ClassifierJobOutStatus.FAILED,
                "SUCCESS" => ClassifierJobOutStatus.SUCCESS,
                "CANCELLED" => ClassifierJobOutStatus.CANCELLED,
                "CANCELLATION_REQUESTED" => ClassifierJobOutStatus.CANCELLATIONREQUESTED,
                _ => null,
            };
        }
    }
}