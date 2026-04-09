//HintName: G.IOrganizationsClient.AddOrganizationMember.g.cs
#nullable enable

namespace G
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Add organization member<br/>
        /// Add a new member to a specific organization.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AddOrganizationMemberResponse> AddOrganizationMemberAsync(
            string orgId,

            global::G.AddOrganizationMemberRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add organization member<br/>
        /// Add a new member to a specific organization.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="email">
        /// Email of the member to be added.
        /// </param>
        /// <param name="role">
        /// Role of the member in the organization.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AddOrganizationMemberResponse> AddOrganizationMemberAsync(
            string orgId,
            string email,
            string role,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}