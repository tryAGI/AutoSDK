//HintName: G.IUserClient.UserAcceptInvitationByCurrentUser.g.cs
#nullable enable

namespace G
{
    public partial interface IUserClient
    {
        /// <summary>
        /// AcceptInvitationByCurrentUser.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="invitationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UserAcceptInvitationByCurrentUserAsync(
            string? token = default,
            global::System.Guid? invitationId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}