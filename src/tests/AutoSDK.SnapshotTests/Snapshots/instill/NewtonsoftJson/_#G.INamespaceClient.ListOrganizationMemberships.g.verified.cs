//HintName: G.INamespaceClient.ListOrganizationMemberships.g.cs
#nullable enable

namespace G
{
    public partial interface INamespaceClient
    {
        /// <summary>
        /// List organization memberships<br/>
        /// Returns a paginated list of the user memberships in an organization.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListOrganizationMembershipsResponse> ListOrganizationMembershipsAsync(
            string organizationId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}