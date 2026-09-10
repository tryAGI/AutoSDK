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
        [global::System.Runtime.Serialization.EnumMember(Value="CANCELLATION_REQUESTED")]
        CancellationRequested,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CANCELLED")]
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FAILED")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FAILED_VALIDATION")]
        FailedValidation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="QUEUED")]
        Queued,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="RUNNING")]
        Running,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STARTED")]
        Started,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SUCCESS")]
        Success,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VALIDATED")]
        Validated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VALIDATING")]
        Validating,
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
                JobsApiRoutesFineTuningGetFineTuningJobsStatus.CancellationRequested => "CANCELLATION_REQUESTED",
                JobsApiRoutesFineTuningGetFineTuningJobsStatus.Cancelled => "CANCELLED",
                JobsApiRoutesFineTuningGetFineTuningJobsStatus.Failed => "FAILED",
                JobsApiRoutesFineTuningGetFineTuningJobsStatus.FailedValidation => "FAILED_VALIDATION",
                JobsApiRoutesFineTuningGetFineTuningJobsStatus.Queued => "QUEUED",
                JobsApiRoutesFineTuningGetFineTuningJobsStatus.Running => "RUNNING",
                JobsApiRoutesFineTuningGetFineTuningJobsStatus.Started => "STARTED",
                JobsApiRoutesFineTuningGetFineTuningJobsStatus.Success => "SUCCESS",
                JobsApiRoutesFineTuningGetFineTuningJobsStatus.Validated => "VALIDATED",
                JobsApiRoutesFineTuningGetFineTuningJobsStatus.Validating => "VALIDATING",
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
                "CANCELLATION_REQUESTED" => JobsApiRoutesFineTuningGetFineTuningJobsStatus.CancellationRequested,
                "CANCELLED" => JobsApiRoutesFineTuningGetFineTuningJobsStatus.Cancelled,
                "FAILED" => JobsApiRoutesFineTuningGetFineTuningJobsStatus.Failed,
                "FAILED_VALIDATION" => JobsApiRoutesFineTuningGetFineTuningJobsStatus.FailedValidation,
                "QUEUED" => JobsApiRoutesFineTuningGetFineTuningJobsStatus.Queued,
                "RUNNING" => JobsApiRoutesFineTuningGetFineTuningJobsStatus.Running,
                "STARTED" => JobsApiRoutesFineTuningGetFineTuningJobsStatus.Started,
                "SUCCESS" => JobsApiRoutesFineTuningGetFineTuningJobsStatus.Success,
                "VALIDATED" => JobsApiRoutesFineTuningGetFineTuningJobsStatus.Validated,
                "VALIDATING" => JobsApiRoutesFineTuningGetFineTuningJobsStatus.Validating,
                _ => null,
            };
        }
    }
}