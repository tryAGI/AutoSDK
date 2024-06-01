//HintName: G.Models.CheckRunWithSimpleCheckSuiteStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The phase of the lifecycle that the check is currently in.
    /// <br/>Example: queued
    /// </summary>
    public enum CheckRunWithSimpleCheckSuiteStatus
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
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CheckRunWithSimpleCheckSuiteStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CheckRunWithSimpleCheckSuiteStatus value)
        {
            return value switch
            {
                CheckRunWithSimpleCheckSuiteStatus.Queued => "queued",
                CheckRunWithSimpleCheckSuiteStatus.InProgress => "in_progress",
                CheckRunWithSimpleCheckSuiteStatus.Completed => "completed",
                CheckRunWithSimpleCheckSuiteStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CheckRunWithSimpleCheckSuiteStatus ToEnum(string value)
        {
            return value switch
            {
                "queued" => CheckRunWithSimpleCheckSuiteStatus.Queued,
                "in_progress" => CheckRunWithSimpleCheckSuiteStatus.InProgress,
                "completed" => CheckRunWithSimpleCheckSuiteStatus.Completed,
                "pending" => CheckRunWithSimpleCheckSuiteStatus.Pending,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}