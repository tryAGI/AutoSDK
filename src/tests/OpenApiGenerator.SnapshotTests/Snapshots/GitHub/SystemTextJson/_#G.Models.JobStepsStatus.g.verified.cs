//HintName: G.Models.JobStepsStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The phase of the lifecycle that the job is currently in.
    /// <br/>Example: queued
    /// </summary>
    public enum JobStepsStatus
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JobStepsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JobStepsStatus value)
        {
            return value switch
            {
                JobStepsStatus.Queued => "queued",
                JobStepsStatus.InProgress => "in_progress",
                JobStepsStatus.Completed => "completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JobStepsStatus ToEnum(string value)
        {
            return value switch
            {
                "queued" => JobStepsStatus.Queued,
                "in_progress" => JobStepsStatus.InProgress,
                "completed" => JobStepsStatus.Completed,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}