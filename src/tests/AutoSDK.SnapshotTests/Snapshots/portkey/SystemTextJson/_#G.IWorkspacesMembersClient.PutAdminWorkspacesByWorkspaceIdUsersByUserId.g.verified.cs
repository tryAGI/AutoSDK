//HintName: G.IWorkspacesMembersClient.PutAdminWorkspacesByWorkspaceIdUsersByUserId.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkspacesMembersClient
    {
        /// <summary>
        /// Update workspace member
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> PutAdminWorkspacesByWorkspaceIdUsersByUserIdAsync(
            string workspaceId,
            string userId,

            global::G.PutAdminWorkspacesUsersRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update workspace member
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="userId"></param>
        /// <param name="role"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> PutAdminWorkspacesByWorkspaceIdUsersByUserIdAsync(
            string workspaceId,
            string userId,
            global::G.PutAdminWorkspacesUsersRequestRole? role = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}