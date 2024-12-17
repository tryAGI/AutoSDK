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
        [global::Newtonsoft.Json.JsonProperty("search_queries", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ChatSearchQuery> SearchQueries { get; set; } = default!;


        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSearchQueriesGenerationEvent" /> class.
        /// </summary>
        /// <param name="searchQueries">
        /// Generated search queries, meant to be used as part of the RAG flow.
        /// </param>
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