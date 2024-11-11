//HintName: G.Models.ChatSearchQueriesGenerationEventVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatSearchQueriesGenerationEventVariant2
    {
        /// <summary>
        /// Generated search queries, meant to be used as part of the RAG flow.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("search_queries", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ChatSearchQuery> SearchQueries { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSearchQueriesGenerationEventVariant2" /> class.
        /// </summary>
        /// <param name="searchQueries">
        /// Generated search queries, meant to be used as part of the RAG flow.
        /// </param>
        public ChatSearchQueriesGenerationEventVariant2(
            global::System.Collections.Generic.IList<global::G.ChatSearchQuery> searchQueries)
        {
            this.SearchQueries = searchQueries ?? throw new global::System.ArgumentNullException(nameof(searchQueries));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSearchQueriesGenerationEventVariant2" /> class.
        /// </summary>
        public ChatSearchQueriesGenerationEventVariant2()
        {
        }
    }
}