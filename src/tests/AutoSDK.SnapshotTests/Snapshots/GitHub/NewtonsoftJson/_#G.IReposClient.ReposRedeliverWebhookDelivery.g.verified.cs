//HintName: G.IReposClient.ReposRedeliverWebhookDelivery.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Redeliver a delivery for a repository webhook<br/>
        /// Redeliver a webhook delivery for a webhook configured in a repository.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="hookId"></param>
        /// <param name="deliveryId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ReposRedeliverWebhookDeliveryAsync(
            string owner,
            string repo,
            int hookId,
            int deliveryId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}