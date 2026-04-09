//HintName: G.IVideoTranslateClient.Create.g.cs
#nullable enable

namespace G
{
    public partial interface IVideoTranslateClient
    {
        /// <summary>
        /// Create a Video Translate
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateResponse> CreateAsync(

            global::G.CreateRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Video Translate
        /// </summary>
        /// <param name="sourceUrl">
        /// The URL of the source video to be translated.<br/>
        /// Example: https://path.to.directory/movie.mp4
        /// </param>
        /// <param name="languages">
        /// The languages into which the video will be translated. Supported languages: Arabic, Bulgarian, Chinese, Croatian, Czech, Danish, Dutch, English, Filipino, Finnish, French, German, Greek,<br/>
        ///                      Hindi, Indonesian, Italian, Japanese, Korean, Malay, Polish, Portuguese, Romanian, Russian, Slovak, Spanish,<br/>
        ///                      Swedish, Tamil, Turkish and Ukrainian.
        /// </param>
        /// <param name="sourceLanguage">
        /// The language spoken in the original video uploaded. Using this feature might help mitigate STT errors. Supported languages: Arabic, Bulgarian, Chinese, Croatian, Czech, Danish, Dutch, English, Filipino, Finnish, French, German, Greek,<br/>
        ///                      Hindi, Indonesian, Italian, Japanese, Korean, Malay, Polish, Portuguese, Romanian, Russian, Slovak, Spanish,<br/>
        ///                      Swedish, Tamil, Turkish and Ukrainian.
        /// </param>
        /// <param name="webhook">
        /// A webhook URL for sending the payload including animate details<br/>
        /// In a case of empty value, the webhook will not be triggered<br/>
        /// Example: https://host.domain.tld/to/webhook
        /// </param>
        /// <param name="userData">
        /// Non-sensitive custom data that will be added to the translation response and webhook.
        /// </param>
        /// <param name="resultUrl">
        /// The result url of the video, if not provided use default destination. supports s3 signed urls.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateResponse> CreateAsync(
            string sourceUrl,
            global::System.Collections.Generic.IList<string> languages,
            string? sourceLanguage = default,
            string? webhook = default,
            string? userData = default,
            string? resultUrl = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}