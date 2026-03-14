//HintName: G.Models.AgentSearchCorporaParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Agent-specific search parameters that support eager references.
    /// </summary>
    public sealed partial class AgentSearchCorporaParameters
    {
        /// <summary>
        /// The corpora to search, with support for eager references.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("corpora")]
        public global::System.Collections.Generic.IList<global::G.AgentKeyedSearchCorpus>? Corpora { get; set; }

        /// <summary>
        /// Number of results to skip for pagination.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// Maximum number of results to return.<br/>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_configuration")]
        public global::G.ContextConfiguration? ContextConfiguration { get; set; }

        /// <summary>
        /// Rerank results of the search. Rerankers are very powerful tools to improve the order of search results. By default the search will use the most powerful reranker available to the customer's plan. To disable reranking, set the reranker `type` to `"none"`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reranker")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SearchRerankerJsonConverter))]
        public global::G.SearchReranker? Reranker { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSearchCorporaParameters" /> class.
        /// </summary>
        /// <param name="corpora">
        /// The corpora to search, with support for eager references.
        /// </param>
        /// <param name="offset">
        /// Number of results to skip for pagination.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Maximum number of results to return.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="contextConfiguration">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="reranker">
        /// Rerank results of the search. Rerankers are very powerful tools to improve the order of search results. By default the search will use the most powerful reranker available to the customer's plan. To disable reranking, set the reranker `type` to `"none"`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSearchCorporaParameters(
            global::System.Collections.Generic.IList<global::G.AgentKeyedSearchCorpus>? corpora,
            int? offset,
            int? limit,
            global::G.ContextConfiguration? contextConfiguration,
            global::G.SearchReranker? reranker)
        {
            this.Corpora = corpora;
            this.Offset = offset;
            this.Limit = limit;
            this.ContextConfiguration = contextConfiguration;
            this.Reranker = reranker;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSearchCorporaParameters" /> class.
        /// </summary>
        public AgentSearchCorporaParameters()
        {
        }
    }
}