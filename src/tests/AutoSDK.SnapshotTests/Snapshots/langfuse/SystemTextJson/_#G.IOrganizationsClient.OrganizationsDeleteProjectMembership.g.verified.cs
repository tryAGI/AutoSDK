//HintName: G.IOrganizationsClient.OrganizationsDeleteProjectMembership.g.cs
#nullable enable

namespace G
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Delete a membership from a specific project (requires organization-scoped API key). The user must be a member of the organization.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MembershipDeletionResponse> OrganizationsDeleteProjectMembershipAsync(
            string projectId,

            global::G.DeleteMembershipRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a membership from a specific project (requires organization-scoped API key). The user must be a member of the organization.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.MembershipDeletionResponse> OrganizationsDeleteProjectMembershipAsync(
            string projectId,
            string userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}