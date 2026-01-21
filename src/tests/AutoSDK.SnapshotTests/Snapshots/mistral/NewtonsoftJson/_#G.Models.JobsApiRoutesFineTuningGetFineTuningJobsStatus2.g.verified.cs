//HintName: G.Models.JobsApiRoutesFineTuningGetFineTuningJobsStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum JobsApiRoutesFineTuningGetFineTuningJobsStatus2
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
    public static class JobsApiRoutesFineTuningGetFineTuningJobsStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JobsApiRoutesFineTuningGetFineTuningJobsStatus2 value)
        {
            return value switch
            {
                JobsApiRoutesFineTuningGetFineTuningJobsStatus2.QUEUED => "QUEUED",
                JobsApiRoutesFineTuningGetFineTuningJobsStatus2.STARTED => "STARTED",
                JobsApiRoutesFineTuningGetFineTuningJobsStatus2.VALIDATING => "VALIDATING",
                JobsApiRoutesFineTuningGetFineTuningJobsStatus2.VALIDATED => "VALIDATED",
                JobsApiRoutesFineTuningGetFineTuningJobsStatus2.RUNNING => "RUNNING",
                JobsApiRoutesFineTuningGetFineTuningJobsStatus2.FAILEDVALIDATION => "FAILED_VALIDATION",
                JobsApiRoutesFineTuningGetFineTuningJobsStatus2.FAILED => "FAILED",
                JobsApiRoutesFineTuningGetFineTuningJobsStatus2.SUCCESS => "SUCCESS",
                JobsApiRoutesFineTuningGetFineTuningJobsStatus2.CANCELLED => "CANCELLED",
                JobsApiRoutesFineTuningGetFineTuningJobsStatus2.CANCELLATIONREQUESTED => "CANCELLATION_REQUESTED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JobsApiRoutesFineTuningGetFineTuningJobsStatus2? ToEnum(string value)
        {
            return value switch
            {
                "QUEUED" => JobsApiRoutesFineTuningGetFineTuningJobsStatus2.QUEUED,
                "STARTED" => JobsApiRoutesFineTuningGetFineTuningJobsStatus2.STARTED,
                "VALIDATING" => JobsApiRoutesFineTuningGetFineTuningJobsStatus2.VALIDATING,
                "VALIDATED" => JobsApiRoutesFineTuningGetFineTuningJobsStatus2.VALIDATED,
                "RUNNING" => JobsApiRoutesFineTuningGetFineTuningJobsStatus2.RUNNING,
                "FAILED_VALIDATION" => JobsApiRoutesFineTuningGetFineTuningJobsStatus2.FAILEDVALIDATION,
                "FAILED" => JobsApiRoutesFineTuningGetFineTuningJobsStatus2.FAILED,
                "SUCCESS" => JobsApiRoutesFineTuningGetFineTuningJobsStatus2.SUCCESS,
                "CANCELLED" => JobsApiRoutesFineTuningGetFineTuningJobsStatus2.CANCELLED,
                "CANCELLATION_REQUESTED" => JobsApiRoutesFineTuningGetFineTuningJobsStatus2.CANCELLATIONREQUESTED,
                _ => null,
            };
        }
    }
}