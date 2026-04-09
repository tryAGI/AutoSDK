//HintName: G.IOrganizationManagementClient.GetOrgConsumerConnectedToolkits.g.cs
#nullable enable

namespace G
{
    public partial interface IOrganizationManagementClient
    {
        /// <summary>
        /// List active connected toolkits for a consumer user<br/>
        /// Resolves the organization's single CONSUMER project and returns the distinct toolkit slugs for which the specified consumer user has an ACTIVE connection.
        /// </summary>
        /// <param name="userId">
        /// Consumer user ID to inspect within the consumer project.
        /// </param>
        /// <param name="xUserApiKey">
        /// User API key used to authenticate the request.<br/>
        /// Example: uak_abc123xyz456...
        /// </param>
        /// <param name="xOrgId">
        /// Organization nano ID that owns the consumer project.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetOrgConsumerConnectedToolkitsResponse> GetOrgConsumerConnectedToolkitsAsync(
            string userId,
            string xUserApiKey,
            string xOrgId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}