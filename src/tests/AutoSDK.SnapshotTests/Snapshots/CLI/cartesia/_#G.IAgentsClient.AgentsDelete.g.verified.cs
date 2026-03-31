//HintName: G.IAgentsClient.AgentsDelete.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Delete Agent
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="agentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task AgentsDeleteAsync(
            global::G.AgentsDeleteCartesiaVersion cartesiaVersion,
            string agentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}