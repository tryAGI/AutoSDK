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
    public static class JobsApiRoutesFineTuningGetFineTuningJobsStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JobsApiRoutesFineTuningGetFineTuningJobsStatus2 value)
        {
            return value switch
            {
                JobsApiRoutesFineTuningGetFineTuningJobsStatus2.CancellationRequested => "CANCELLATION_REQUESTED",
                JobsApiRoutesFineTuningGetFineTuningJobsStatus2.Cancelled => "CANCELLED",
                JobsApiRoutesFineTuningGetFineTuningJobsStatus2.Failed => "FAILED",
                JobsApiRoutesFineTuningGetFineTuningJobsStatus2.FailedValidation => "FAILED_VALIDATION",
                JobsApiRoutesFineTuningGetFineTuningJobsStatus2.Queued => "QUEUED",
                JobsApiRoutesFineTuningGetFineTuningJobsStatus2.Running => "RUNNING",
                JobsApiRoutesFineTuningGetFineTuningJobsStatus2.Started => "STARTED",
                JobsApiRoutesFineTuningGetFineTuningJobsStatus2.Success => "SUCCESS",
                JobsApiRoutesFineTuningGetFineTuningJobsStatus2.Validated => "VALIDATED",
                JobsApiRoutesFineTuningGetFineTuningJobsStatus2.Validating => "VALIDATING",
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
                "CANCELLATION_REQUESTED" => JobsApiRoutesFineTuningGetFineTuningJobsStatus2.CancellationRequested,
                "CANCELLED" => JobsApiRoutesFineTuningGetFineTuningJobsStatus2.Cancelled,
                "FAILED" => JobsApiRoutesFineTuningGetFineTuningJobsStatus2.Failed,
                "FAILED_VALIDATION" => JobsApiRoutesFineTuningGetFineTuningJobsStatus2.FailedValidation,
                "QUEUED" => JobsApiRoutesFineTuningGetFineTuningJobsStatus2.Queued,
                "RUNNING" => JobsApiRoutesFineTuningGetFineTuningJobsStatus2.Running,
                "STARTED" => JobsApiRoutesFineTuningGetFineTuningJobsStatus2.Started,
                "SUCCESS" => JobsApiRoutesFineTuningGetFineTuningJobsStatus2.Success,
                "VALIDATED" => JobsApiRoutesFineTuningGetFineTuningJobsStatus2.Validated,
                "VALIDATING" => JobsApiRoutesFineTuningGetFineTuningJobsStatus2.Validating,
                _ => null,
            };
        }
    }
}