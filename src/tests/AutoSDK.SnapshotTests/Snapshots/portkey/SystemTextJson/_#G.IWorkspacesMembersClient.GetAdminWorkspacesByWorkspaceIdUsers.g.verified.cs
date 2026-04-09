//HintName: G.IWorkspacesMembersClient.GetAdminWorkspacesByWorkspaceIdUsers.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkspacesMembersClient
    {
        /// <summary>
        /// Get workspace members
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="currentPage">
        /// Default Value: 50
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 0
        /// </param>
        /// <param name="role"></param>
        /// <param name="email"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.WorkspaceMemberList> GetAdminWorkspacesByWorkspaceIdUsersAsync(
            string workspaceId,
            double? currentPage = default,
            double? pageSize = default,
            global::G.GetAdminWorkspacesUsersRole? role = default,
            string? email = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}