//HintName: G.IAgentConfigsClient.GetBlueprintById.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentConfigsClient
    {
        /// <summary>
        /// Retrieve blueprint by ID<br/>
        /// Retrieves a specific blueprint by its ID
        /// </summary>
        /// <param name="blueprintId"></param>
        /// <param name="maskId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AgentBlueprintPublic> GetBlueprintByIdAsync(
            global::System.Guid blueprintId,
            global::System.Guid? maskId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}