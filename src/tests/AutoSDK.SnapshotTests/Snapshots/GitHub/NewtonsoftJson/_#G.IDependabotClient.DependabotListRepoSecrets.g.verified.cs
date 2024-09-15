//HintName: G.IDependabotClient.DependabotListRepoSecrets.g.cs
#nullable enable

namespace G
{
    public partial interface IDependabotClient
    {
        /// <summary>
        /// List repository secrets<br/>
        /// Lists all secrets available in a repository without revealing their encrypted<br/>
        /// values.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DependabotListRepoSecretsResponse> DependabotListRepoSecretsAsync(
            string owner,
            string repo,
            int perPage = 30,
            int page = 1,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}