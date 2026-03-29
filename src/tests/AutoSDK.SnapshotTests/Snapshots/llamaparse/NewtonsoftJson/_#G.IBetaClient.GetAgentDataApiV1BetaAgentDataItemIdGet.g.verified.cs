//HintName: G.IBetaClient.GetAgentDataApiV1BetaAgentDataItemIdGet.g.cs
#nullable enable

namespace G
{
    public partial interface IBetaClient
    {
        /// <summary>
        /// Get Agent Data<br/>
        /// Get agent data by ID.
        /// </summary>
        /// <param name="itemId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AgentData> GetAgentDataApiV1BetaAgentDataItemIdGetAsync(
            string itemId,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}