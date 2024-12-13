//HintName: G.Models.ChatStreamEventDiscriminatorEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatStreamEventDiscriminatorEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="stream-start")]
        StreamStart,
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
        [global::System.Runtime.Serialization.EnumMember(Value="text-generation")]
        TextGeneration,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="citation-generation")]
        CitationGeneration,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="stream-end")]
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