//HintName: G.ITranslationClient.CreateTranslation.g.cs
#nullable enable

namespace G
{
    public partial interface ITranslationClient
    {
        /// <summary>
        /// Translate text<br/>
        /// Translate text from one language to another.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// curl --location --request POST https://api.writer.com/v1/translation \<br/>
        ///  --header "Authorization: Bearer &lt;token&gt;" \<br/>
        ///  --header "Content-Type: application/json" \<br/>
        /// --data-raw '{"model":"string","source_language_code":"string","target_language_code":"string","text":"string","formality":false,"length_control":false,"mask_profanity":false}'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.TranslationResponse> CreateTranslationAsync(

            global::G.TranslationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Translate text<br/>
        /// Translate text from one language to another.
        /// </summary>
        /// <param name="model">
        /// The model to use for translation.
        /// </param>
        /// <param name="sourceLanguageCode">
        /// The [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639_language_codes) language code of the original text to translate. For example, `en` for English, `zh` for Chinese, `fr` for French, `es` for Spanish. If the language has a variant, the code appends the two-digit [ISO-3166 country code](https://en.wikipedia.org/wiki/List_of_ISO_3166_country_codes). For example, Mexican Spanish is `es-MX`. See the [list of supported languages and language codes](https://dev.writer.com/api-reference/translation-api/language-support).
        /// </param>
        /// <param name="targetLanguageCode">
        /// The [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639_language_codes) language code of the target language for the translation. For example, `en` for English, `zh` for Chinese, `fr` for French, `es` for Spanish. If the language has a variant, the code appends the two-digit [ISO-3166 country code](https://en.wikipedia.org/wiki/List_of_ISO_3166_country_codes). For example, Mexican Spanish is `es-MX`. See the [list of supported languages and language codes](https://dev.writer.com/api-reference/translation-api/language-support).
        /// </param>
        /// <param name="text">
        /// The text to translate. Maximum of 100,000 words.
        /// </param>
        /// <param name="formality">
        /// Whether to use formal or informal language in the translation. See the [list of languages that support formality](https://dev.writer.com/api-reference/translation-api/language-support#formality). If the language does not support formality, this parameter is ignored.
        /// </param>
        /// <param name="lengthControl">
        /// Whether to control the length of the translated text. See the [list of languages that support length control](https://dev.writer.com/api-reference/translation-api/language-support#length-control). If the language does not support length control, this parameter is ignored.
        /// </param>
        /// <param name="maskProfanity">
        /// Whether to mask profane words in the translated text. See the [list of languages that do not support profanity masking](https://dev.writer.com/api-reference/translation-api/language-support#profanity-masking). If the language does not support profanity masking, this parameter is ignored.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TranslationResponse> CreateTranslationAsync(
            string sourceLanguageCode,
            string targetLanguageCode,
            string text,
            bool formality,
            bool lengthControl,
            bool maskProfanity,
            global::G.TranslationRequestModel model = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}