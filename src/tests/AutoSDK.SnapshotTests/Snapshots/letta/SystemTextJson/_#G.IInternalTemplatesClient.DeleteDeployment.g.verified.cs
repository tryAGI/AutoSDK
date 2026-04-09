//HintName: G.IInternalTemplatesClient.DeleteDeployment.g.cs
#nullable enable

namespace G
{
    public partial interface IInternalTemplatesClient
    {
        /// <summary>
        /// Delete Deployment<br/>
        /// Delete all entities (blocks, agents, groups) with the specified deployment_id.<br/>
        /// Deletion order: blocks -&gt; agents -&gt; groups to maintain referential integrity.
        /// </summary>
        /// <param name="deploymentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteDeploymentResponse> DeleteDeploymentAsync(
            string deploymentId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}