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
                SimpleCheckSuiteStatus.Queued => "queued",
                SimpleCheckSuiteStatus.InProgress => "in_progress",
                SimpleCheckSuiteStatus.Completed => "completed",
                SimpleCheckSuiteStatus.Pending => "pending",
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
                "queued" => SimpleCheckSuiteStatus.Queued,
                "in_progress" => SimpleCheckSuiteStatus.InProgress,
                "completed" => SimpleCheckSuiteStatus.Completed,
                "pending" => SimpleCheckSuiteStatus.Pending,
                "waiting" => SimpleCheckSuiteStatus.Waiting,
                _ => null,
            };
        }
    }
}