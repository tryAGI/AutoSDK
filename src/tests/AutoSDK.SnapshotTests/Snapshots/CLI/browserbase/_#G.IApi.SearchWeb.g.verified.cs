//HintName: G.IApi.SearchWeb.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Web Search<br/>
        /// Perform a web search and return structured results.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SearchWebResponse> SearchWebAsync(

            global::G.SearchWebRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Web Search<br/>
        /// Perform a web search and return structured results.
        /// </summary>
        /// <param name="query">
        /// The search query string
        /// </param>
        /// <param name="numResults">
        /// Number of results to return (1-25)<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SearchWebResponse> SearchWebAsync(
            string query,
            int? numResults = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}