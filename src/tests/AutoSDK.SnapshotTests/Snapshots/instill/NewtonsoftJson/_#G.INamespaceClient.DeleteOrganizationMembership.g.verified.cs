//HintName: G.INamespaceClient.DeleteOrganizationMembership.g.cs
#nullable enable

namespace G
{
    public partial interface INamespaceClient
    {
        /// <summary>
        /// Delete an organization membership<br/>
        /// Deletes a user membership within an organization.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteOrganizationMembershipResponse> DeleteOrganizationMembershipAsync(
            string organizationId,
            string userId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}