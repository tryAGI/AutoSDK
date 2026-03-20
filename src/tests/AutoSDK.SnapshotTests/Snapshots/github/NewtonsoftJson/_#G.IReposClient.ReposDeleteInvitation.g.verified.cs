//HintName: G.IReposClient.ReposDeleteInvitation.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Delete a repository invitation
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="invitationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task ReposDeleteInvitationAsync(
            string owner,
            string repo,
            int invitationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}