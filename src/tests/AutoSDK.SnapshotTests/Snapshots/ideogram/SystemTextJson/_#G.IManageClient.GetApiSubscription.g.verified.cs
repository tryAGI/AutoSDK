//HintName: G.IManageClient.GetApiSubscription.g.cs
#nullable enable

namespace G
{
    public partial interface IManageClient
    {
        /// <summary>
        /// Retrieve data relevant to creating an API subscription.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ManageApiSubscriptionResponse> GetApiSubscriptionAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}