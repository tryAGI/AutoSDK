//HintName: G.IWorkspaceClient.DeleteWorkspaceWebhooksByWebhookId.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkspaceClient
    {
        /// <summary>
        /// Delete Workspace Webhook<br/>
        /// Delete the specified workspace webhook
        /// </summary>
        /// <param name="webhookId">
        /// The unique ID for the webhook
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteWorkspaceWebhookResponseModel> DeleteWorkspaceWebhooksByWebhookIdAsync(
            string webhookId,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}