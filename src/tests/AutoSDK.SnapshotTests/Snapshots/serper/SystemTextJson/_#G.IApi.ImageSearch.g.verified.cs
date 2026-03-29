//HintName: G.IApi.ImageSearch.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Image Search<br/>
        /// Search Google Images for image results.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ImageSearchResponse> ImageSearchAsync(

            global::G.ImageSearchRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Image Search<br/>
        /// Search Google Images for image results.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ImageSearchResponse> ImageSearchAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}