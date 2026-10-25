//HintName: G.ITtsClient.ConvertVoiceFile.g.cs
#nullable enable

namespace G
{
    public partial interface ITtsClient
    {
        /// <summary>
        /// Convert voice (file)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> ConvertVoiceFileAsync(

            global::G.ConvertVoiceJsonRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Convert voice (file)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> ConvertVoiceFileAsStreamAsync(

            global::G.ConvertVoiceJsonRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Convert voice (file)
        /// </summary>
        /// <param name="request"></param>
        /// <returns>The response metadata and an unbuffered body stream. The caller must dispose Body to release the HTTP response.</returns>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<global::System.IO.Stream>> ConvertVoiceFileAsStreamAsResponseAsync(

            global::G.ConvertVoiceJsonRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Convert voice (file)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<byte[]>> ConvertVoiceFileAsResponseAsync(

            global::G.ConvertVoiceJsonRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Convert voice (file)
        /// </summary>
        /// <param name="sourceAudio"></param>
        /// <param name="sourceVoiceId"></param>
        /// <param name="targetVoiceId"></param>
        /// <param name="targetVoiceName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> ConvertVoiceFileAsync(
            string? sourceAudio = default,
            string? sourceVoiceId = default,
            string? targetVoiceId = default,
            string? targetVoiceName = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}