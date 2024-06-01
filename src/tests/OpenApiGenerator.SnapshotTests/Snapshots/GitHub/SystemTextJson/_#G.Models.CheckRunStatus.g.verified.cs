//HintName: G.Models.CheckRunStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The phase of the lifecycle that the check is currently in. Statuses of waiting, requested, and pending are reserved for GitHub Actions check runs.
    /// <br/>Example: queued
    /// </summary>
    public enum CheckRunStatus
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
    public static class CheckRunStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CheckRunStatus value)
        {
            return value switch
            {
                CheckRunStatus.Queued => "queued",
                CheckRunStatus.InProgress => "in_progress",
                CheckRunStatus.Completed => "completed",
                CheckRunStatus.Waiting => "waiting",
                CheckRunStatus.Requested => "requested",
                CheckRunStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CheckRunStatus ToEnum(string value)
        {
            return value switch
            {
                "queued" => CheckRunStatus.Queued,
                "in_progress" => CheckRunStatus.InProgress,
                "completed" => CheckRunStatus.Completed,
                "waiting" => CheckRunStatus.Waiting,
                "requested" => CheckRunStatus.Requested,
                "pending" => CheckRunStatus.Pending,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}