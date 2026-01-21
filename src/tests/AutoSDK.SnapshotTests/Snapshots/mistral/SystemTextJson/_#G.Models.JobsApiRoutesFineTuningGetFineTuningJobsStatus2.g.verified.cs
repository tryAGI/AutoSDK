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