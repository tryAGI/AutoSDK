//HintName: G.IMembershipClient.DeleteOrganizationMembership.g.cs
#nullable enable

namespace G
{
    public partial interface IMembershipClient
    {
        /// <summary>
        /// Delete an organization membership<br/>
        /// Deletes a user membership within an organization.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteOrganizationMembershipResponse> DeleteOrganizationMembershipAsync(
            string organizationId,
            string userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}