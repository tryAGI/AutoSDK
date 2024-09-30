//HintName: G.Models.JobState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum JobState
    {
        /// <summary>
        /// 
        /// </summary>
        Unknown,
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
        Aborted,
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
                JobState.Unknown => "unknown",
                JobState.Queued => "queued",
                JobState.Started => "started",
                JobState.Completed => "completed",
                JobState.Failed => "failed",
                JobState.FailedWillRetry => "failed_will_retry",
                JobState.Aborted => "aborted",
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
                "unknown" => JobState.Unknown,
                "queued" => JobState.Queued,
                "started" => JobState.Started,
                "completed" => JobState.Completed,
                "failed" => JobState.Failed,
                "failed_will_retry" => JobState.FailedWillRetry,
                "aborted" => JobState.Aborted,
                _ => null,
            };
        }
    }
}