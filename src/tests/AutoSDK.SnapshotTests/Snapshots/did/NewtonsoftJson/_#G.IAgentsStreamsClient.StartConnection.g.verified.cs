//HintName: G.IAgentsStreamsClient.StartConnection.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsStreamsClient
    {
        /// <summary>
        /// Start a WebRTC connection<br/>
        /// Updates the server with the SDP answer to the SDP offer received from the initial call to the `/agents/{agentId}/streams` endpoint, during the offer/answer negotiation of a WebRTC connection.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="streamId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.StartConnectionResponse> StartConnectionAsync(
            string agentId,
            string streamId,

            global::G.StartConnectionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start a WebRTC connection<br/>
        /// Updates the server with the SDP answer to the SDP offer received from the initial call to the `/agents/{agentId}/streams` endpoint, during the offer/answer negotiation of a WebRTC connection.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="streamId"></param>
        /// <param name="sessionId">
        /// Session identifier information, should be returned in the body of all streaming requests (from the response<br/>
        /// of the POST /streams)
        /// </param>
        /// <param name="answer">
        /// Jsep answer object used to create a peer connection
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.StartConnectionResponse> StartConnectionAsync(
            string agentId,
            string streamId,
            global::G.StartConnectionRequestAnswer answer,
            string? sessionId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}