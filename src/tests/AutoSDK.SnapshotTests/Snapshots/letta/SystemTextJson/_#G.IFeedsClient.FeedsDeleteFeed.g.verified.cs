//HintName: G.IFeedsClient.FeedsDeleteFeed.g.cs
#nullable enable

namespace G
{
    public partial interface IFeedsClient
    {
        /// <summary>
        /// Delete Feed<br/>
        /// Soft delete a feed and clean up its sequence
        /// </summary>
        /// <param name="feedId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FeedsDeleteFeedResponse> FeedsDeleteFeedAsync(
            string feedId,

            object request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Feed<br/>
        /// Soft delete a feed and clean up its sequence
        /// </summary>
        /// <param name="feedId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FeedsDeleteFeedResponse> FeedsDeleteFeedAsync(
            string feedId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}