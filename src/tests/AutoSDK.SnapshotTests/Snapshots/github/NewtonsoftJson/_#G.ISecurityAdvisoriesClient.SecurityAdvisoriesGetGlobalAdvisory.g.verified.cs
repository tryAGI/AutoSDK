//HintName: G.ISecurityAdvisoriesClient.SecurityAdvisoriesGetGlobalAdvisory.g.cs
#nullable enable

namespace G
{
    public partial interface ISecurityAdvisoriesClient
    {
        /// <summary>
        /// Get a global security advisory<br/>
        /// Gets a global security advisory using its GitHub Security Advisory (GHSA) identifier.
        /// </summary>
        /// <param name="ghsaId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GlobalAdvisory> SecurityAdvisoriesGetGlobalAdvisoryAsync(
            string ghsaId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}