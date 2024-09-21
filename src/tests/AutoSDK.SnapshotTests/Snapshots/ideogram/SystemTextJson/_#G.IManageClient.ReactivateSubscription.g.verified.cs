//HintName: G.IManageClient.ReactivateSubscription.g.cs
#nullable enable

namespace G
{
    public partial interface IManageClient
    {
        /// <summary>
        /// Reactivates a subscription by attempting to re-enable Metronome billing.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostApiReactivateResponse> ReactivateSubscriptionAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}