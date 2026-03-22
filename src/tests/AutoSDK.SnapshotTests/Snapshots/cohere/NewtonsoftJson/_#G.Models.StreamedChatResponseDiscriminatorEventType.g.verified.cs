//HintName: G.Models.StreamedChatResponseDiscriminatorEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum StreamedChatResponseDiscriminatorEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="citation-generation")]
        CitationGeneration,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="debug")]
        Debug,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="search-queries-generation")]
        SearchQueriesGeneration,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="search-results")]
        SearchResults,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="stream-end")]
        StreamEnd,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="stream-start")]
        StreamStart,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text-generation")]
        TextGeneration,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool-calls-chunk")]
        ToolCallsChunk,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool-calls-generation")]
        ToolCallsGeneration,
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
                StreamedChatResponseDiscriminatorEventType.CitationGeneration => "citation-generation",
                StreamedChatResponseDiscriminatorEventType.Debug => "debug",
                StreamedChatResponseDiscriminatorEventType.SearchQueriesGeneration => "search-queries-generation",
                StreamedChatResponseDiscriminatorEventType.SearchResults => "search-results",
                StreamedChatResponseDiscriminatorEventType.StreamEnd => "stream-end",
                StreamedChatResponseDiscriminatorEventType.StreamStart => "stream-start",
                StreamedChatResponseDiscriminatorEventType.TextGeneration => "text-generation",
                StreamedChatResponseDiscriminatorEventType.ToolCallsChunk => "tool-calls-chunk",
                StreamedChatResponseDiscriminatorEventType.ToolCallsGeneration => "tool-calls-generation",
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
                "citation-generation" => StreamedChatResponseDiscriminatorEventType.CitationGeneration,
                "debug" => StreamedChatResponseDiscriminatorEventType.Debug,
                "search-queries-generation" => StreamedChatResponseDiscriminatorEventType.SearchQueriesGeneration,
                "search-results" => StreamedChatResponseDiscriminatorEventType.SearchResults,
                "stream-end" => StreamedChatResponseDiscriminatorEventType.StreamEnd,
                "stream-start" => StreamedChatResponseDiscriminatorEventType.StreamStart,
                "text-generation" => StreamedChatResponseDiscriminatorEventType.TextGeneration,
                "tool-calls-chunk" => StreamedChatResponseDiscriminatorEventType.ToolCallsChunk,
                "tool-calls-generation" => StreamedChatResponseDiscriminatorEventType.ToolCallsGeneration,
                _ => null,
            };
        }
    }
}