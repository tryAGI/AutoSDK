//HintName: G.IReposClient.ReposListDeploymentStatuses.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// List deployment statuses<br/>
        /// Users with pull access can view deployment statuses for a deployment:
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="deploymentId"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.DeploymentStatus>> ReposListDeploymentStatusesAsync(
            string owner,
            string repo,
            int deploymentId,
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}