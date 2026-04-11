//HintName: G.IWorkspacePermissionsClient.GetWorkspaceUserPermissions.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkspacePermissionsClient
    {
        /// <summary>
        /// Get workspace permissions for the authenticated user<br/>
        /// Get workspace permissions for the authenticated user
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.WorkspaceUserPermissions> GetWorkspaceUserPermissionsAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}