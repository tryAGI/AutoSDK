//HintName: G.IUserInvitesClient.CreateAdminUsersInvitesByInviteIdResend.g.cs
#nullable enable

namespace G
{
    public partial interface IUserInvitesClient
    {
        /// <summary>
        /// Resend Invite<br/>
        /// Resend an invite to user for your organization
        /// </summary>
        /// <param name="inviteId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateAdminUsersInvitesResendResponse> CreateAdminUsersInvitesByInviteIdResendAsync(
            string inviteId,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Resend Invite<br/>
        /// Resend an invite to user for your organization
        /// </summary>
        /// <param name="inviteId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<global::G.CreateAdminUsersInvitesResendResponse>> CreateAdminUsersInvitesByInviteIdResendAsResponseAsync(
            string inviteId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}