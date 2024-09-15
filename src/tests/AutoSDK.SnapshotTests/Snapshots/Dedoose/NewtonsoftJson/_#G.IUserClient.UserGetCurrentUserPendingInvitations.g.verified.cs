//HintName: G.IUserClient.UserGetCurrentUserPendingInvitations.g.cs
#nullable enable

namespace G
{
    public partial interface IUserClient
    {
        /// <summary>
        /// GetCurrentUserPendingInvitations.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.UserInvitation>> UserGetCurrentUserPendingInvitationsAsync(
            string? token = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}