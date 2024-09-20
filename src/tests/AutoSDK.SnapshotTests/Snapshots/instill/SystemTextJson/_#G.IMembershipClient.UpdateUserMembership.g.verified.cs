//HintName: G.IMembershipClient.UpdateUserMembership.g.cs
#nullable enable

namespace G
{
    public partial interface IMembershipClient
    {
        /// <summary>
        /// Update a user membership<br/>
        /// Accesses and updates a user membership by parent and membership IDs.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="organizationId"></param>
        /// <param name="updateMask"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateUserMembershipResponse> UpdateUserMembershipAsync(
            string userId,
            string organizationId,
            string updateMask,
            global::G.UserMembership request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a user membership<br/>
        /// Accesses and updates a user membership by parent and membership IDs.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="organizationId"></param>
        /// <param name="updateMask"></param>
        /// <param name="name">
        /// The resource name of the membership, which allows its access by user and<br/>
        /// organization ID.<br/>
        /// - Format: `users/{user.id}/memberships/{organization.id}`.
        /// </param>
        /// <param name="role">
        /// Role of the user in the organization.
        /// </param>
        /// <param name="organization">
        /// Organizations group several users. As entities, they can own resources such<br/>
        /// as pipelines or releases.
        /// </param>
        /// <param name="user">
        /// User describes an individual that interacts with Instill AI. It doesn't<br/>
        /// contain any private information about the user.
        /// </param>
        /// <param name="state">
        /// MembershipState describes the state of a user membership to an organization.<br/>
        ///  - MEMBERSHIP_STATE_ACTIVE: Active.<br/>
        ///  - MEMBERSHIP_STATE_PENDING: Pending, i.e., a request has been sent to the user to join an<br/>
        /// organization.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateUserMembershipResponse> UpdateUserMembershipAsync(
            string userId,
            string organizationId,
            string updateMask,
            global::G.MembershipState state,
            string? name = default,
            string? role = default,
            global::G.Organization? organization = default,
            global::G.User? user = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}