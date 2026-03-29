//HintName: G.IAgentsClient.AgentsGetCall.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Get Call
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="callId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AgentCall> AgentsGetCallAsync(
            global::G.AgentsGetCallCartesiaVersion cartesiaVersion,
            string callId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}