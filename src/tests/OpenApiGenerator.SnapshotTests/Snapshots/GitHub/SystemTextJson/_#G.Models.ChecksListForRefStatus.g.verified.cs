//HintName: G.Models.ChecksListForRefStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChecksListForRefStatus
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
    public static class ChecksListForRefStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChecksListForRefStatus value)
        {
            return value switch
            {
                ChecksListForRefStatus.Queued => "queued",
                ChecksListForRefStatus.InProgress => "in_progress",
                ChecksListForRefStatus.Completed => "completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChecksListForRefStatus ToEnum(string value)
        {
            return value switch
            {
                "queued" => ChecksListForRefStatus.Queued,
                "in_progress" => ChecksListForRefStatus.InProgress,
                "completed" => ChecksListForRefStatus.Completed,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}