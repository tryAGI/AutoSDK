//HintName: G.Models.JobStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Status of the job.
    /// </summary>
    public enum JobStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        Expired,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Running,
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
                JobStatus.Cancelled => "cancelled",
                JobStatus.Completed => "completed",
                JobStatus.Created => "created",
                JobStatus.Expired => "expired",
                JobStatus.Failed => "failed",
                JobStatus.Pending => "pending",
                JobStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JobStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => JobStatus.Cancelled,
                "completed" => JobStatus.Completed,
                "created" => JobStatus.Created,
                "expired" => JobStatus.Expired,
                "failed" => JobStatus.Failed,
                "pending" => JobStatus.Pending,
                "running" => JobStatus.Running,
                _ => null,
            };
        }
    }
}