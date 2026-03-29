//HintName: G.Models.JobStateStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum JobStateStatus
    {
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
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Queued,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JobStateStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JobStateStatus value)
        {
            return value switch
            {
                JobStateStatus.Completed => "COMPLETED",
                JobStateStatus.Failed => "FAILED",
                JobStateStatus.InProgress => "IN_PROGRESS",
                JobStateStatus.Queued => "QUEUED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JobStateStatus? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETED" => JobStateStatus.Completed,
                "FAILED" => JobStateStatus.Failed,
                "IN_PROGRESS" => JobStateStatus.InProgress,
                "QUEUED" => JobStateStatus.Queued,
                _ => null,
            };
        }
    }
}