//HintName: G.IApi.Search.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Search<br/>
        /// Perform a search with a Exa prompt-engineered query and retrieve a list of relevant results. Optionally get contents.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// curl -X POST 'https://api.exa.ai/search' \<br/>
        ///   -H 'x-api-key: YOUR-EXA-API-KEY' \<br/>
        ///   -H 'Content-Type: application/json' \<br/>
        ///   -d '{<br/>
        ///     "query": "Latest research in LLMs",<br/>
        ///     "text": true<br/>
        ///   }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.SearchResponse> SearchAsync(

            global::G.AllOf<global::G.SearchRequest2, global::G.CommonRequest> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search<br/>
        /// Perform a search with a Exa prompt-engineered query and retrieve a list of relevant results. Optionally get contents.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SearchResponse> SearchAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}