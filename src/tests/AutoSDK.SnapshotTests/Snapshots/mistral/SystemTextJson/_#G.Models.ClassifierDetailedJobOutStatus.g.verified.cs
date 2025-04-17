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
    public static class ClassifierDetailedJobOutStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClassifierDetailedJobOutStatus value)
        {
            return value switch
            {
                ClassifierDetailedJobOutStatus.QUEUED => "QUEUED",
                ClassifierDetailedJobOutStatus.STARTED => "STARTED",
                ClassifierDetailedJobOutStatus.VALIDATING => "VALIDATING",
                ClassifierDetailedJobOutStatus.VALIDATED => "VALIDATED",
                ClassifierDetailedJobOutStatus.RUNNING => "RUNNING",
                ClassifierDetailedJobOutStatus.FAILEDVALIDATION => "FAILED_VALIDATION",
                ClassifierDetailedJobOutStatus.FAILED => "FAILED",
                ClassifierDetailedJobOutStatus.SUCCESS => "SUCCESS",
                ClassifierDetailedJobOutStatus.CANCELLED => "CANCELLED",
                ClassifierDetailedJobOutStatus.CANCELLATIONREQUESTED => "CANCELLATION_REQUESTED",
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
                "QUEUED" => ClassifierDetailedJobOutStatus.QUEUED,
                "STARTED" => ClassifierDetailedJobOutStatus.STARTED,
                "VALIDATING" => ClassifierDetailedJobOutStatus.VALIDATING,
                "VALIDATED" => ClassifierDetailedJobOutStatus.VALIDATED,
                "RUNNING" => ClassifierDetailedJobOutStatus.RUNNING,
                "FAILED_VALIDATION" => ClassifierDetailedJobOutStatus.FAILEDVALIDATION,
                "FAILED" => ClassifierDetailedJobOutStatus.FAILED,
                "SUCCESS" => ClassifierDetailedJobOutStatus.SUCCESS,
                "CANCELLED" => ClassifierDetailedJobOutStatus.CANCELLED,
                "CANCELLATION_REQUESTED" => ClassifierDetailedJobOutStatus.CANCELLATIONREQUESTED,
                _ => null,
            };
        }
    }
}