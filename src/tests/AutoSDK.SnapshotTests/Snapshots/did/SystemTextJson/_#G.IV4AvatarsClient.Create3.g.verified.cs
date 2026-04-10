//HintName: G.IV4AvatarsClient.Create3.g.cs
#nullable enable

namespace G
{
    public partial interface IV4AvatarsClient
    {
        /// <summary>
        /// Create a Video
        /// </summary>
        /// <param name="xApiKeyExternal"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AllOf<global::G.Create3ResponseVariant1, global::G.Create3ResponseVariant2>> Create3Async(

            global::G.Create3Request request,
            string? xApiKeyExternal = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Video
        /// </summary>
        /// <param name="xApiKeyExternal"></param>
        /// <param name="name">
        /// The name of the video<br/>
        /// Example: my_expressive_video
        /// </param>
        /// <param name="avatarId">
        /// The id of the avatar of the video<br/>
        /// Example: public_dan@abcefg
        /// </param>
        /// <param name="sentimentId">
        /// The chosen sentiment id of the video<br/>
        /// Example: snt_IIjpTS
        /// </param>
        /// <param name="config"></param>
        /// <param name="background"></param>
        /// <param name="userData"></param>
        /// <param name="persist"></param>
        /// <param name="resultUrl">
        /// The result url of the video. Cannot be provided together with config.result_format.<br/>
        /// Example: https://example.com/result.mp4
        /// </param>
        /// <param name="webhook"></param>
        /// <param name="script"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AllOf<global::G.Create3ResponseVariant1, global::G.Create3ResponseVariant2>> Create3Async(
            string avatarId,
            global::G.AnyOf<global::G.Create3RequestScriptVariant1, global::G.Create3RequestScriptVariant2> script,
            string? xApiKeyExternal = default,
            string? name = default,
            string? sentimentId = default,
            global::G.Create3RequestConfig? config = default,
            global::G.AnyOf<global::G.Create3RequestBackgroundVariant1, global::G.Create3RequestBackgroundVariant2>? background = default,
            string? userData = default,
            bool? persist = default,
            string? resultUrl = default,
            string? webhook = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}