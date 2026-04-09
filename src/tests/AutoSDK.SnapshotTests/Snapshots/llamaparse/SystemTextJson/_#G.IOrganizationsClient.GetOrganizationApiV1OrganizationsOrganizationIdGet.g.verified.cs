//HintName: G.IOrganizationsClient.GetOrganizationApiV1OrganizationsOrganizationIdGet.g.cs
#nullable enable

namespace G
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Get Organization<br/>
        /// Get an organization by ID.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Organization> GetOrganizationApiV1OrganizationsOrganizationIdGetAsync(
            global::System.Guid organizationId,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}