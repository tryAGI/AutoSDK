//HintName: G.Models.JobStepStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The phase of the lifecycle that the job is currently in.<br/>
    /// Example: queued
    /// </summary>
    public enum JobStepStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Queued,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JobStepStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JobStepStatus value)
        {
            return value switch
            {
                JobStepStatus.Completed => "completed",
                JobStepStatus.InProgress => "in_progress",
                JobStepStatus.Queued => "queued",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JobStepStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => JobStepStatus.Completed,
                "in_progress" => JobStepStatus.InProgress,
                "queued" => JobStepStatus.Queued,
                _ => null,
            };
        }
    }
}