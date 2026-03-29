//HintName: G.IApi.GetAgent.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Retrieve details of a specific agent
        /// </summary>
        /// <param name="agentId">
        /// Example: 16b980523634a6dc504898cda492e939
        /// </param>
        /// <param name="version">
        /// Example: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AgentResponse> GetAgentAsync(
            string agentId,
            int? version = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}