//HintName: G.IClipsStreamsClient.StartConnection1.g.cs
#nullable enable

namespace G
{
    public partial interface IClipsStreamsClient
    {
        /// <summary>
        /// Start a WebRTC connection<br/>
        /// Updates the server with the SDP answer to the SDP offer received from the initial call to the `/streams` endpoint, during the offer/answer negotiation of a WebRTC connection.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.StartConnection1Response> StartConnection1Async(
            string id,

            global::G.StartConnection1Request request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start a WebRTC connection<br/>
        /// Updates the server with the SDP answer to the SDP offer received from the initial call to the `/streams` endpoint, during the offer/answer negotiation of a WebRTC connection.
        /// </summary>
        /// <param name="id"></param>
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
        global::System.Threading.Tasks.Task<global::G.StartConnection1Response> StartConnection1Async(
            string id,
            global::G.StartConnection1RequestAnswer answer,
            string? sessionId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}