//HintName: G.INamespaceClient.DeleteOrganization.g.cs
#nullable enable

namespace G
{
    public partial interface INamespaceClient
    {
        /// <summary>
        /// Delete an organization<br/>
        /// Accesses and deletes an organization by ID.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteOrganizationResponse> DeleteOrganizationAsync(
            string organizationId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}