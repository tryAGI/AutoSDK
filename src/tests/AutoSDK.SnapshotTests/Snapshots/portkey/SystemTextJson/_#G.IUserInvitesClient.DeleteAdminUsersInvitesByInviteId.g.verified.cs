//HintName: G.IUserInvitesClient.DeleteAdminUsersInvitesByInviteId.g.cs
#nullable enable

namespace G
{
    public partial interface IUserInvitesClient
    {
        /// <summary>
        /// Delete Invite By ID
        /// </summary>
        /// <param name="inviteId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteAdminUsersInvitesByInviteIdAsync(
            string inviteId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}