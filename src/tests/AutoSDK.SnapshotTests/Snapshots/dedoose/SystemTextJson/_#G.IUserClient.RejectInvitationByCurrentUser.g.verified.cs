//HintName: G.IUserClient.RejectInvitationByCurrentUser.g.cs
#nullable enable

namespace G
{
    public partial interface IUserClient
    {
        /// <summary>
        /// RejectInvitationByCurrentUser<br/>
        /// RejectInvitationByCurrentUser
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> RejectInvitationByCurrentUserAsync(
            global::G.RejectInvitationByCurrentUserRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// RejectInvitationByCurrentUser<br/>
        /// RejectInvitationByCurrentUser
        /// </summary>
        /// <param name="invitationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> RejectInvitationByCurrentUserAsync(
            global::System.Guid invitationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}