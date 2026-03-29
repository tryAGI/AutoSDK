//HintName: G.IWebhooksClient.GetWebhooksByWebhookId.g.cs
#nullable enable

namespace G
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Retrieve a webhook<br/>
        /// Retrieve a webhook endpoint to pull for the webhook status.
        /// </summary>
        /// <param name="webhookId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.WebhookResponse> GetWebhooksByWebhookIdAsync(
            string webhookId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}