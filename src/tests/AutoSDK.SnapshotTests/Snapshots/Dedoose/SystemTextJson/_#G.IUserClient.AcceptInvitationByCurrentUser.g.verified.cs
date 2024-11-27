//HintName: G.IUserClient.AcceptInvitationByCurrentUser.g.cs
#nullable enable

namespace G
{
    public partial interface IUserClient
    {
        /// <summary>
        /// AcceptInvitationByCurrentUser<br/>
        /// AcceptInvitationByCurrentUser
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AcceptInvitationByCurrentUserAsync(
            global::G.AcceptInvitationByCurrentUserRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// AcceptInvitationByCurrentUser<br/>
        /// AcceptInvitationByCurrentUser
        /// </summary>
        /// <param name="invitationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> AcceptInvitationByCurrentUserAsync(
            global::System.Guid invitationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}