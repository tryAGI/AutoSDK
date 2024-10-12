//HintName: G.IOrgsClient.DeletePendingOrganizationInvite.g.cs
#nullable enable

namespace G
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Delete Pending Organization Invite
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> DeletePendingOrganizationInviteAsync(
            global::System.Guid organizationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}