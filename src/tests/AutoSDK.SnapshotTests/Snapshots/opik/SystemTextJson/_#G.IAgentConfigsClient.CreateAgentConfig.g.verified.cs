//HintName: G.IAgentConfigsClient.CreateAgentConfig.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentConfigsClient
    {
        /// <summary>
        /// Create optimizer config with initial blueprint<br/>
        /// Creates a new optimizer config with initial blueprint. Fails if the project already has a config.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateAgentConfigAsync(

            global::G.AgentConfigCreateWrite request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create optimizer config with initial blueprint<br/>
        /// Creates a new optimizer config with initial blueprint. Fails if the project already has a config.
        /// </summary>
        /// <param name="projectId">
        /// Project ID. Either project_id or project_name must be provided
        /// </param>
        /// <param name="projectName">
        /// Project name. Either project_id or project_name must be provided
        /// </param>
        /// <param name="id">
        /// Agent config ID. Generated automatically if not provided
        /// </param>
        /// <param name="blueprint"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateAgentConfigAsync(
            global::G.AgentBlueprintWrite blueprint,
            global::System.Guid? projectId = default,
            string? projectName = default,
            global::System.Guid? id = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}