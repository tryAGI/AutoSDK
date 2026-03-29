//HintName: G.IFeedsClient.FeedsSubscribeAgent.g.cs
#nullable enable

namespace G
{
    public partial interface IFeedsClient
    {
        /// <summary>
        /// Subscribe Agent to Feed<br/>
        /// Subscribe an agent to a feed with polling configuration
        /// </summary>
        /// <param name="feedId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FeedsSubscribeAgentResponse> FeedsSubscribeAgentAsync(
            string feedId,

            global::G.FeedsSubscribeAgentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Subscribe Agent to Feed<br/>
        /// Subscribe an agent to a feed with polling configuration
        /// </summary>
        /// <param name="feedId"></param>
        /// <param name="agentId"></param>
        /// <param name="cronSchedule"></param>
        /// <param name="promptTemplate"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FeedsSubscribeAgentResponse> FeedsSubscribeAgentAsync(
            string feedId,
            string agentId,
            string cronSchedule,
            string? promptTemplate = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}