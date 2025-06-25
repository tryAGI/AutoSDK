﻿//HintName: G.IReposClient.ReposDeclineInvitationForAuthenticatedUser.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Decline a repository invitation
        /// </summary>
        /// <param name="invitationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task ReposDeclineInvitationForAuthenticatedUserAsync(
            int invitationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}