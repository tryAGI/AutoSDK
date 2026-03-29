//HintName: G.IOrganizationsClient.OrganizationsGetOrganizationMemberships.g.cs
#nullable enable

namespace G
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Get all memberships for the organization associated with the API key (requires organization-scoped API key)
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MembershipsResponse> OrganizationsGetOrganizationMembershipsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}