//HintName: G.Models.JobStepStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The phase of the lifecycle that the job is currently in.<br/>
    /// Example: queued
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum JobStepStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="queued")]
        Queued,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in_progress")]
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
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
                JobStepStatus.Queued => "queued",
                JobStepStatus.InProgress => "in_progress",
                JobStepStatus.Completed => "completed",
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
                "queued" => JobStepStatus.Queued,
                "in_progress" => JobStepStatus.InProgress,
                "completed" => JobStepStatus.Completed,
                _ => null,
            };
        }
    }
}