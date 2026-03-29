//HintName: G.IApi.TransliterateText.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Transliterate text between scripts<br/>
        /// Converts text from one script to another while maintaining the same language.<br/>
        /// Supports transliteration between Indic scripts and Roman script.<br/>
        /// Max 1000 characters per request.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TransliterateResponse> TransliterateTextAsync(

            global::G.TransliterateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Transliterate text between scripts<br/>
        /// Converts text from one script to another while maintaining the same language.<br/>
        /// Supports transliteration between Indic scripts and Roman script.<br/>
        /// Max 1000 characters per request.
        /// </summary>
        /// <param name="input">
        /// Text to transliterate (max 1000 characters)
        /// </param>
        /// <param name="sourceLanguageCode">
        /// Source language code (BCP-47) or "auto"
        /// </param>
        /// <param name="targetLanguageCode">
        /// Target language code (BCP-47)
        /// </param>
        /// <param name="numeralsFormat">
        /// Format of numerals in the output<br/>
        /// Default Value: international
        /// </param>
        /// <param name="spokenForm">
        /// Whether to convert text into a natural spoken form<br/>
        /// Default Value: false
        /// </param>
        /// <param name="spokenFormNumeralsLanguage">
        /// Language for spoken form numerals (only applies when spoken_form is true)<br/>
        /// Default Value: native
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TransliterateResponse> TransliterateTextAsync(
            string input,
            global::G.TransliterateRequestSourceLanguageCode sourceLanguageCode,
            global::G.TransliterateRequestTargetLanguageCode targetLanguageCode,
            global::G.TransliterateRequestNumeralsFormat? numeralsFormat = default,
            bool? spokenForm = default,
            global::G.TransliterateRequestSpokenFormNumeralsLanguage? spokenFormNumeralsLanguage = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}