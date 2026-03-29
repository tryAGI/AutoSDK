//HintName: G.IApi.VideoSearch.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Video Search<br/>
        /// Search Google for video results from YouTube and other video platforms.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.VideoSearchResponse> VideoSearchAsync(

            global::G.VideoSearchRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Video Search<br/>
        /// Search Google for video results from YouTube and other video platforms.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.VideoSearchResponse> VideoSearchAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}