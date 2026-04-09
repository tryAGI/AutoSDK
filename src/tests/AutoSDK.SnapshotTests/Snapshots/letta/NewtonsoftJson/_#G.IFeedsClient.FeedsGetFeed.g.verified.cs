//HintName: G.IFeedsClient.FeedsGetFeed.g.cs
#nullable enable

namespace G
{
    public partial interface IFeedsClient
    {
        /// <summary>
        /// Get Feed<br/>
        /// Retrieve feed details by ID
        /// </summary>
        /// <param name="feedId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FeedsGetFeedResponse> FeedsGetFeedAsync(
            string feedId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}