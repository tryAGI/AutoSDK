//HintName: G.IApi.Search.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Google Search<br/>
        /// Perform a Google web search. Returns organic results, knowledge graph, answer box,<br/>
        /// people also ask, and related searches.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SearchResponse> SearchAsync(

            global::G.SearchRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Google Search<br/>
        /// Perform a Google web search. Returns organic results, knowledge graph, answer box,<br/>
        /// people also ask, and related searches.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SearchResponse> SearchAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}