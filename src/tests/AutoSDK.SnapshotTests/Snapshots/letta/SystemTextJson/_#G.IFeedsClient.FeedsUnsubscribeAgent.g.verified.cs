//HintName: G.IFeedsClient.FeedsUnsubscribeAgent.g.cs
#nullable enable

namespace G
{
    public partial interface IFeedsClient
    {
        /// <summary>
        /// Unsubscribe Agent from Feed<br/>
        /// Remove agent subscription from a feed (by agent_id)
        /// </summary>
        /// <param name="feedId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FeedsUnsubscribeAgentResponse> FeedsUnsubscribeAgentAsync(
            string feedId,

            global::G.FeedsUnsubscribeAgentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Unsubscribe Agent from Feed<br/>
        /// Remove agent subscription from a feed (by agent_id)
        /// </summary>
        /// <param name="feedId"></param>
        /// <param name="agentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FeedsUnsubscribeAgentResponse> FeedsUnsubscribeAgentAsync(
            string feedId,
            string agentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}