//HintName: G.IDependabotClient.DependabotDeleteOrgSecret.g.cs
#nullable enable

namespace G
{
    public partial interface IDependabotClient
    {
        /// <summary>
        /// Delete an organization secret<br/>
        /// Deletes a secret in an organization using the secret name.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="secretName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DependabotDeleteOrgSecretAsync(
            string org,
            string secretName,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}