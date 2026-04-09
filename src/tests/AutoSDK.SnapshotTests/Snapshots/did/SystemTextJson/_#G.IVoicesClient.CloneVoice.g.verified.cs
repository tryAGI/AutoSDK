//HintName: G.IVoicesClient.CloneVoice.g.cs
#nullable enable

namespace G
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Clone Voice<br/>
        /// Add a new voice to your collection of voices. Upload audio or video file to clone the voice from.<br/>
        /// For optimal voice cloning results, you should provide at least 30 seconds of diverse high-quality audio samples.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CloneVoiceResponse> CloneVoiceAsync(

            global::G.CloneVoiceRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Clone Voice<br/>
        /// Add a new voice to your collection of voices. Upload audio or video file to clone the voice from.<br/>
        /// For optimal voice cloning results, you should provide at least 30 seconds of diverse high-quality audio samples.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="language"></param>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="sourceUrl"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CloneVoiceResponse> CloneVoiceAsync(
            string name,
            string language,
            byte[]? file = default,
            string? filename = default,
            string? sourceUrl = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}