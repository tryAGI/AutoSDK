//HintName: G.IClipsPremiumAvatarsClient.CreateClip.g.cs
#nullable enable

namespace G
{
    public partial interface IClipsPremiumAvatarsClient
    {
        /// <summary>
        /// Create a clip
        /// </summary>
        /// <param name="xApiKeyExternal"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateClipResponse> CreateClipAsync(

            global::G.CreateClipRequest request,
            string? xApiKeyExternal = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a clip
        /// </summary>
        /// <param name="xApiKeyExternal"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<global::G.CreateClipResponse>> CreateClipAsResponseAsync(

            global::G.CreateClipRequest request,
            string? xApiKeyExternal = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a clip
        /// </summary>
        /// <param name="xApiKeyExternal"></param>
        /// <param name="presenterId">
        /// a selection from the list or provided driver ids.<br/>
        /// Default Value: jack-Pt27VkP3hW<br/>
        /// Example: jack-Pt27VkP3hW
        /// </param>
        /// <param name="driverId">
        /// a selection from the list or provided driver ids.<br/>
        /// If not provided a driver video will be selected for you from the predefined drivers bank.<br/>
        /// Example: Vcq0R4a8F0
        /// </param>
        /// <param name="script"></param>
        /// <param name="config">
        /// Advanced configuration options.
        /// </param>
        /// <param name="presenterConfig">
        /// Advanced presenter configuration options.
        /// </param>
        /// <param name="background">
        /// Background color of the clip result
        /// </param>
        /// <param name="userData">
        /// Non-sensitive custom data that will be added to the clip response and webhook.
        /// </param>
        /// <param name="name">
        /// The name of the clip
        /// </param>
        /// <param name="webhook">
        /// A webhook URL for sending the payload including animate details.<br/>
        /// In a case of empty value, the webhook will not be triggered.<br/>
        /// Example: https://host.domain.tld/to/webhook
        /// </param>
        /// <param name="resultUrl">
        /// The URL of the clip video, if not provided use default destination.<br/>
        /// Example: https://path.to.directory/
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateClipResponse> CreateClipAsync(
            global::G.AnyOf<global::G.CreateClipRequestScriptVariant1, global::G.CreateClipRequestScriptVariant2> script,
            string? xApiKeyExternal = default,
            string? presenterId = default,
            string? driverId = default,
            global::G.CreateClipRequestConfig? config = default,
            global::G.CreateClipRequestPresenterConfig? presenterConfig = default,
            global::G.CreateClipRequestBackground? background = default,
            string? userData = default,
            string? name = default,
            string? webhook = default,
            string? resultUrl = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}