//HintName: G.Models.JobState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum representing the possible states of a background job.
    /// </summary>
    public enum JobState
    {
        /// <summary>
        /// 
        /// </summary>
        Aborted,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        FailedWillRetry,
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
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JobStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JobState value)
        {
            return value switch
            {
                JobState.Aborted => "aborted",
                JobState.Completed => "completed",
                JobState.Failed => "failed",
                JobState.FailedWillRetry => "failed_will_retry",
                JobState.Queued => "queued",
                JobState.Started => "started",
                JobState.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JobState? ToEnum(string value)
        {
            return value switch
            {
                "aborted" => JobState.Aborted,
                "completed" => JobState.Completed,
                "failed" => JobState.Failed,
                "failed_will_retry" => JobState.FailedWillRetry,
                "queued" => JobState.Queued,
                "started" => JobState.Started,
                "unknown" => JobState.Unknown,
                _ => null,
            };
        }
    }
}