//HintName: G.Models.TranslationData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranslationData
    {
        /// <summary>
        /// Id of the utterance used for this result<br/>
        /// Example: 00-00000011
        /// </summary>
        /// <example>00-00000011</example>
        [global::Newtonsoft.Json.JsonProperty("utterance_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string UtteranceId { get; set; } = default!;

        /// <summary>
        /// The transcribed utterance
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("utterance", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.UtteranceDTO Utterance { get; set; } = default!;

        /// <summary>
        /// The original language in `iso639-1` or `iso639-2` format depending on the language
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("original_language", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TranscriptionLanguageCodeEnumJsonConverter))]
        public global::G.TranscriptionLanguageCodeEnum OriginalLanguage { get; set; } = default!;

        /// <summary>
        /// The target language in `iso639-1` or `iso639-2` format depending on the language
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target_language", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TranslationLanguageCodeEnumJsonConverter))]
        public global::G.TranslationLanguageCodeEnum TargetLanguage { get; set; } = default!;

        /// <summary>
        /// The translated utterance
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("translated_utterance", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.UtteranceDTO TranslatedUtterance { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationData" /> class.
        /// </summary>
        /// <param name="utteranceId">
        /// Id of the utterance used for this result<br/>
        /// Example: 00-00000011
        /// </param>
        /// <param name="utterance">
        /// The transcribed utterance
        /// </param>
        /// <param name="originalLanguage">
        /// The original language in `iso639-1` or `iso639-2` format depending on the language
        /// </param>
        /// <param name="targetLanguage">
        /// The target language in `iso639-1` or `iso639-2` format depending on the language
        /// </param>
        /// <param name="translatedUtterance">
        /// The translated utterance
        /// </param>
        public TranslationData(
            string utteranceId,
            global::G.UtteranceDTO utterance,
            global::G.TranscriptionLanguageCodeEnum originalLanguage,
            global::G.TranslationLanguageCodeEnum targetLanguage,
            global::G.UtteranceDTO translatedUtterance)
        {
            this.UtteranceId = utteranceId ?? throw new global::System.ArgumentNullException(nameof(utteranceId));
            this.Utterance = utterance ?? throw new global::System.ArgumentNullException(nameof(utterance));
            this.OriginalLanguage = originalLanguage;
            this.TargetLanguage = targetLanguage;
            this.TranslatedUtterance = translatedUtterance ?? throw new global::System.ArgumentNullException(nameof(translatedUtterance));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationData" /> class.
        /// </summary>
        public TranslationData()
        {
        }
    }
}