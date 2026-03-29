//HintName: G.Models.JobDetailsStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the job. * `running` - The job is actively running. * `done` - The job completed successfully. * `rejected` - The job was accepted at first, but later could not be processed by the transcriber. * `deleted` - The user deleted the job. * `expired` - The system deleted the job. Usually because the job was in the `done` state for a very long time.
    /// </summary>
    public enum JobDetailsStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Deleted,
        /// <summary>
        /// 
        /// </summary>
        Done,
        /// <summary>
        /// 
        /// </summary>
        Expired,
        /// <summary>
        /// 
        /// </summary>
        Rejected,
        /// <summary>
        /// 
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JobDetailsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JobDetailsStatus value)
        {
            return value switch
            {
                JobDetailsStatus.Deleted => "deleted",
                JobDetailsStatus.Done => "done",
                JobDetailsStatus.Expired => "expired",
                JobDetailsStatus.Rejected => "rejected",
                JobDetailsStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JobDetailsStatus? ToEnum(string value)
        {
            return value switch
            {
                "deleted" => JobDetailsStatus.Deleted,
                "done" => JobDetailsStatus.Done,
                "expired" => JobDetailsStatus.Expired,
                "rejected" => JobDetailsStatus.Rejected,
                "running" => JobDetailsStatus.Running,
                _ => null,
            };
        }
    }
}