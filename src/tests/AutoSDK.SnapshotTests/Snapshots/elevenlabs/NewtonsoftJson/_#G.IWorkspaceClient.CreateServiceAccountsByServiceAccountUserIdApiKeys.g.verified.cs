//HintName: G.IWorkspaceClient.CreateServiceAccountsByServiceAccountUserIdApiKeys.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkspaceClient
    {
        /// <summary>
        /// Create Service Account Api Key<br/>
        /// Create a new API key for a service account
        /// </summary>
        /// <param name="serviceAccountUserId"></param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.WorkspaceCreateApiKeyResponseModel> CreateServiceAccountsByServiceAccountUserIdApiKeysAsync(
            string serviceAccountUserId,

            global::G.BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Service Account Api Key<br/>
        /// Create a new API key for a service account
        /// </summary>
        /// <param name="serviceAccountUserId"></param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="name"></param>
        /// <param name="permissions">
        /// The permissions of the XI API.
        /// </param>
        /// <param name="characterLimit">
        /// The character limit of the XI API key. If provided this will limit the usage of this api key to n characters per month where n is the chosen value. Requests that incur charges will fail after reaching this monthly limit.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.WorkspaceCreateApiKeyResponseModel> CreateServiceAccountsByServiceAccountUserIdApiKeysAsync(
            string serviceAccountUserId,
            string name,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.PermissionType>, string> permissions,
            string? xiApiKey = default,
            int? characterLimit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}