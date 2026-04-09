//HintName: G.IManageClient.ReactivateSubscription.g.cs
#nullable enable

namespace G
{
    public partial interface IManageClient
    {
        /// <summary>
        /// Reactivates a subscription by attempting to re-enable Metronome billing.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostApiReactivateResponse> ReactivateSubscriptionAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}