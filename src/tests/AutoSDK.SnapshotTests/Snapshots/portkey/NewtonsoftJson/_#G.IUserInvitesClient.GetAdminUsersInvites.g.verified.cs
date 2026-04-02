//HintName: G.IUserInvitesClient.GetAdminUsersInvites.g.cs
#nullable enable

namespace G
{
    public partial interface IUserInvitesClient
    {
        /// <summary>
        /// Get All Invites
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="currentPage"></param>
        /// <param name="role"></param>
        /// <param name="email"></param>
        /// <param name="status"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.InviteList> GetAdminUsersInvitesAsync(
            int? pageSize = default,
            int? currentPage = default,
            global::G.GetAdminUsersInvitesRole? role = default,
            string? email = default,
            global::G.GetAdminUsersInvitesStatus? status = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get All Invites
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="currentPage"></param>
        /// <param name="role"></param>
        /// <param name="email"></param>
        /// <param name="status"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<global::G.InviteList>> GetAdminUsersInvitesAsResponseAsync(
            int? pageSize = default,
            int? currentPage = default,
            global::G.GetAdminUsersInvitesRole? role = default,
            string? email = default,
            global::G.GetAdminUsersInvitesStatus? status = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}