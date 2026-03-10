//HintName: G.IWorkspaceClient.EditWorkspaceWebhooksByWebhookId.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkspaceClient
    {
        /// <summary>
        /// Update Workspace Webhook<br/>
        /// Update the specified workspace webhook
        /// </summary>
        /// <param name="webhookId">
        /// The unique ID for the webhook
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PatchWorkspaceWebhookResponseModel> EditWorkspaceWebhooksByWebhookIdAsync(
            string webhookId,

            global::G.BodyUpdateWorkspaceWebhookV1WorkspaceWebhooksWebhookIdPatch request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Workspace Webhook<br/>
        /// Update the specified workspace webhook
        /// </summary>
        /// <param name="webhookId">
        /// The unique ID for the webhook
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="isDisabled">
        /// Whether to disable or enable the webhook
        /// </param>
        /// <param name="name">
        /// The display name of the webhook (used for display purposes only).
        /// </param>
        /// <param name="retryEnabled">
        /// Whether to enable automatic retries for transient failures (5xx, 429, timeout)
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PatchWorkspaceWebhookResponseModel> EditWorkspaceWebhooksByWebhookIdAsync(
            string webhookId,
            bool isDisabled,
            string name,
            string? xiApiKey = default,
            bool? retryEnabled = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}