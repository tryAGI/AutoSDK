//HintName: G.IWebhooksClient.Create3.g.cs
#nullable enable

namespace G
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Create Workspace Webhook<br/>
        /// Create a new webhook for the workspace with the specified authentication type.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.WorkspaceCreateWebhookResponseModel> Create3Async(

            global::G.BodyCreateWorkspaceWebhookV1WorkspaceWebhooksPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Workspace Webhook<br/>
        /// Create a new webhook for the workspace with the specified authentication type.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="settings">
        /// Webhook settings object containing auth_type and corresponding configuration
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.WorkspaceCreateWebhookResponseModel> Create3Async(
            global::G.WebhookHMACSettings settings,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}