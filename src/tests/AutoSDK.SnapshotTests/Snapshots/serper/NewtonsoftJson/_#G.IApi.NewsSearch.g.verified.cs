//HintName: G.IApi.NewsSearch.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// News Search<br/>
        /// Search Google News for recent articles and stories.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.NewsSearchResponse> NewsSearchAsync(

            global::G.NewsSearchRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// News Search<br/>
        /// Search Google News for recent articles and stories.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.NewsSearchResponse> NewsSearchAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}