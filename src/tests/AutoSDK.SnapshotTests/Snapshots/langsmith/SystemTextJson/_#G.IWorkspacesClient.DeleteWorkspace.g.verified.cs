//HintName: G.IWorkspacesClient.DeleteWorkspace.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// Delete Workspace
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteWorkspaceAsync(
            global::System.Guid workspaceId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}