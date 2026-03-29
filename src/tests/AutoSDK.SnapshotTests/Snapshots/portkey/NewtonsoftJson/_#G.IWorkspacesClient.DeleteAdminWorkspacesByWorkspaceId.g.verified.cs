//HintName: G.IWorkspacesClient.DeleteAdminWorkspacesByWorkspaceId.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// Delete a workspace
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAdminWorkspacesByWorkspaceIdAsync(
            string workspaceId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}