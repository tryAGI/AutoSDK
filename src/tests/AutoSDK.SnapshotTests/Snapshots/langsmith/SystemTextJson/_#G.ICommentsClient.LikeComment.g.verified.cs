//HintName: G.ICommentsClient.LikeComment.g.cs
#nullable enable

namespace G
{
    public partial interface ICommentsClient
    {
        /// <summary>
        /// Like Comment
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="parentCommentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> LikeCommentAsync(
            string owner,
            string repo,
            global::System.Guid parentCommentId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}