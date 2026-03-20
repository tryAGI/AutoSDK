//HintName: G.ICodespacesClient.CodespacesGetOrgSecret.g.cs
#nullable enable

namespace G
{
    public partial interface ICodespacesClient
    {
        /// <summary>
        /// Get an organization secret<br/>
        /// Gets an organization development environment secret without revealing its encrypted value.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="secretName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CodespacesOrgSecret> CodespacesGetOrgSecretAsync(
            string org,
            string secretName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}