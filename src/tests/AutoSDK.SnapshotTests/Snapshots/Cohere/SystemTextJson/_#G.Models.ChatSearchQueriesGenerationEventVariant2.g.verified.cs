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
        [global::System.Text.Json.Serialization.JsonPropertyName("search_queries")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ChatSearchQuery> SearchQueries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSearchQueriesGenerationEventVariant2" /> class.
        /// </summary>
        /// <param name="searchQueries">
        /// Generated search queries, meant to be used as part of the RAG flow.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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