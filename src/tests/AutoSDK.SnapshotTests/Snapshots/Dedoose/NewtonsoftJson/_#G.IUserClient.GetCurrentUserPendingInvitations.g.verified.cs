//HintName: G.IUserClient.GetCurrentUserPendingInvitations.g.cs
#nullable enable

namespace G
{
    public partial interface IUserClient
    {
        /// <summary>
        /// GetCurrentUserPendingInvitations<br/>
        /// GetCurrentUserPendingInvitations
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.UserInvitation>> GetCurrentUserPendingInvitationsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}