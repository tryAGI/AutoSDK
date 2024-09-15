//HintName: G.IRerankClient.Rerank.g.cs
#nullable enable

namespace G
{
    public partial interface IRerankClient
    {
        /// <summary>
        /// Create a rerank request<br/>
        /// Query a reranker model
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.RerankResponse> RerankAsync(
            global::G.RerankRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a rerank request<br/>
        /// Query a reranker model
        /// </summary>
        /// <param name="model">
        /// The model to be used for the rerank request.<br/>
        /// Example: Salesforce/Llama-Rank-V1
        /// </param>
        /// <param name="query">
        /// The search query to be used for ranking.<br/>
        /// Example: What animals can I find near Peru?
        /// </param>
        /// <param name="documents">
        /// List of documents, which can be either strings or objects.<br/>
        /// Example: [, , , ]
        /// </param>
        /// <param name="topN">
        /// The number of top results to return.<br/>
        /// Example: 2
        /// </param>
        /// <param name="returnDocuments">
        /// Whether to return supplied documents with the response.<br/>
        /// Example: true
        /// </param>
        /// <param name="rankFields">
        /// List of keys in the JSON Object document to rank by. Defaults to use all supplied keys for ranking.<br/>
        /// Example: [title, text]
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.RerankResponse> RerankAsync(
            string model,
            string query,
            global::G.OneOf<global::System.Collections.Generic.IList<global::G.RerankRequestDocumentsVariant1Item>, global::System.Collections.Generic.IList<string>> documents,
            int topN = default,
            bool returnDocuments = default,
            global::System.Collections.Generic.IList<string>? rankFields = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}