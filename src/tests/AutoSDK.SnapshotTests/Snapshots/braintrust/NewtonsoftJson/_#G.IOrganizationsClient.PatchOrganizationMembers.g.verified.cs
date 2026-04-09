//HintName: G.IOrganizationsClient.PatchOrganizationMembers.g.cs
#nullable enable

namespace G
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Modify organization membership<br/>
        /// Modify organization membership
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PatchOrganizationMembersOutput> PatchOrganizationMembersAsync(

            global::G.PatchOrganizationMembers request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Modify organization membership<br/>
        /// Modify organization membership
        /// </summary>
        /// <param name="inviteUsers">
        /// Users to invite to the organization
        /// </param>
        /// <param name="removeUsers">
        /// Users to remove from the organization
        /// </param>
        /// <param name="orgName">
        /// For nearly all users, this parameter should be unnecessary. But in the rare case that your API key belongs to multiple organizations, or in case you want to explicitly assert the organization you are modifying, you may specify the name of the organization.
        /// </param>
        /// <param name="orgId">
        /// For nearly all users, this parameter should be unnecessary. But in the rare case that your API key belongs to multiple organizations, or in case you want to explicitly assert the organization you are modifying, you may specify the id of the organization.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PatchOrganizationMembersOutput> PatchOrganizationMembersAsync(
            global::G.PatchOrganizationMembersInviteUsers? inviteUsers = default,
            global::G.PatchOrganizationMembersRemoveUsers? removeUsers = default,
            string? orgName = default,
            string? orgId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}