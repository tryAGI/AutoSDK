//HintName: G.IDependabotClient.DependabotListSelectedReposForOrgSecret.g.cs
#nullable enable

namespace G
{
    public partial interface IDependabotClient
    {
        /// <summary>
        /// List selected repositories for an organization secret<br/>
        /// Lists all repositories that have been selected when the `visibility`<br/>
        /// for repository access to a secret is set to `selected`.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="secretName"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DependabotListSelectedReposForOrgSecretResponse> DependabotListSelectedReposForOrgSecretAsync(
            string org,
            string secretName,
            int? page = default,
            int? perPage = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}