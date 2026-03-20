//HintName: G.IOrgsClient.ClaimPendingOrganizationInvite.g.cs
#nullable enable

namespace G
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Claim Pending Organization Invite
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Identity> ClaimPendingOrganizationInviteAsync(
            global::System.Guid organizationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}