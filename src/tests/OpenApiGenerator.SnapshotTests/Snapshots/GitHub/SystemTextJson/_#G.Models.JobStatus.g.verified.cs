//HintName: G.Models.JobStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The phase of the lifecycle that the job is currently in.
    /// <br/>Example: queued
    /// </summary>
    public enum JobStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Waiting,
        /// <summary>
        /// 
        /// </summary>
        Requested,
        /// <summary>
        /// 
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JobStatus value)
        {
            return value switch
            {
                JobStatus.Queued => "queued",
                JobStatus.InProgress => "in_progress",
                JobStatus.Completed => "completed",
                JobStatus.Waiting => "waiting",
                JobStatus.Requested => "requested",
                JobStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JobStatus ToEnum(string value)
        {
            return value switch
            {
                "queued" => JobStatus.Queued,
                "in_progress" => JobStatus.InProgress,
                "completed" => JobStatus.Completed,
                "waiting" => JobStatus.Waiting,
                "requested" => JobStatus.Requested,
                "pending" => JobStatus.Pending,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}