//HintName: G.IWorkspaceClient.GetWorkspaceWebhooks.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkspaceClient
    {
        /// <summary>
        /// List Workspace Webhooks<br/>
        /// List all webhooks for a workspace
        /// </summary>
        /// <param name="includeUsages">
        /// Whether to include active usages of the webhook, only usable by admins<br/>
        /// Default Value: false
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.WorkspaceWebhookListResponseModel> GetWorkspaceWebhooksAsync(
            bool? includeUsages = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}