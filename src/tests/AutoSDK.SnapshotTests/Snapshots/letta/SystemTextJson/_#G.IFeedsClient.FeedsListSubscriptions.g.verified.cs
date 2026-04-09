//HintName: G.IFeedsClient.FeedsListSubscriptions.g.cs
#nullable enable

namespace G
{
    public partial interface IFeedsClient
    {
        /// <summary>
        /// List Feed Subscriptions<br/>
        /// List all agent subscriptions for a feed
        /// </summary>
        /// <param name="feedId"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="agentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FeedsListSubscriptionsResponse> FeedsListSubscriptionsAsync(
            string feedId,
            string? limit = default,
            global::G.OneOf<string, double?>? offset = default,
            string? agentId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}