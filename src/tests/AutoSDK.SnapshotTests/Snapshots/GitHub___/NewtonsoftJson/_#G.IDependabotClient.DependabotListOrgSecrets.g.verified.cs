//HintName: G.IDependabotClient.DependabotListOrgSecrets.g.cs
#nullable enable

namespace G
{
    public partial interface IDependabotClient
    {
        /// <summary>
        /// List organization secrets<br/>
        /// Lists all secrets available in an organization without revealing their<br/>
        /// encrypted values.<br/>
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
        global::System.Threading.Tasks.Task<global::G.DependabotListOrgSecretsResponse> DependabotListOrgSecretsAsync(
            string org,
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}