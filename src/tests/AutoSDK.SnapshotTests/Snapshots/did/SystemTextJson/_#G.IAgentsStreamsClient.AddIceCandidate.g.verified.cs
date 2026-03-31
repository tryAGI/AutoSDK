//HintName: G.IAgentsStreamsClient.AddIceCandidate.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsStreamsClient
    {
        /// <summary>
        /// Submit network information<br/>
        /// Updates the server with a WebRTC ICE candidate. If the candidate parameter is missing or a value of null is given the added ICE candidate is an "end-of-candidates" indicator.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="streamId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AddIceCandidateResponse> AddIceCandidateAsync(
            string agentId,
            string streamId,

            global::G.AllOf<global::G.AnyOf<global::G.AddIceCandidateRequestVariant12, object>?, global::G.AddIceCandidateRequest2> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit network information<br/>
        /// Updates the server with a WebRTC ICE candidate. If the candidate parameter is missing or a value of null is given the added ICE candidate is an "end-of-candidates" indicator.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="streamId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AddIceCandidateResponse> AddIceCandidateAsync(
            string agentId,
            string streamId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}