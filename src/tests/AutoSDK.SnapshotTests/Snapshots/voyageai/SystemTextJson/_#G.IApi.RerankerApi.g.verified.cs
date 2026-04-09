//HintName: G.IApi.RerankerApi.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Rerankers<br/>
        /// Voyage reranker endpoint receives as input a query, a list of documents, and other arguments such as the model name, and returns a response containing the reranking results.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RerankerApiResponse> RerankerApiAsync(

            global::G.RerankerApiRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rerankers<br/>
        /// Voyage reranker endpoint receives as input a query, a list of documents, and other arguments such as the model name, and returns a response containing the reranking results.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.RerankerApiResponse> RerankerApiAsync(
            string query,
            global::System.Collections.Generic.IList<string> documents,
            string model,
            int? topK = default,
            bool? returnDocuments = default,
            bool? truncation = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}