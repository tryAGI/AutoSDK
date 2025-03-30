//HintName: G.IWorkspacesClient.ListWorkspaces.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// List Workspaces<br/>
        /// Get all workspaces visible to this auth in the current org. Does not create a new workspace/org.
        /// </summary>
        /// <param name="includeDeleted">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.TenantForUser>> ListWorkspacesAsync(
            bool? includeDeleted = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}