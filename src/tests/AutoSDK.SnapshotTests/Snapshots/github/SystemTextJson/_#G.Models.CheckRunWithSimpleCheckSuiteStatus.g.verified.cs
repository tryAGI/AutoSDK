//HintName: G.Models.CheckRunWithSimpleCheckSuiteStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The phase of the lifecycle that the check is currently in.<br/>
    /// Example: queued
    /// </summary>
    public enum CheckRunWithSimpleCheckSuiteStatus
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
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Queued,
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
                CheckRunWithSimpleCheckSuiteStatus.Completed => "completed",
                CheckRunWithSimpleCheckSuiteStatus.InProgress => "in_progress",
                CheckRunWithSimpleCheckSuiteStatus.Pending => "pending",
                CheckRunWithSimpleCheckSuiteStatus.Queued => "queued",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CheckRunWithSimpleCheckSuiteStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => CheckRunWithSimpleCheckSuiteStatus.Completed,
                "in_progress" => CheckRunWithSimpleCheckSuiteStatus.InProgress,
                "pending" => CheckRunWithSimpleCheckSuiteStatus.Pending,
                "queued" => CheckRunWithSimpleCheckSuiteStatus.Queued,
                _ => null,
            };
        }
    }
}