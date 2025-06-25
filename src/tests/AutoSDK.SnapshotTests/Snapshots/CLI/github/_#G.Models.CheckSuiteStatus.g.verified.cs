//HintName: G.Models.CheckSuiteStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The phase of the lifecycle that the check suite is currently in. Statuses of waiting, requested, and pending are reserved for GitHub Actions check suites.<br/>
    /// Example: completed
    /// </summary>
    public enum CheckSuiteStatus
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
    public static class CheckSuiteStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CheckSuiteStatus value)
        {
            return value switch
            {
                CheckSuiteStatus.Queued => "queued",
                CheckSuiteStatus.InProgress => "in_progress",
                CheckSuiteStatus.Completed => "completed",
                CheckSuiteStatus.Waiting => "waiting",
                CheckSuiteStatus.Requested => "requested",
                CheckSuiteStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CheckSuiteStatus? ToEnum(string value)
        {
            return value switch
            {
                "queued" => CheckSuiteStatus.Queued,
                "in_progress" => CheckSuiteStatus.InProgress,
                "completed" => CheckSuiteStatus.Completed,
                "waiting" => CheckSuiteStatus.Waiting,
                "requested" => CheckSuiteStatus.Requested,
                "pending" => CheckSuiteStatus.Pending,
                _ => null,
            };
        }
    }
}