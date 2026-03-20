//HintName: G.Models.ChatSearchQueriesGenerationEvent6evypd.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatSearchQueriesGenerationEvent6evypd
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
        /// Initializes a new instance of the <see cref="ChatSearchQueriesGenerationEvent6evypd" /> class.
        /// </summary>
        /// <param name="searchQueries">
        /// Generated search queries, meant to be used as part of the RAG flow.
        /// </param>
        public ChatSearchQueriesGenerationEvent6evypd(
            global::System.Collections.Generic.IList<global::G.ChatSearchQuery> searchQueries)
        {
            this.SearchQueries = searchQueries ?? throw new global::System.ArgumentNullException(nameof(searchQueries));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSearchQueriesGenerationEvent6evypd" /> class.
        /// </summary>
        public ChatSearchQueriesGenerationEvent6evypd()
        {
        }
    }
}