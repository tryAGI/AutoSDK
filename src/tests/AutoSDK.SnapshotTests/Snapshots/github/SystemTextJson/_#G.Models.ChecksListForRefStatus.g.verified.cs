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
    public static class ChecksListForRefStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChecksListForRefStatus value)
        {
            return value switch
            {
                ChecksListForRefStatus.Completed => "completed",
                ChecksListForRefStatus.InProgress => "in_progress",
                ChecksListForRefStatus.Queued => "queued",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChecksListForRefStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ChecksListForRefStatus.Completed,
                "in_progress" => ChecksListForRefStatus.InProgress,
                "queued" => ChecksListForRefStatus.Queued,
                _ => null,
            };
        }
    }
}