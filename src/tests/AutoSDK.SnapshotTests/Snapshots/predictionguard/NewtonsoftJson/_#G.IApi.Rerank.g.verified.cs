//HintName: G.IApi.Rerank.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Rerank<br/>
        /// Rerank sorts text inputs by semantic relevance to a specified query.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RerankResponse200> RerankAsync(

            global::G.RerankRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rerank<br/>
        /// Rerank sorts text inputs by semantic relevance to a specified query.
        /// </summary>
        /// <param name="model">
        /// The model to use for reranking.
        /// </param>
        /// <param name="query">
        /// The query to rank against.
        /// </param>
        /// <param name="documents">
        /// Array of documents to rank.
        /// </param>
        /// <param name="returnDocuments">
        /// Boolean setting whether to return documents in output.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.RerankResponse200> RerankAsync(
            string model,
            string query,
            global::System.Collections.Generic.IList<string> documents,
            bool? returnDocuments = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}