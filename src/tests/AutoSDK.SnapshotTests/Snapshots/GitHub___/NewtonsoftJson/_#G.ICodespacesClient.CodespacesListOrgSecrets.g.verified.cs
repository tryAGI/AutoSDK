//HintName: G.ICodespacesClient.CodespacesListOrgSecrets.g.cs
#nullable enable

namespace G
{
    public partial interface ICodespacesClient
    {
        /// <summary>
        /// List organization secrets<br/>
        /// Lists all Codespaces development environment secrets available at the organization-level without revealing their encrypted<br/>
        /// values.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CodespacesListOrgSecretsResponse> CodespacesListOrgSecretsAsync(
            string org,
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}