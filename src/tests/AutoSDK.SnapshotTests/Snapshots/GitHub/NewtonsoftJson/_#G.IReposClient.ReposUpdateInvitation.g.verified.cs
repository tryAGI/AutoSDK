//HintName: G.IReposClient.ReposUpdateInvitation.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Update a repository invitation
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="invitationId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RepositoryInvitation> ReposUpdateInvitationAsync(
            string owner,
            string repo,
            int invitationId,
            global::G.ReposUpdateInvitationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a repository invitation
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="invitationId"></param>
        /// <param name="permissions">
        /// The permissions that the associated user will have on the repository. Valid values are `read`, `write`, `maintain`, `triage`, and `admin`.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.RepositoryInvitation> ReposUpdateInvitationAsync(
            string owner,
            string repo,
            int invitationId,
            global::G.ReposUpdateInvitationRequestPermissions? permissions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}