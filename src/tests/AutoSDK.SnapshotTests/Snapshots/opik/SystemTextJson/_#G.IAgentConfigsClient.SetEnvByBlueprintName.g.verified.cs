//HintName: G.IAgentConfigsClient.SetEnvByBlueprintName.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentConfigsClient
    {
        /// <summary>
        /// Set environment by blueprint name<br/>
        /// Sets an environment to point to a blueprint identified by name
        /// </summary>
        /// <param name="envName"></param>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task SetEnvByBlueprintNameAsync(
            string envName,
            global::System.Guid projectId,

            global::G.AgentConfigEnvSetByName request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set environment by blueprint name<br/>
        /// Sets an environment to point to a blueprint identified by name
        /// </summary>
        /// <param name="envName"></param>
        /// <param name="projectId"></param>
        /// <param name="blueprintName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task SetEnvByBlueprintNameAsync(
            string envName,
            global::System.Guid projectId,
            string blueprintName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}