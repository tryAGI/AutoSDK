//HintName: G.IReposClient.ReposListWebhookDeliveries.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// List deliveries for a repository webhook<br/>
        /// Returns a list of webhook deliveries for a webhook configured in a repository.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="hookId"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="redelivery"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.HookDeliveryItem>> ReposListWebhookDeliveriesAsync(
            string owner,
            string repo,
            int hookId,
            int? perPage = default,
            string? cursor = default,
            bool? redelivery = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}