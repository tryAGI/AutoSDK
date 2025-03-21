//HintName: G.Models.WebSearchToolCallStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the web search tool call.
    /// </summary>
    public enum WebSearchToolCallStatus
    {
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Searching,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebSearchToolCallStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchToolCallStatus value)
        {
            return value switch
            {
                WebSearchToolCallStatus.InProgress => "in_progress",
                WebSearchToolCallStatus.Searching => "searching",
                WebSearchToolCallStatus.Completed => "completed",
                WebSearchToolCallStatus.Failed => "failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchToolCallStatus? ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => WebSearchToolCallStatus.InProgress,
                "searching" => WebSearchToolCallStatus.Searching,
                "completed" => WebSearchToolCallStatus.Completed,
                "failed" => WebSearchToolCallStatus.Failed,
                _ => null,
            };
        }
    }
}