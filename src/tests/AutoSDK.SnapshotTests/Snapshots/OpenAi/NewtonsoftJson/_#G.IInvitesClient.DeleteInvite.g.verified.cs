//HintName: G.IInvitesClient.DeleteInvite.g.cs
#nullable enable

namespace G
{
    public partial interface IInvitesClient
    {
        /// <summary>
        /// Delete an invite. If the invite has already been accepted, it cannot be deleted.
        /// </summary>
        /// <param name="inviteId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.InviteDeleteResponse> DeleteInviteAsync(
            string inviteId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}