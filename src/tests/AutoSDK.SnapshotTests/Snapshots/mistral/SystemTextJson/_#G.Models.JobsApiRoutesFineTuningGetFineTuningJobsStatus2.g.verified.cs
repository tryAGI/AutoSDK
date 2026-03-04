//HintName: G.Models.JobsApiRoutesFineTuningGetFineTuningJobsStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum JobsApiRoutesFineTuningGetFineTuningJobsStatus2
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
    public static class JobsApiRoutesFineTuningGetFineTuningJobsStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JobsApiRoutesFineTuningGetFineTuningJobsStatus2 value)
        {
            return value switch
            {
                JobsApiRoutesFineTuningGetFineTuningJobsStatus2.Queued => "QUEUED",
                JobsApiRoutesFineTuningGetFineTuningJobsStatus2.Started => "STARTED",
                JobsApiRoutesFineTuningGetFineTuningJobsStatus2.Validating => "VALIDATING",
                JobsApiRoutesFineTuningGetFineTuningJobsStatus2.Validated => "VALIDATED",
                JobsApiRoutesFineTuningGetFineTuningJobsStatus2.Running => "RUNNING",
                JobsApiRoutesFineTuningGetFineTuningJobsStatus2.FailedValidation => "FAILED_VALIDATION",
                JobsApiRoutesFineTuningGetFineTuningJobsStatus2.Failed => "FAILED",
                JobsApiRoutesFineTuningGetFineTuningJobsStatus2.Success => "SUCCESS",
                JobsApiRoutesFineTuningGetFineTuningJobsStatus2.Cancelled => "CANCELLED",
                JobsApiRoutesFineTuningGetFineTuningJobsStatus2.CancellationRequested => "CANCELLATION_REQUESTED",
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
                "QUEUED" => JobsApiRoutesFineTuningGetFineTuningJobsStatus2.Queued,
                "STARTED" => JobsApiRoutesFineTuningGetFineTuningJobsStatus2.Started,
                "VALIDATING" => JobsApiRoutesFineTuningGetFineTuningJobsStatus2.Validating,
                "VALIDATED" => JobsApiRoutesFineTuningGetFineTuningJobsStatus2.Validated,
                "RUNNING" => JobsApiRoutesFineTuningGetFineTuningJobsStatus2.Running,
                "FAILED_VALIDATION" => JobsApiRoutesFineTuningGetFineTuningJobsStatus2.FailedValidation,
                "FAILED" => JobsApiRoutesFineTuningGetFineTuningJobsStatus2.Failed,
                "SUCCESS" => JobsApiRoutesFineTuningGetFineTuningJobsStatus2.Success,
                "CANCELLED" => JobsApiRoutesFineTuningGetFineTuningJobsStatus2.Cancelled,
                "CANCELLATION_REQUESTED" => JobsApiRoutesFineTuningGetFineTuningJobsStatus2.CancellationRequested,
                _ => null,
            };
        }
    }
}