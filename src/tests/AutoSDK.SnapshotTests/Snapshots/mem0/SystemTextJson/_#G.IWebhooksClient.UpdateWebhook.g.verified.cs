//HintName: G.IWebhooksClient.UpdateWebhook.g.cs
#nullable enable

namespace G
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Update Webhook<br/>
        /// Update an existing webhook
        /// </summary>
        /// <param name="webhookId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateWebhookResponse> UpdateWebhookAsync(
            string webhookId,

            global::G.UpdateWebhookRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Webhook<br/>
        /// Update an existing webhook
        /// </summary>
        /// <param name="webhookId"></param>
        /// <param name="name">
        /// New name for the webhook
        /// </param>
        /// <param name="url">
        /// New URL endpoint for the webhook
        /// </param>
        /// <param name="eventTypes">
        /// New list of event types to subscribe to
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateWebhookResponse> UpdateWebhookAsync(
            string webhookId,
            string? name = default,
            string? url = default,
            global::System.Collections.Generic.IList<global::G.UpdateWebhookRequestEventType>? eventTypes = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}