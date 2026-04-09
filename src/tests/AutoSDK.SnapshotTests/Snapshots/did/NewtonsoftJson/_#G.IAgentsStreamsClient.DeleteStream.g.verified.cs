//HintName: G.IAgentsStreamsClient.DeleteStream.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsStreamsClient
    {
        /// <summary>
        /// Delete a video stream
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="streamId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteStreamResponse> DeleteStreamAsync(
            string agentId,
            string streamId,

            global::G.DeleteStreamRequest2 request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a video stream
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="streamId"></param>
        /// <param name="sessionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteStreamResponse> DeleteStreamAsync(
            string agentId,
            string streamId,
            string? sessionId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}