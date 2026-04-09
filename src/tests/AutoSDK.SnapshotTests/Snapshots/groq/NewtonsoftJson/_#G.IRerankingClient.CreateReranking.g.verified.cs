//HintName: G.IRerankingClient.CreateReranking.g.cs
#nullable enable

namespace G
{
    public partial interface IRerankingClient
    {
        /// <summary>
        /// Reranks documents based on their relevance to a query.<br/>
        /// Given a query and a list of documents, returns the documents ranked by their relevance to the query.<br/>
        /// The documents are scored and sorted in descending order of relevance.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RerankingResponse> CreateRerankingAsync(

            global::G.RerankingRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Reranks documents based on their relevance to a query.<br/>
        /// Given a query and a list of documents, returns the documents ranked by their relevance to the query.<br/>
        /// The documents are scored and sorted in descending order of relevance.
        /// </summary>
        /// <param name="model">
        /// ID of the reranking model to use.<br/>
        /// Example: qwen3-reranker-4b
        /// </param>
        /// <param name="query">
        /// The search query to rank documents against.<br/>
        /// Example: artificial intelligence research
        /// </param>
        /// <param name="docs">
        /// An array of documents to rank. Each document is a string containing the text content.<br/>
        /// Maximum of 100 documents per request.<br/>
        /// Example: [Machine learning is a subset of artificial intelligence, The weather forecast predicts rain tomorrow, Deep learning uses neural networks with multiple layers]
        /// </param>
        /// <param name="instruction">
        /// Optional instruction to guide the reranking process. If not provided, <br/>
        /// a default instruction will be used.<br/>
        /// Example: Find the most relevant document about AI research
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.RerankingResponse> CreateRerankingAsync(
            string model,
            string query,
            global::System.Collections.Generic.IList<string> docs,
            string? instruction = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}