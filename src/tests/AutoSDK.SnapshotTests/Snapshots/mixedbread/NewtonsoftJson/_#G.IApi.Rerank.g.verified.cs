//HintName: G.IApi.Rerank.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Rerank different kind of documents for a given query<br/>
        /// Rerank different kind of documents for a given query.<br/>
        /// Args:<br/>
        ///     params: RerankParams: The parameters for reranking.<br/>
        /// Returns:<br/>
        ///     RerankResponse: The reranked documents for the input query.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RerankResponse> RerankAsync(

            global::G.RerankParams request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rerank different kind of documents for a given query<br/>
        /// Rerank different kind of documents for a given query.<br/>
        /// Args:<br/>
        ///     params: RerankParams: The parameters for reranking.<br/>
        /// Returns:<br/>
        ///     RerankResponse: The reranked documents for the input query.
        /// </summary>
        /// <param name="model">
        /// The model to use for reranking documents.<br/>
        /// Default Value: mixedbread-ai/mxbai-rerank-large-v2
        /// </param>
        /// <param name="query">
        /// The query to rerank the documents.
        /// </param>
        /// <param name="input">
        /// The input documents to rerank.
        /// </param>
        /// <param name="rankFields">
        /// The fields of the documents to rank.
        /// </param>
        /// <param name="topK">
        /// The number of documents to return.<br/>
        /// Default Value: -1
        /// </param>
        /// <param name="returnInput">
        /// Whether to return the documents.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="rewriteQuery">
        /// Wether or not to rewrite the query before passing it to the reranking model<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.RerankResponse> RerankAsync(
            string query,
            global::System.Collections.Generic.IList<global::G.AnyOf<string, object, global::System.Collections.Generic.IList<object>>> input,
            string? model = default,
            global::System.Collections.Generic.IList<string>? rankFields = default,
            int? topK = default,
            bool? returnInput = default,
            bool? rewriteQuery = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}