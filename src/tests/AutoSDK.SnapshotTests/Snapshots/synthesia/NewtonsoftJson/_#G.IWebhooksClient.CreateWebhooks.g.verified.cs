//HintName: G.IWebhooksClient.CreateWebhooks.g.cs
#nullable enable

namespace G
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Create a Webhook<br/>
        /// Use the Create a webhook endpoint to create a new even subscription.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.WebhookResponse> CreateWebhooksAsync(

            global::G.CreateWebhookRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Webhook<br/>
        /// Use the Create a webhook endpoint to create a new even subscription.
        /// </summary>
        /// <param name="events">
        /// [The webhook events](https://docs.synthesia.io/reference/webhook-events) for which notifications should be sent.
        /// </param>
        /// <param name="url">
        /// The URL to send notifications to
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.WebhookResponse> CreateWebhooksAsync(
            global::System.Collections.Generic.IList<global::G.CreateWebhookRequestEvent> events,
            string url,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}