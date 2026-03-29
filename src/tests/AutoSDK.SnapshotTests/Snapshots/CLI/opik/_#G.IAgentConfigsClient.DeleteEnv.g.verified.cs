//HintName: G.IAgentConfigsClient.DeleteEnv.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentConfigsClient
    {
        /// <summary>
        /// Delete environment<br/>
        /// Soft-deletes an environment by setting its ended_at timestamp
        /// </summary>
        /// <param name="envName"></param>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteEnvAsync(
            string envName,
            global::System.Guid projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}