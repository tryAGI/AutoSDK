//HintName: G.IWorkspacesClient.GetAdminWorkspacesByWorkspaceId.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// Get workspace
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.WorkspaceWithUsers> GetAdminWorkspacesByWorkspaceIdAsync(
            string workspaceId,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get workspace
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<global::G.WorkspaceWithUsers>> GetAdminWorkspacesByWorkspaceIdAsResponseAsync(
            string workspaceId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}