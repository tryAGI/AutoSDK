//HintName: G.Models.ChatStreamEventEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatStreamEventEventType
    {
        /// <summary>
        /// 
        /// </summary>
        CitationGeneration,
        /// <summary>
        /// 
        /// </summary>
        Debug,
        /// <summary>
        /// 
        /// </summary>
        SearchQueriesGeneration,
        /// <summary>
        /// 
        /// </summary>
        SearchResults,
        /// <summary>
        /// 
        /// </summary>
        StreamEnd,
        /// <summary>
        /// 
        /// </summary>
        StreamStart,
        /// <summary>
        /// 
        /// </summary>
        TextGeneration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatStreamEventEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatStreamEventEventType value)
        {
            return value switch
            {
                ChatStreamEventEventType.CitationGeneration => "citation-generation",
                ChatStreamEventEventType.Debug => "debug",
                ChatStreamEventEventType.SearchQueriesGeneration => "search-queries-generation",
                ChatStreamEventEventType.SearchResults => "search-results",
                ChatStreamEventEventType.StreamEnd => "stream-end",
                ChatStreamEventEventType.StreamStart => "stream-start",
                ChatStreamEventEventType.TextGeneration => "text-generation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatStreamEventEventType? ToEnum(string value)
        {
            return value switch
            {
                "citation-generation" => ChatStreamEventEventType.CitationGeneration,
                "debug" => ChatStreamEventEventType.Debug,
                "search-queries-generation" => ChatStreamEventEventType.SearchQueriesGeneration,
                "search-results" => ChatStreamEventEventType.SearchResults,
                "stream-end" => ChatStreamEventEventType.StreamEnd,
                "stream-start" => ChatStreamEventEventType.StreamStart,
                "text-generation" => ChatStreamEventEventType.TextGeneration,
                _ => null,
            };
        }
    }
}