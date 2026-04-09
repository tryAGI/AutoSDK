//HintName: G.IWorkspacesMembersClient.CreateAdminWorkspacesByWorkspaceIdUsers.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkspacesMembersClient
    {
        /// <summary>
        /// Add workspace member
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CreateAdminWorkspacesByWorkspaceIdUsersAsync(
            string workspaceId,

            global::G.CreateAdminWorkspacesUsersRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add workspace member
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="users"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CreateAdminWorkspacesByWorkspaceIdUsersAsync(
            string workspaceId,
            global::System.Collections.Generic.IList<global::G.CreateAdminWorkspacesUsersRequestUser>? users = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}