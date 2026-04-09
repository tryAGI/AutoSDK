//HintName: G.IDependabotClient.DependabotGetOrgSecret.g.cs
#nullable enable

namespace G
{
    public partial interface IDependabotClient
    {
        /// <summary>
        /// Get an organization secret<br/>
        /// Gets a single organization secret without revealing its encrypted value.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="secretName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OrganizationDependabotSecret> DependabotGetOrgSecretAsync(
            string org,
            string secretName,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}