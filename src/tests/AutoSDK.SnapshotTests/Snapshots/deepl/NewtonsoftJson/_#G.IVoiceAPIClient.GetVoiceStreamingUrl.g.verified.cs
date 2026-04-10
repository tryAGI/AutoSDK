//HintName: G.IVoiceAPIClient.GetVoiceStreamingUrl.g.cs
#nullable enable

namespace G
{
    public partial interface IVoiceAPIClient
    {
        /// <summary>
        /// Get Streaming URL
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.VoiceStreamingResponse> GetVoiceStreamingUrlAsync(

            global::G.GetVoiceStreamingUrlRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Streaming URL
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<global::G.VoiceStreamingResponse>> GetVoiceStreamingUrlAsResponseAsync(

            global::G.GetVoiceStreamingUrlRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Streaming URL
        /// </summary>
        /// <param name="sourceMediaContentType">
        /// The audio format for streaming. Specifies container, codec, and encoding parameters.<br/>
        /// Supported formats include PCM (recommended), OPUS (recommended for low bandwidth), FLAC, MP3, and AAC.<br/>
        /// PCM formats require explicit sample rate. Mono audio only.<br/>
        /// Example: audio/ogg; codecs=opus
        /// </param>
        /// <param name="sourceLanguage">
        /// Source language of the audio stream. Must be one of the supported Voice API source languages.<br/>
        /// Language identifier must comply with IETF BCP 47 language tags.<br/>
        /// Example: en
        /// </param>
        /// <param name="sourceLanguageMode">
        /// Controls how the source_language value is used.<br/>
        /// - `auto`: Treats source language as a hint; server can override<br/>
        /// - `fixed`: Treats source language as mandatory; server must use this language<br/>
        /// Default Value: auto<br/>
        /// Example: auto
        /// </param>
        /// <param name="targetLanguages">
        /// List of target languages for translation. The stream will emit translations for each language.<br/>
        /// Maximum 5 target languages per stream. Language identifiers must comply with IETF BCP 47.<br/>
        /// Example: [de, fr, es]
        /// </param>
        /// <param name="glossaryId">
        /// A unique ID assigned to a glossary.<br/>
        /// Example: def3a26b-3e84-45b3-84ae-0c0aaf3525f7
        /// </param>
        /// <param name="formality">
        /// Sets whether the translated text should lean towards formal or informal language.<br/>
        /// Possible options are:<br/>
        ///   * `default` - use the default formality for the target language<br/>
        ///   * `formal`/`more` - for a more formal language<br/>
        ///   * `informal`/`less` - for a more informal language<br/>
        /// Default Value: default<br/>
        /// Example: formal
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.VoiceStreamingResponse> GetVoiceStreamingUrlAsync(
            global::G.VoiceMediaContentType sourceMediaContentType,
            global::G.VoiceSourceLanguage? sourceLanguage = default,
            global::G.VoiceSourceLanguageMode? sourceLanguageMode = default,
            global::System.Collections.Generic.IList<string>? targetLanguages = default,
            string? glossaryId = default,
            global::G.VoiceFormality? formality = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}