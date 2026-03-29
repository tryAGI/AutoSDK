//HintName: G.IWebhooksClient.CreateWebhook.g.cs
#nullable enable

namespace G
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Create Webhook<br/>
        /// Create a new webhook for a specific project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateWebhookResponse> CreateWebhookAsync(
            string projectId,

            global::G.CreateWebhookRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Webhook<br/>
        /// Create a new webhook for a specific project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="name">
        /// Name of the webhook
        /// </param>
        /// <param name="url">
        /// URL endpoint for the webhook.
        /// </param>
        /// <param name="eventTypes">
        /// List of event types to subscribe to.
        /// </param>
        /// <param name="isActive">
        /// Whether the webhook is active
        /// </param>
        /// <param name="requestProjectId">
        /// Unique identifier of the project.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateWebhookResponse> CreateWebhookAsync(
            string projectId,
            string url,
            string? name = default,
            global::System.Collections.Generic.IList<global::G.CreateWebhookRequestEventType>? eventTypes = default,
            bool? isActive = default,
            string? requestProjectId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}