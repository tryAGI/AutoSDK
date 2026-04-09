//HintName: G.ITalksStreamsClient.DeleteStream.g.cs
#nullable enable

namespace G
{
    public partial interface ITalksStreamsClient
    {
        /// <summary>
        /// Delete a talk stream
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cookie"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.DeleteStreamResponse5> DeleteStreamAsync(
            string id,

            global::G.DeleteStreamRequest3 request,
            string? cookie = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a talk stream
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cookie"></param>
        /// <param name="sessionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.DeleteStreamResponse5> DeleteStreamAsync(
            string id,
            string? cookie = default,
            string? sessionId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}