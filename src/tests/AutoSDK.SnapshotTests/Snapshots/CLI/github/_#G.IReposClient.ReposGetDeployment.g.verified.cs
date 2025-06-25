//HintName: G.IReposClient.ReposGetDeployment.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Get a deployment
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="deploymentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Deployment> ReposGetDeploymentAsync(
            string owner,
            string repo,
            int deploymentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}