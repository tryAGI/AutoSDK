//HintName: G.IVideosClient.Videos.g.cs
#nullable enable

namespace G
{
    public partial interface IVideosClient
    {
        /// <summary>
        /// Articles with a video<br/>
        /// This endpoint allows the client to retrieve a list of articles that are uploaded with a video.<br/>
        /// It will only return published video articles ordered by descending popularity.<br/>
        /// It supports pagination, each page will contain 24 articles by default.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 24
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.VideoArticle>> VideosAsync(
            int? page = default,
            int? perPage = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}