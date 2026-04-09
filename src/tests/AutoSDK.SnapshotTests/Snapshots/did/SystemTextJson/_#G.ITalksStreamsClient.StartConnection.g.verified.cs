//HintName: G.ITalksStreamsClient.StartConnection.g.cs
#nullable enable

namespace G
{
    public partial interface ITalksStreamsClient
    {
        /// <summary>
        /// Start a WebRTC connection<br/>
        /// Updates the server with the SDP answer to the SDP offer received from the initial call to the `/streams` endpoint, during the offer/answer negotiation of a WebRTC connection.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cookie"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.StartConnectionResponse4> StartConnectionAsync(
            string id,

            global::G.StartConnectionRequest2 request,
            string? cookie = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start a WebRTC connection<br/>
        /// Updates the server with the SDP answer to the SDP offer received from the initial call to the `/streams` endpoint, during the offer/answer negotiation of a WebRTC connection.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cookie"></param>
        /// <param name="sessionId">
        /// Session identifier information, should be returned in the body of all streaming requests (from the response<br/>
        /// of the POST /streams)
        /// </param>
        /// <param name="answer">
        /// Jsep answer object used to create a peer connection
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.StartConnectionResponse4> StartConnectionAsync(
            string id,
            global::G.StartConnectionRequestAnswer2 answer,
            string? cookie = default,
            string? sessionId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}