//HintName: G.IWebhooksClient.DeleteWebhooksByWebhookId.g.cs
#nullable enable

namespace G
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Delete a webhook<br/>
        /// Use this endpoint to delete videos.
        /// </summary>
        /// <param name="webhookId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteWebhooksByWebhookIdAsync(
            string webhookId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}