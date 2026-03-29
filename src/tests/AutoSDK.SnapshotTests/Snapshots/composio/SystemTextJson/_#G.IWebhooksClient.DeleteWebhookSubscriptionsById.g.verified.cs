//HintName: G.IWebhooksClient.DeleteWebhookSubscriptionsById.g.cs
#nullable enable

namespace G
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Delete webhook subscription<br/>
        /// Permanently deletes a webhook subscription. This action cannot be undone.
        /// </summary>
        /// <param name="id">
        /// Webhook subscription ID
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteWebhookSubscriptionsByIdResponse> DeleteWebhookSubscriptionsByIdAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}