//HintName: G.Models.TranslationFunction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A tool that uses Palmyra Translate to translate text.
    /// </summary>
    public sealed partial class TranslationFunction
    {
        /// <summary>
        /// The model to use for translation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TranslationFunctionModelJsonConverter))]
        public global::G.TranslationFunctionModel Model { get; set; }

        /// <summary>
        /// Optional. The [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639_language_codes) language code of the original text to translate. For example, `en` for English, `zh` for Chinese, `fr` for French, `es` for Spanish. If the language has a variant, the code appends the two-digit [ISO-3166 country code](https://en.wikipedia.org/wiki/List_of_ISO_3166_country_codes). If you do not provide a language code, the LLM detects the language of the text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_language_code")]
        public string? SourceLanguageCode { get; set; }

        /// <summary>
        /// Optional. The [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639_language_codes) language code of the target language for the translation. For example, `en` for English, `zh` for Chinese, `fr` for French, `es` for Spanish. If the language has a variant, the code appends the two-digit [ISO-3166 country code](https://en.wikipedia.org/wiki/List_of_ISO_3166_country_codes). If you do not provide a language code, the LLM uses the content of the chat message to determine the target language.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_language_code")]
        public string? TargetLanguageCode { get; set; }

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
        /// Initializes a new instance of the <see cref="TranslationFunction" /> class.
        /// </summary>
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
        /// <param name="sourceLanguageCode">
        /// Optional. The [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639_language_codes) language code of the original text to translate. For example, `en` for English, `zh` for Chinese, `fr` for French, `es` for Spanish. If the language has a variant, the code appends the two-digit [ISO-3166 country code](https://en.wikipedia.org/wiki/List_of_ISO_3166_country_codes). If you do not provide a language code, the LLM detects the language of the text.
        /// </param>
        /// <param name="targetLanguageCode">
        /// Optional. The [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639_language_codes) language code of the target language for the translation. For example, `en` for English, `zh` for Chinese, `fr` for French, `es` for Spanish. If the language has a variant, the code appends the two-digit [ISO-3166 country code](https://en.wikipedia.org/wiki/List_of_ISO_3166_country_codes). If you do not provide a language code, the LLM uses the content of the chat message to determine the target language.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranslationFunction(
            bool formality,
            bool lengthControl,
            bool maskProfanity,
            global::G.TranslationFunctionModel model,
            string? sourceLanguageCode,
            string? targetLanguageCode)
        {
            this.Model = model;
            this.SourceLanguageCode = sourceLanguageCode;
            this.TargetLanguageCode = targetLanguageCode;
            this.Formality = formality;
            this.LengthControl = lengthControl;
            this.MaskProfanity = maskProfanity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationFunction" /> class.
        /// </summary>
        public TranslationFunction()
        {
        }
    }
}