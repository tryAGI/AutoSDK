//HintName: G.Models.StreamedChatResponseDiscriminatorEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum StreamedChatResponseDiscriminatorEventType
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
        ToolCallsGeneration,
        /// <summary>
        /// 
        /// </summary>
        StreamEnd,
        /// <summary>
        /// 
        /// </summary>
        ToolCallsChunk,
        /// <summary>
        /// 
        /// </summary>
        Debug,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StreamedChatResponseDiscriminatorEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StreamedChatResponseDiscriminatorEventType value)
        {
            return value switch
            {
                StreamedChatResponseDiscriminatorEventType.StreamStart => "stream-start",
                StreamedChatResponseDiscriminatorEventType.SearchQueriesGeneration => "search-queries-generation",
                StreamedChatResponseDiscriminatorEventType.SearchResults => "search-results",
                StreamedChatResponseDiscriminatorEventType.TextGeneration => "text-generation",
                StreamedChatResponseDiscriminatorEventType.CitationGeneration => "citation-generation",
                StreamedChatResponseDiscriminatorEventType.ToolCallsGeneration => "tool-calls-generation",
                StreamedChatResponseDiscriminatorEventType.StreamEnd => "stream-end",
                StreamedChatResponseDiscriminatorEventType.ToolCallsChunk => "tool-calls-chunk",
                StreamedChatResponseDiscriminatorEventType.Debug => "debug",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StreamedChatResponseDiscriminatorEventType? ToEnum(string value)
        {
            return value switch
            {
                "stream-start" => StreamedChatResponseDiscriminatorEventType.StreamStart,
                "search-queries-generation" => StreamedChatResponseDiscriminatorEventType.SearchQueriesGeneration,
                "search-results" => StreamedChatResponseDiscriminatorEventType.SearchResults,
                "text-generation" => StreamedChatResponseDiscriminatorEventType.TextGeneration,
                "citation-generation" => StreamedChatResponseDiscriminatorEventType.CitationGeneration,
                "tool-calls-generation" => StreamedChatResponseDiscriminatorEventType.ToolCallsGeneration,
                "stream-end" => StreamedChatResponseDiscriminatorEventType.StreamEnd,
                "tool-calls-chunk" => StreamedChatResponseDiscriminatorEventType.ToolCallsChunk,
                "debug" => StreamedChatResponseDiscriminatorEventType.Debug,
                _ => null,
            };
        }
    }
}