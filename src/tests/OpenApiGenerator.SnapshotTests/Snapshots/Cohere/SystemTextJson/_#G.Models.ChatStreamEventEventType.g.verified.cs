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
        StreamStart,
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
        TextGeneration,
        /// <summary>
        /// 
        /// </summary>
        CitationGeneration,
        /// <summary>
        /// 
        /// </summary>
        StreamEnd,
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
                ChatStreamEventEventType.StreamStart => "stream-start",
                ChatStreamEventEventType.SearchQueriesGeneration => "search-queries-generation",
                ChatStreamEventEventType.SearchResults => "search-results",
                ChatStreamEventEventType.TextGeneration => "text-generation",
                ChatStreamEventEventType.CitationGeneration => "citation-generation",
                ChatStreamEventEventType.StreamEnd => "stream-end",
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
                "stream-start" => ChatStreamEventEventType.StreamStart,
                "search-queries-generation" => ChatStreamEventEventType.SearchQueriesGeneration,
                "search-results" => ChatStreamEventEventType.SearchResults,
                "text-generation" => ChatStreamEventEventType.TextGeneration,
                "citation-generation" => ChatStreamEventEventType.CitationGeneration,
                "stream-end" => ChatStreamEventEventType.StreamEnd,
                _ => null,
            };
        }
    }
}