//HintName: G.Models.TranslationRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranslationRequest
    {
        /// <summary>
        /// The model to use for translation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TranslationRequestModelJsonConverter))]
        public global::G.TranslationRequestModel Model { get; set; }

        /// <summary>
        /// The [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639_language_codes) language code of the original text to translate. For example, `en` for English, `zh` for Chinese, `fr` for French, `es` for Spanish. If the language has a variant, the code appends the two-digit [ISO-3166 country code](https://en.wikipedia.org/wiki/List_of_ISO_3166_country_codes). For example, Mexican Spanish is `es-MX`. See the [list of supported languages and language codes](https://dev.writer.com/api-reference/translation-api/language-support).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_language_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceLanguageCode { get; set; }

        /// <summary>
        /// The [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639_language_codes) language code of the target language for the translation. For example, `en` for English, `zh` for Chinese, `fr` for French, `es` for Spanish. If the language has a variant, the code appends the two-digit [ISO-3166 country code](https://en.wikipedia.org/wiki/List_of_ISO_3166_country_codes). For example, Mexican Spanish is `es-MX`. See the [list of supported languages and language codes](https://dev.writer.com/api-reference/translation-api/language-support).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_language_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetLanguageCode { get; set; }

        /// <summary>
        /// The text to translate. Maximum of 100,000 words.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Whether to use formal or informal language in the translation. See the [list of languages that support formality](https://dev.writer.com/api-reference/translation-api/language-support#formality). If the language does not support formality, this parameter is ignored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("formality")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Formality { get; set; }

        /// <summary>
        /// Whether to control the length of the translated text. See the [list of languages that support length control](https://dev.writer.com/api-reference/translation-api/language-support#length-control). If the language does not support length control, this parameter is ignored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("length_control")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool LengthControl { get; set; }

        /// <summary>
        /// Whether to mask profane words in the translated text. See the [list of languages that do not support profanity masking](https://dev.writer.com/api-reference/translation-api/language-support#profanity-masking). If the language does not support profanity masking, this parameter is ignored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask_profanity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool MaskProfanity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationRequest" /> class.
        /// </summary>
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
        /// <param name="model">
        /// The model to use for translation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranslationRequest(
            string sourceLanguageCode,
            string targetLanguageCode,
            string text,
            bool formality,
            bool lengthControl,
            bool maskProfanity,
            global::G.TranslationRequestModel model)
        {
            this.Model = model;
            this.SourceLanguageCode = sourceLanguageCode ?? throw new global::System.ArgumentNullException(nameof(sourceLanguageCode));
            this.TargetLanguageCode = targetLanguageCode ?? throw new global::System.ArgumentNullException(nameof(targetLanguageCode));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Formality = formality;
            this.LengthControl = lengthControl;
            this.MaskProfanity = maskProfanity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationRequest" /> class.
        /// </summary>
        public TranslationRequest()
        {
        }
    }
}