//HintName: G.IAgentsStreamsClient.CreateVideoStream.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsStreamsClient
    {
        /// <summary>
        /// Create a video stream
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="streamId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AllOf<global::G.CreateVideoStreamResponseVariant12, global::G.CreateVideoStreamResponseVariant22>> CreateVideoStreamAsync(
            string agentId,
            string streamId,

            global::G.CreateVideoStreamRequest2 request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a video stream
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="streamId"></param>
        /// <param name="sessionId"></param>
        /// <param name="script"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AllOf<global::G.CreateVideoStreamResponseVariant12, global::G.CreateVideoStreamResponseVariant22>> CreateVideoStreamAsync(
            string agentId,
            string streamId,
            global::G.AnyOf<global::G.CreateVideoStreamRequestScriptText2, global::G.CreateVideoStreamRequestScriptAudio2> script,
            string? sessionId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}