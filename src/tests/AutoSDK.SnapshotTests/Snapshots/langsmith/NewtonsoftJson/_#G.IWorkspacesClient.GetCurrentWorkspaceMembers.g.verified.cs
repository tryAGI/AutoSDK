//HintName: G.IWorkspacesClient.GetCurrentWorkspaceMembers.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// Get Current Workspace Members
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TenantMembers> GetCurrentWorkspaceMembersAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}