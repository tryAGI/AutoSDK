//HintName: G.IApi.TranslateText.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Translate text between languages<br/>
        /// Translates text from one language to another. Supports 22+ Indian languages<br/>
        /// plus English with options for formal, colloquial, and code-mixed styles.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TranslateResponse> TranslateTextAsync(

            global::G.TranslateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Translate text between languages<br/>
        /// Translates text from one language to another. Supports 22+ Indian languages<br/>
        /// plus English with options for formal, colloquial, and code-mixed styles.
        /// </summary>
        /// <param name="input">
        /// Text to translate (max 1000 chars for mayura:v1, 2000 for sarvam-translate:v1)
        /// </param>
        /// <param name="sourceLanguageCode">
        /// Source language code (BCP-47) or "auto" for automatic detection with mayura:v1
        /// </param>
        /// <param name="targetLanguageCode">
        /// Target language code (BCP-47)
        /// </param>
        /// <param name="speakerGender">
        /// Gender of the speaker for better translations
        /// </param>
        /// <param name="mode">
        /// Tone or style of the translation<br/>
        /// Default Value: formal
        /// </param>
        /// <param name="model">
        /// Translation model to use
        /// </param>
        /// <param name="outputScript">
        /// Controls transliteration style applied to the output text
        /// </param>
        /// <param name="numeralsFormat">
        /// Format of numerals in the output<br/>
        /// Default Value: international
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TranslateResponse> TranslateTextAsync(
            string input,
            global::G.TranslateRequestSourceLanguageCode sourceLanguageCode,
            global::G.TranslateRequestTargetLanguageCode targetLanguageCode,
            global::G.TranslateRequestSpeakerGender? speakerGender = default,
            global::G.TranslateRequestMode? mode = default,
            global::G.TranslateRequestModel? model = default,
            global::G.TranslateRequestOutputScript? outputScript = default,
            global::G.TranslateRequestNumeralsFormat? numeralsFormat = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}