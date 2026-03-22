//HintName: G.Models.ChecksListForSuiteStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChecksListForSuiteStatus
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
    public static class ChecksListForSuiteStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChecksListForSuiteStatus value)
        {
            return value switch
            {
                ChecksListForSuiteStatus.Completed => "completed",
                ChecksListForSuiteStatus.InProgress => "in_progress",
                ChecksListForSuiteStatus.Queued => "queued",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChecksListForSuiteStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ChecksListForSuiteStatus.Completed,
                "in_progress" => ChecksListForSuiteStatus.InProgress,
                "queued" => ChecksListForSuiteStatus.Queued,
                _ => null,
            };
        }
    }
}