//HintName: G.INamespaceClient.GetOrganizationMembership.g.cs
#nullable enable

namespace G
{
    public partial interface INamespaceClient
    {
        /// <summary>
        /// Get a an organization membership<br/>
        /// Returns the details of a user membership within an organization.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="userId"></param>
        /// <param name="view"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetOrganizationMembershipResponse> GetOrganizationMembershipAsync(
            string organizationId,
            string userId,
            global::G.GetOrganizationMembershipView? view = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}