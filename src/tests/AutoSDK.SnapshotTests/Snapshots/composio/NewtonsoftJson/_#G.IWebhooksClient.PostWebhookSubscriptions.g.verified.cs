//HintName: G.IWebhooksClient.PostWebhookSubscriptions.g.cs
#nullable enable

namespace G
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Create webhook subscription<br/>
        /// Creates a webhook subscription for the authenticated project. Only one subscription is allowed per project. The signing secret is returned only on creation.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostWebhookSubscriptionsResponse> PostWebhookSubscriptionsAsync(

            global::G.PostWebhookSubscriptionsRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create webhook subscription<br/>
        /// Creates a webhook subscription for the authenticated project. Only one subscription is allowed per project. The signing secret is returned only on creation.
        /// </summary>
        /// <param name="webhookUrl">
        /// HTTPS URL to receive webhook events
        /// </param>
        /// <param name="enabledEvents">
        /// Array of event types to subscribe to
        /// </param>
        /// <param name="version">
        /// Webhook payload version<br/>
        /// Default Value: V3
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostWebhookSubscriptionsResponse> PostWebhookSubscriptionsAsync(
            string webhookUrl,
            global::System.Collections.Generic.IList<string> enabledEvents,
            global::G.PostWebhookSubscriptionsRequestVersion? version = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}