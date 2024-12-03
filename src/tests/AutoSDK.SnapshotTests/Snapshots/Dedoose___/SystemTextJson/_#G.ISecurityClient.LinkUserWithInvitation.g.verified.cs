//HintName: G.ISecurityClient.LinkUserWithInvitation.g.cs
#nullable enable

namespace G
{
    public partial interface ISecurityClient
    {
        /// <summary>
        /// LinkUserWithInvitation<br/>
        /// LinkUserWithInvitation
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> LinkUserWithInvitationAsync(
            global::G.LinkUserWithInvitationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// LinkUserWithInvitation<br/>
        /// LinkUserWithInvitation
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="projectId"></param>
        /// <param name="groupId"></param>
        /// <param name="invitationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> LinkUserWithInvitationAsync(
            global::System.Guid userId,
            global::System.Guid projectId,
            global::System.Guid groupId,
            global::System.Guid invitationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}