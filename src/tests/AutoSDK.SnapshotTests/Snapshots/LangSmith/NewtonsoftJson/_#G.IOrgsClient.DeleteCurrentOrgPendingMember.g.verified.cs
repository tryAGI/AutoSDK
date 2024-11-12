//HintName: G.IOrgsClient.DeleteCurrentOrgPendingMember.g.cs
#nullable enable

namespace G
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Delete Current Org Pending Member<br/>
        /// When an admin deletes a pending member invite.
        /// </summary>
        /// <param name="identityId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteCurrentOrgPendingMemberAsync(
            global::System.Guid identityId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}