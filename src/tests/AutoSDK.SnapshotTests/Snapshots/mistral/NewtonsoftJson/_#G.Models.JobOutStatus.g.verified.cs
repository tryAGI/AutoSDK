//HintName: G.Models.JobOutStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The current status of the fine-tuning job.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum JobOutStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="QUEUED")]
        QUEUED,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STARTED")]
        STARTED,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VALIDATING")]
        VALIDATING,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VALIDATED")]
        VALIDATED,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="RUNNING")]
        RUNNING,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FAILED_VALIDATION")]
        FAILEDVALIDATION,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FAILED")]
        FAILED,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SUCCESS")]
        SUCCESS,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CANCELLED")]
        CANCELLED,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CANCELLATION_REQUESTED")]
        CANCELLATIONREQUESTED,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JobOutStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JobOutStatus value)
        {
            return value switch
            {
                JobOutStatus.QUEUED => "QUEUED",
                JobOutStatus.STARTED => "STARTED",
                JobOutStatus.VALIDATING => "VALIDATING",
                JobOutStatus.VALIDATED => "VALIDATED",
                JobOutStatus.RUNNING => "RUNNING",
                JobOutStatus.FAILEDVALIDATION => "FAILED_VALIDATION",
                JobOutStatus.FAILED => "FAILED",
                JobOutStatus.SUCCESS => "SUCCESS",
                JobOutStatus.CANCELLED => "CANCELLED",
                JobOutStatus.CANCELLATIONREQUESTED => "CANCELLATION_REQUESTED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JobOutStatus? ToEnum(string value)
        {
            return value switch
            {
                "QUEUED" => JobOutStatus.QUEUED,
                "STARTED" => JobOutStatus.STARTED,
                "VALIDATING" => JobOutStatus.VALIDATING,
                "VALIDATED" => JobOutStatus.VALIDATED,
                "RUNNING" => JobOutStatus.RUNNING,
                "FAILED_VALIDATION" => JobOutStatus.FAILEDVALIDATION,
                "FAILED" => JobOutStatus.FAILED,
                "SUCCESS" => JobOutStatus.SUCCESS,
                "CANCELLED" => JobOutStatus.CANCELLED,
                "CANCELLATION_REQUESTED" => JobOutStatus.CANCELLATIONREQUESTED,
                _ => null,
            };
        }
    }
}