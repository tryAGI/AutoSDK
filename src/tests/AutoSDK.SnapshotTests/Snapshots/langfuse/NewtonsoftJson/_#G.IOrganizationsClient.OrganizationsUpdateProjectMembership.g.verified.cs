//HintName: G.IOrganizationsClient.OrganizationsUpdateProjectMembership.g.cs
#nullable enable

namespace G
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Create or update a membership for a specific project (requires organization-scoped API key). The user must already be a member of the organization.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MembershipResponse> OrganizationsUpdateProjectMembershipAsync(
            string projectId,

            global::G.MembershipRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create or update a membership for a specific project (requires organization-scoped API key). The user must already be a member of the organization.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="role"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.MembershipResponse> OrganizationsUpdateProjectMembershipAsync(
            string projectId,
            string userId,
            global::G.MembershipRole role,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}