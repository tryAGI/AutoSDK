//HintName: G.IOrganizationsClient.OrganizationsDeleteOrganizationMembership.g.cs
#nullable enable

namespace G
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Delete a membership from the organization associated with the API key (requires organization-scoped API key)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MembershipDeletionResponse> OrganizationsDeleteOrganizationMembershipAsync(

            global::G.DeleteMembershipRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a membership from the organization associated with the API key (requires organization-scoped API key)
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.MembershipDeletionResponse> OrganizationsDeleteOrganizationMembershipAsync(
            string userId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}