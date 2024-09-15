//HintName: G.IWorkspacesClient.ListPendingWorkspaceInvites.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// List Pending Workspace Invites<br/>
        /// Get all workspaces visible to this auth
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.AppSchemasTenant>> ListPendingWorkspaceInvitesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}