//HintName: G.IWorkspaceClient.DeleteServiceAccountsByServiceAccountUserIdApiKeysByApiKeyId.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkspaceClient
    {
        /// <summary>
        /// Delete Service Account Api Key<br/>
        /// Delete an existing API key for a service account
        /// </summary>
        /// <param name="serviceAccountUserId"></param>
        /// <param name="apiKeyId"></param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteServiceAccountsByServiceAccountUserIdApiKeysByApiKeyIdAsync(
            string serviceAccountUserId,
            string apiKeyId,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}