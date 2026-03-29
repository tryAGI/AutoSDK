//HintName: G.Models.RerankerApiRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RerankerApiRequest
    {
        /// <summary>
        /// The query as a string. The query can contain a maximum of 4000 tokens for `rerank-2`, 2000 tokens for `rerank-2-lite` and `rerank-1`, and 1000 tokens for `rerank-lite-1`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// The documents to be reranked as a list of strings. &lt;ul&gt; &lt;li&gt; The number of documents cannot exceed 1000. &lt;/li&gt; &lt;li&gt; The sum of the number of tokens in the query and the number of tokens in any single document cannot exceed 16000 for `rerank-2`; 8000 for `rerank-2-lite` and `rerank-1`; and 4000 for `rerank-lite-1`. &lt;/li&gt; &lt;li&gt; The total number of tokens, defined as "the number of query tokens × the number of documents + sum of the number of tokens in all documents", cannot exceed 600K for `rerank-2` and `rerank-2-lite`, and 300K for `rerank-1` and `rerank-lite-1`. Please see our &lt;a href="https://docs.voyageai.com/docs/faq#what-is-the-total-number-of-tokens-for-the-rerankers"&gt;FAQ&lt;/a&gt;. &lt;/li&gt; &lt;/ul&gt;
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Documents { get; set; }

        /// <summary>
        /// Name of the model. Recommended options: `rerank-2`, `rerank-2-lite`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The number of most relevant documents to return. If not specified, the reranking results of all documents will be returned.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_k")]
        public int? TopK { get; set; }

        /// <summary>
        /// Whether to return the documents in the response. Defaults to `false`. &lt;ul&gt; &lt;li&gt; If `false`, the API will return a list of {"index", "relevance_score"} where "index" refers to the index of a document within the input list. &lt;/li&gt; &lt;li&gt; If `true`, the API will return a list of {"index", "document", "relevance_score"} where "document" is the corresponding document from the input list. &lt;/li&gt; &lt;/ul&gt;<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_documents")]
        public bool? ReturnDocuments { get; set; }

        /// <summary>
        /// Whether to truncate the input to satisfy the "context length limit" on the query and the documents. Defaults to `true`. &lt;ul&gt; &lt;li&gt; If `true`,  the query and documents will be truncated to fit within the context length limit, before processed by the reranker model. &lt;/li&gt; &lt;li&gt; If `false`, an error will be raised when the query exceeds 4000 tokens for `rerank-2`; 2000 tokens `rerank-2-lite` and `rerank-1`; and 1000 tokens for `rerank-lite-1`, or the sum of the number of tokens in the query and the number of tokens in any single document exceeds 16000 for `rerank-2`; 8000 for `rerank-2-lite` and `rerank-1`; and 4000 for `rerank-lite-1`. &lt;/li&gt; &lt;/ul&gt;<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncation")]
        public bool? Truncation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankerApiRequest" /> class.
        /// </summary>
        /// <param name="query">
        /// The query as a string. The query can contain a maximum of 4000 tokens for `rerank-2`, 2000 tokens for `rerank-2-lite` and `rerank-1`, and 1000 tokens for `rerank-lite-1`.
        /// </param>
        /// <param name="documents">
        /// The documents to be reranked as a list of strings. &lt;ul&gt; &lt;li&gt; The number of documents cannot exceed 1000. &lt;/li&gt; &lt;li&gt; The sum of the number of tokens in the query and the number of tokens in any single document cannot exceed 16000 for `rerank-2`; 8000 for `rerank-2-lite` and `rerank-1`; and 4000 for `rerank-lite-1`. &lt;/li&gt; &lt;li&gt; The total number of tokens, defined as "the number of query tokens × the number of documents + sum of the number of tokens in all documents", cannot exceed 600K for `rerank-2` and `rerank-2-lite`, and 300K for `rerank-1` and `rerank-lite-1`. Please see our &lt;a href="https://docs.voyageai.com/docs/faq#what-is-the-total-number-of-tokens-for-the-rerankers"&gt;FAQ&lt;/a&gt;. &lt;/li&gt; &lt;/ul&gt;
        /// </param>
        /// <param name="model">
        /// Name of the model. Recommended options: `rerank-2`, `rerank-2-lite`.
        /// </param>
        /// <param name="topK">
        /// The number of most relevant documents to return. If not specified, the reranking results of all documents will be returned.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="returnDocuments">
        /// Whether to return the documents in the response. Defaults to `false`. &lt;ul&gt; &lt;li&gt; If `false`, the API will return a list of {"index", "relevance_score"} where "index" refers to the index of a document within the input list. &lt;/li&gt; &lt;li&gt; If `true`, the API will return a list of {"index", "document", "relevance_score"} where "document" is the corresponding document from the input list. &lt;/li&gt; &lt;/ul&gt;<br/>
        /// Default Value: false
        /// </param>
        /// <param name="truncation">
        /// Whether to truncate the input to satisfy the "context length limit" on the query and the documents. Defaults to `true`. &lt;ul&gt; &lt;li&gt; If `true`,  the query and documents will be truncated to fit within the context length limit, before processed by the reranker model. &lt;/li&gt; &lt;li&gt; If `false`, an error will be raised when the query exceeds 4000 tokens for `rerank-2`; 2000 tokens `rerank-2-lite` and `rerank-1`; and 1000 tokens for `rerank-lite-1`, or the sum of the number of tokens in the query and the number of tokens in any single document exceeds 16000 for `rerank-2`; 8000 for `rerank-2-lite` and `rerank-1`; and 4000 for `rerank-lite-1`. &lt;/li&gt; &lt;/ul&gt;<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RerankerApiRequest(
            string query,
            global::System.Collections.Generic.IList<string> documents,
            string model,
            int? topK,
            bool? returnDocuments,
            bool? truncation)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Documents = documents ?? throw new global::System.ArgumentNullException(nameof(documents));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.TopK = topK;
            this.ReturnDocuments = returnDocuments;
            this.Truncation = truncation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankerApiRequest" /> class.
        /// </summary>
        public RerankerApiRequest()
        {
        }
    }
}