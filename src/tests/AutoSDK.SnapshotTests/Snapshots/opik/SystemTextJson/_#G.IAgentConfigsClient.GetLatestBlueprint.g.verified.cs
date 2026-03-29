//HintName: G.IAgentConfigsClient.GetLatestBlueprint.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentConfigsClient
    {
        /// <summary>
        /// Retrieve latest blueprint<br/>
        /// Retrieves the latest blueprint for a project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="maskId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AgentBlueprintPublic> GetLatestBlueprintAsync(
            global::System.Guid projectId,
            global::System.Guid? maskId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}