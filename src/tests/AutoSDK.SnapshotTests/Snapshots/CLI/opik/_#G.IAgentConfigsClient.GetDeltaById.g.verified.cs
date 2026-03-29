//HintName: G.IAgentConfigsClient.GetDeltaById.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentConfigsClient
    {
        /// <summary>
        /// Retrieve delta by blueprint ID<br/>
        /// Retrieves only the changes (delta) introduced in a specific blueprint
        /// </summary>
        /// <param name="blueprintId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AgentBlueprintPublic> GetDeltaByIdAsync(
            global::System.Guid blueprintId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}