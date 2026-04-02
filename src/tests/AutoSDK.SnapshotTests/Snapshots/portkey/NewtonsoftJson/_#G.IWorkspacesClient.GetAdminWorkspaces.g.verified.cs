//HintName: G.IWorkspacesClient.GetAdminWorkspaces.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// Get All Workspaces
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="currentPage"></param>
        /// <param name="name"></param>
        /// <param name="exactName"></param>
        /// <param name="status"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.WorkspaceList> GetAdminWorkspacesAsync(
            int? pageSize = default,
            int? currentPage = default,
            string? name = default,
            string? exactName = default,
            global::G.GetAdminWorkspacesStatus? status = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get All Workspaces
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="currentPage"></param>
        /// <param name="name"></param>
        /// <param name="exactName"></param>
        /// <param name="status"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<global::G.WorkspaceList>> GetAdminWorkspacesAsResponseAsync(
            int? pageSize = default,
            int? currentPage = default,
            string? name = default,
            string? exactName = default,
            global::G.GetAdminWorkspacesStatus? status = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}