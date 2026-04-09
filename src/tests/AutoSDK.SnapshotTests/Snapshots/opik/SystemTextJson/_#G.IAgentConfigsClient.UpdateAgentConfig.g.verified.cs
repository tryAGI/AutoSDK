//HintName: G.IAgentConfigsClient.UpdateAgentConfig.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentConfigsClient
    {
        /// <summary>
        /// Add blueprint to existing config<br/>
        /// Adds a new blueprint to an existing optimizer config. Fails if the project has no config yet.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task UpdateAgentConfigAsync(

            global::G.AgentConfigCreateWrite request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add blueprint to existing config<br/>
        /// Adds a new blueprint to an existing optimizer config. Fails if the project has no config yet.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task UpdateAgentConfigAsync(
            global::G.AgentBlueprintWrite blueprint,
            global::System.Guid? projectId = default,
            string? projectName = default,
            global::System.Guid? id = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}