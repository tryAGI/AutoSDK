//HintName: G.ICommentsClient.CommentsGet.g.cs
#nullable enable

namespace G
{
    public partial interface ICommentsClient
    {
        /// <summary>
        /// Get all comments
        /// </summary>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="objectType"></param>
        /// <param name="objectId"></param>
        /// <param name="authorUserId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetCommentsResponse> CommentsGetAsync(
            int? page = default,
            int? limit = default,
            string? objectType = default,
            string? objectId = default,
            string? authorUserId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}