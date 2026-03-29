//HintName: G.IBetaClient.UpdateAgentDataApiV1BetaAgentDataItemIdPut.g.cs
#nullable enable

namespace G
{
    public partial interface IBetaClient
    {
        /// <summary>
        /// Update Agent Data<br/>
        /// Update agent data by ID (overwrites).
        /// </summary>
        /// <param name="itemId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AgentData> UpdateAgentDataApiV1BetaAgentDataItemIdPutAsync(
            string itemId,

            global::G.AgentDataUpdate request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Agent Data<br/>
        /// Update agent data by ID (overwrites).
        /// </summary>
        /// <param name="itemId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AgentData> UpdateAgentDataApiV1BetaAgentDataItemIdPutAsync(
            string itemId,
            object data,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}