//HintName: G.IAgentsClient.AgentsGetDeployment.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Get Deployment<br/>
        /// Get a deployment by its ID.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="deploymentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Deployment> AgentsGetDeploymentAsync(
            global::G.AgentsGetDeploymentCartesiaVersion cartesiaVersion,
            string deploymentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}