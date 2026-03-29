//HintName: G.Models.WebSearchStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebSearchStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Searching,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebSearchStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchStatus value)
        {
            return value switch
            {
                WebSearchStatus.Completed => "completed",
                WebSearchStatus.Failed => "failed",
                WebSearchStatus.InProgress => "in_progress",
                WebSearchStatus.Searching => "searching",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => WebSearchStatus.Completed,
                "failed" => WebSearchStatus.Failed,
                "in_progress" => WebSearchStatus.InProgress,
                "searching" => WebSearchStatus.Searching,
                _ => null,
            };
        }
    }
}