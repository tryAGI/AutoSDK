//HintName: G.IFeedsClient.FeedsPublishMessages.g.cs
#nullable enable

namespace G
{
    public partial interface IFeedsClient
    {
        /// <summary>
        /// Publish Messages<br/>
        /// Batch insert messages into a feed (up to 10,000 per request)
        /// </summary>
        /// <param name="feedId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FeedsPublishMessagesResponse> FeedsPublishMessagesAsync(
            string feedId,

            global::G.FeedsPublishMessagesRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Publish Messages<br/>
        /// Batch insert messages into a feed (up to 10,000 per request)
        /// </summary>
        /// <param name="feedId"></param>
        /// <param name="messages"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FeedsPublishMessagesResponse> FeedsPublishMessagesAsync(
            string feedId,
            global::System.Collections.Generic.IList<global::G.FeedsPublishMessagesRequestMessage> messages,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}