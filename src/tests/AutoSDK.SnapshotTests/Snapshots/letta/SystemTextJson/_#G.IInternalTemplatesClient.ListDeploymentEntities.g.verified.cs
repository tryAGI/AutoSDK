//HintName: G.IInternalTemplatesClient.ListDeploymentEntities.g.cs
#nullable enable

namespace G
{
    public partial interface IInternalTemplatesClient
    {
        /// <summary>
        /// List Deployment Entities<br/>
        /// List all entities (blocks, agents, groups) with the specified deployment_id.<br/>
        /// Optionally filter by entity types.
        /// </summary>
        /// <param name="deploymentId"></param>
        /// <param name="entityTypes">
        /// Filter by entity types (block, agent, group)
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListDeploymentEntitiesResponse> ListDeploymentEntitiesAsync(
            string deploymentId,
            global::System.Collections.Generic.IList<string>? entityTypes = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}