//HintName: G.ITranslationClient.Translate.g.cs
#nullable enable

namespace G
{
    public partial interface ITranslationClient
    {
        /// <summary>
        /// Translate text<br/>
        /// Translates text between languages using Solar translation models.<br/>
        /// Supports English-Korean (solar-1-mini-translate-enko) and other language pairs.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TranslationResponse> TranslateAsync(

            global::G.TranslationRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Translate text<br/>
        /// Translates text between languages using Solar translation models.<br/>
        /// Supports English-Korean (solar-1-mini-translate-enko) and other language pairs.
        /// </summary>
        /// <param name="model">
        /// The model to use for translation.<br/>
        /// Default: solar-1-mini-translate-enko<br/>
        /// Example: solar-1-mini-translate-enko
        /// </param>
        /// <param name="text">
        /// The text to translate.
        /// </param>
        /// <param name="sourceLang">
        /// Source language code (e.g., en, ko, ja).
        /// </param>
        /// <param name="targetLang">
        /// Target language code (e.g., en, ko, ja).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TranslationResponse> TranslateAsync(
            string model,
            string text,
            string sourceLang,
            string targetLang,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}