//HintName: G.ITalksStandardAvatarsClient.CreateTalk.g.cs
#nullable enable

namespace G
{
    public partial interface ITalksStandardAvatarsClient
    {
        /// <summary>
        /// Create a talk
        /// </summary>
        /// <param name="xApiKeyExternal"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateTalkResponse> CreateTalkAsync(

            global::G.CreateTalkRequest2 request,
            string? xApiKeyExternal = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a talk
        /// </summary>
        /// <param name="xApiKeyExternal"></param>
        /// <param name="sourceUrl">
        /// The URL of the source image to be animated by the driver video, or a selection from the list of provided<br/>
        /// studio actors.<br/>
        /// Default Value: https://d-id-public-bucket.s3.us-west-2.amazonaws.com/alice.jpg<br/>
        /// Example: https://path.to.directory/image.jpg
        /// </param>
        /// <param name="script"></param>
        /// <param name="config">
        /// Advanced configuration options
        /// </param>
        /// <param name="userData">
        /// Non-sensitive custom data that will be added to the talk response and webhook
        /// </param>
        /// <param name="name">
        /// The name of the talk video
        /// </param>
        /// <param name="webhook">
        /// A webhook URL for sending the payload including animate details<br/>
        /// In a case of empty value, the webhook will not be triggered<br/>
        /// Example: https://host.domain.tld/to/webhook
        /// </param>
        /// <param name="resultUrl">
        /// The URL of the talk video, if not provided use default destination.<br/>
        /// Example: https://path.to.directory/
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateTalkResponse> CreateTalkAsync(
            global::G.AnyOf<global::G.CreateTalkRequestScriptVariant12, global::G.CreateTalkRequestScriptVariant22> script,
            string? xApiKeyExternal = default,
            string? sourceUrl = default,
            global::G.CreateTalkRequestConfig2? config = default,
            string? userData = default,
            string? name = default,
            string? webhook = default,
            string? resultUrl = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}