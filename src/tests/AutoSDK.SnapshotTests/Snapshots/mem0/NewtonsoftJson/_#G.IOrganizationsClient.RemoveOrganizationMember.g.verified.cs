//HintName: G.IOrganizationsClient.RemoveOrganizationMember.g.cs
#nullable enable

namespace G
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Remove a member from the organization
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RemoveOrganizationMemberResponse> RemoveOrganizationMemberAsync(
            string orgId,

            global::G.RemoveOrganizationMemberRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove a member from the organization
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="email">
        /// Email of the member to be removed.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.RemoveOrganizationMemberResponse> RemoveOrganizationMemberAsync(
            string orgId,
            string email,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}