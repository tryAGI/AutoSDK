//HintName: G.IAgentConfigsClient.CreateOrUpdateEnvs.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentConfigsClient
    {
        /// <summary>
        /// Create or update environments<br/>
        /// Creates or updates environment-to-blueprint mappings
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateOrUpdateEnvsAsync(

            global::G.AgentConfigEnvUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create or update environments<br/>
        /// Creates or updates environment-to-blueprint mappings
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="envs"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateOrUpdateEnvsAsync(
            global::System.Guid projectId,
            global::System.Collections.Generic.IList<global::G.AgentConfigEnv> envs,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}