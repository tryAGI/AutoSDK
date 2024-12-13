//HintName: G.Models.ChatStreamEventDiscriminatorEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatStreamEventDiscriminatorEventType
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
    public static class ChatStreamEventDiscriminatorEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatStreamEventDiscriminatorEventType value)
        {
            return value switch
            {
                ChatStreamEventDiscriminatorEventType.StreamStart => "stream-start",
                ChatStreamEventDiscriminatorEventType.SearchQueriesGeneration => "search-queries-generation",
                ChatStreamEventDiscriminatorEventType.SearchResults => "search-results",
                ChatStreamEventDiscriminatorEventType.TextGeneration => "text-generation",
                ChatStreamEventDiscriminatorEventType.CitationGeneration => "citation-generation",
                ChatStreamEventDiscriminatorEventType.StreamEnd => "stream-end",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatStreamEventDiscriminatorEventType? ToEnum(string value)
        {
            return value switch
            {
                "stream-start" => ChatStreamEventDiscriminatorEventType.StreamStart,
                "search-queries-generation" => ChatStreamEventDiscriminatorEventType.SearchQueriesGeneration,
                "search-results" => ChatStreamEventDiscriminatorEventType.SearchResults,
                "text-generation" => ChatStreamEventDiscriminatorEventType.TextGeneration,
                "citation-generation" => ChatStreamEventDiscriminatorEventType.CitationGeneration,
                "stream-end" => ChatStreamEventDiscriminatorEventType.StreamEnd,
                _ => null,
            };
        }
    }
}