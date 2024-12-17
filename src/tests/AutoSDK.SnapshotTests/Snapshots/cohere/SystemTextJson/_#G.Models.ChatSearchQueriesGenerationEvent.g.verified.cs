//HintName: G.Models.ChatSearchQueriesGenerationEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatSearchQueriesGenerationEvent : ChatStreamEvent
    {
        /// <summary>
        /// Generated search queries, meant to be used as part of the RAG flow.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_queries")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ChatSearchQuery> SearchQueries { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSearchQueriesGenerationEvent" /> class.
        /// </summary>
        /// <param name="searchQueries">
        /// Generated search queries, meant to be used as part of the RAG flow.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ChatSearchQueriesGenerationEvent(
            global::System.Collections.Generic.IList<global::G.ChatSearchQuery> searchQueries)
        {
            this.SearchQueries = searchQueries ?? throw new global::System.ArgumentNullException(nameof(searchQueries));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSearchQueriesGenerationEvent" /> class.
        /// </summary>
        public ChatSearchQueriesGenerationEvent()
        {
        }
    }
}