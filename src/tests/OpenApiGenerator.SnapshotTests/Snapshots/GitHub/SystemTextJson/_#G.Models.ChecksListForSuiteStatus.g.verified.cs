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
        Queued,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Completed,
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
                ChecksListForSuiteStatus.Queued => "queued",
                ChecksListForSuiteStatus.InProgress => "in_progress",
                ChecksListForSuiteStatus.Completed => "completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChecksListForSuiteStatus ToEnum(string value)
        {
            return value switch
            {
                "queued" => ChecksListForSuiteStatus.Queued,
                "in_progress" => ChecksListForSuiteStatus.InProgress,
                "completed" => ChecksListForSuiteStatus.Completed,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}