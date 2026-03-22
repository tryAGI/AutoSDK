//HintName: G.Models.SimpleCheckSuiteStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: completed
    /// </summary>
    public enum SimpleCheckSuiteStatus
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
        /// <summary>
        /// 
        /// </summary>
        Waiting,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SimpleCheckSuiteStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SimpleCheckSuiteStatus value)
        {
            return value switch
            {
                SimpleCheckSuiteStatus.Completed => "completed",
                SimpleCheckSuiteStatus.InProgress => "in_progress",
                SimpleCheckSuiteStatus.Pending => "pending",
                SimpleCheckSuiteStatus.Queued => "queued",
                SimpleCheckSuiteStatus.Waiting => "waiting",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SimpleCheckSuiteStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => SimpleCheckSuiteStatus.Completed,
                "in_progress" => SimpleCheckSuiteStatus.InProgress,
                "pending" => SimpleCheckSuiteStatus.Pending,
                "queued" => SimpleCheckSuiteStatus.Queued,
                "waiting" => SimpleCheckSuiteStatus.Waiting,
                _ => null,
            };
        }
    }
}