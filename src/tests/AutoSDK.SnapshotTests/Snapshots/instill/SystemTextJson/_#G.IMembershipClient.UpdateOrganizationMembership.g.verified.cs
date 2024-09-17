//HintName: G.IMembershipClient.UpdateOrganizationMembership.g.cs
#nullable enable

namespace G
{
    public partial interface IMembershipClient
    {
        /// <summary>
        /// Uppdate an organization membership<br/>
        /// Updates a user membership within an organization.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="userId"></param>
        /// <param name="updateMask"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateOrganizationMembershipResponse> UpdateOrganizationMembershipAsync(
            string organizationId,
            string userId,
            string updateMask,
            global::G.OrganizationMembership request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Uppdate an organization membership<br/>
        /// Updates a user membership within an organization.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="userId"></param>
        /// <param name="updateMask"></param>
        /// <param name="name">
        /// The resource name of the membership, which allows its access by<br/>
        /// organization and user ID.<br/>
        /// - Format: `organizations/{organization.id}/memberships/{user.id}`.
        /// </param>
        /// <param name="role">
        /// Role of the user in the organization.
        /// </param>
        /// <param name="state">
        /// State of the membership.
        /// </param>
        /// <param name="user">
        /// User information.
        /// </param>
        /// <param name="organization">
        /// Organization information.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateOrganizationMembershipResponse> UpdateOrganizationMembershipAsync(
            string organizationId,
            string userId,
            string updateMask,
            string role,
            string? name = default,
            global::G.AllOf<global::G.MembershipState?>? state = default,
            global::G.AllOf<global::G.User9>? user = default,
            global::G.AllOf<global::G.Organization7>? organization = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}