//HintName: G.IOrganizationsClient.UpdateOrganizationMemberRole.g.cs
#nullable enable

namespace G
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Update organization member role<br/>
        /// Update the role of an existing member in a specific organization.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateOrganizationMemberRoleResponse> UpdateOrganizationMemberRoleAsync(
            string orgId,

            global::G.UpdateOrganizationMemberRoleRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update organization member role<br/>
        /// Update the role of an existing member in a specific organization.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="email">
        /// Email of the member whose role is to be updated.
        /// </param>
        /// <param name="role">
        /// New role of the member in the organization
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateOrganizationMemberRoleResponse> UpdateOrganizationMemberRoleAsync(
            string orgId,
            string email,
            string role,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}