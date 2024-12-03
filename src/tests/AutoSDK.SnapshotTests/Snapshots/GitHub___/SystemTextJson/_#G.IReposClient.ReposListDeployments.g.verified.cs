//HintName: G.IReposClient.ReposListDeployments.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// List deployments<br/>
        /// Simple filtering of deployments is available via query parameters:
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="sha">
        /// Default Value: none
        /// </param>
        /// <param name="ref">
        /// Default Value: none
        /// </param>
        /// <param name="task">
        /// Default Value: none
        /// </param>
        /// <param name="environment">
        /// Default Value: none
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Deployment>> ReposListDeploymentsAsync(
            string owner,
            string repo,
            string? sha = default,
            string? @ref = default,
            string? task = default,
            string? environment = default,
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}