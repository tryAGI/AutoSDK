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
        [global::System.Text.Json.Serialization.JsonPropertyName("utterance_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UtteranceId { get; set; }

        /// <summary>
        /// The transcribed utterance
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("utterance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.UtteranceDTO Utterance { get; set; }

        /// <summary>
        /// The original language in `iso639-1` or `iso639-2` format depending on the language
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TranscriptionLanguageCodeEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TranscriptionLanguageCodeEnum OriginalLanguage { get; set; }

        /// <summary>
        /// The target language in `iso639-1` or `iso639-2` format depending on the language
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TranslationLanguageCodeEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TranslationLanguageCodeEnum TargetLanguage { get; set; }

        /// <summary>
        /// The translated utterance
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("translated_utterance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.UtteranceDTO TranslatedUtterance { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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