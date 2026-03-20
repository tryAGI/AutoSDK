//HintName: G.IRerankersClient.ListRerankers.g.cs
#nullable enable

namespace G
{
    public partial interface IRerankersClient
    {

        /// <summary>
        /// List rerankers<br/>
        /// The List Rerankers API retrieves a list of available rerankers used to improve the ranking and ordering of search results.<br/>
        /// For more information about the available rerankers, see [Reranking overview](https://docs.vectara.com/docs/search-and-retrieval/rerankers/reranking-overview).
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="filter">
        /// Example: vectara.*
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="pageKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListRerankersResponse> ListRerankersAsync(
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? filter = default,
            int? limit = default,
            string? pageKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}