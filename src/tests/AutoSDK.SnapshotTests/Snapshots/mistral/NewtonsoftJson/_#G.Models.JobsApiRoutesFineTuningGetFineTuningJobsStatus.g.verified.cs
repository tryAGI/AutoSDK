//HintName: G.Models.JobsApiRoutesFineTuningGetFineTuningJobsStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum JobsApiRoutesFineTuningGetFineTuningJobsStatus
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
    public static class JobsApiRoutesFineTuningGetFineTuningJobsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JobsApiRoutesFineTuningGetFineTuningJobsStatus value)
        {
            return value switch
            {
                JobsApiRoutesFineTuningGetFineTuningJobsStatus.QUEUED => "QUEUED",
                JobsApiRoutesFineTuningGetFineTuningJobsStatus.STARTED => "STARTED",
                JobsApiRoutesFineTuningGetFineTuningJobsStatus.VALIDATING => "VALIDATING",
                JobsApiRoutesFineTuningGetFineTuningJobsStatus.VALIDATED => "VALIDATED",
                JobsApiRoutesFineTuningGetFineTuningJobsStatus.RUNNING => "RUNNING",
                JobsApiRoutesFineTuningGetFineTuningJobsStatus.FAILEDVALIDATION => "FAILED_VALIDATION",
                JobsApiRoutesFineTuningGetFineTuningJobsStatus.FAILED => "FAILED",
                JobsApiRoutesFineTuningGetFineTuningJobsStatus.SUCCESS => "SUCCESS",
                JobsApiRoutesFineTuningGetFineTuningJobsStatus.CANCELLED => "CANCELLED",
                JobsApiRoutesFineTuningGetFineTuningJobsStatus.CANCELLATIONREQUESTED => "CANCELLATION_REQUESTED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JobsApiRoutesFineTuningGetFineTuningJobsStatus? ToEnum(string value)
        {
            return value switch
            {
                "QUEUED" => JobsApiRoutesFineTuningGetFineTuningJobsStatus.QUEUED,
                "STARTED" => JobsApiRoutesFineTuningGetFineTuningJobsStatus.STARTED,
                "VALIDATING" => JobsApiRoutesFineTuningGetFineTuningJobsStatus.VALIDATING,
                "VALIDATED" => JobsApiRoutesFineTuningGetFineTuningJobsStatus.VALIDATED,
                "RUNNING" => JobsApiRoutesFineTuningGetFineTuningJobsStatus.RUNNING,
                "FAILED_VALIDATION" => JobsApiRoutesFineTuningGetFineTuningJobsStatus.FAILEDVALIDATION,
                "FAILED" => JobsApiRoutesFineTuningGetFineTuningJobsStatus.FAILED,
                "SUCCESS" => JobsApiRoutesFineTuningGetFineTuningJobsStatus.SUCCESS,
                "CANCELLED" => JobsApiRoutesFineTuningGetFineTuningJobsStatus.CANCELLED,
                "CANCELLATION_REQUESTED" => JobsApiRoutesFineTuningGetFineTuningJobsStatus.CANCELLATIONREQUESTED,
                _ => null,
            };
        }
    }
}