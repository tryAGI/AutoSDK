//HintName: G.Models.ApiJobStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the job.
    /// </summary>
    public enum ApiJobStatus
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiJobStatus value)
        {
            return value switch
            {
                ApiJobStatus.Completed => "completed",
                ApiJobStatus.Failed => "failed",
                ApiJobStatus.InProgress => "in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ApiJobStatus.Completed,
                "failed" => ApiJobStatus.Failed,
                "in_progress" => ApiJobStatus.InProgress,
                _ => null,
            };
        }
    }
}