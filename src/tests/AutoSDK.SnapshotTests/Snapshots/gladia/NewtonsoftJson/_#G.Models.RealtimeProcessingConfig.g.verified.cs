//HintName: G.Models.RealtimeProcessingConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RealtimeProcessingConfig
    {
        /// <summary>
        /// If true, enable custom vocabulary for the transcription.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_vocabulary")]
        public bool? CustomVocabulary { get; set; }

        /// <summary>
        /// Custom vocabulary configuration, if `custom_vocabulary` is enabled
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_vocabulary_config")]
        public global::G.CustomVocabularyConfigDTO? CustomVocabularyConfig { get; set; }

        /// <summary>
        /// If true, enable custom spelling for the transcription.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_spelling")]
        public bool? CustomSpelling { get; set; }

        /// <summary>
        /// Custom spelling configuration, if `custom_spelling` is enabled
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_spelling_config")]
        public global::G.CustomSpellingConfigDTO? CustomSpellingConfig { get; set; }

        /// <summary>
        /// If true, enable translation for the transcription<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("translation")]
        public bool? Translation { get; set; }

        /// <summary>
        /// Translation configuration, if `translation` is enabled
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("translation_config")]
        public global::G.TranslationConfigDTO? TranslationConfig { get; set; }

        /// <summary>
        /// If true, enable named entity recognition for the transcription.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("named_entity_recognition")]
        public bool? NamedEntityRecognition { get; set; }

        /// <summary>
        /// If true, enable sentiment analysis for the transcription.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sentiment_analysis")]
        public bool? SentimentAnalysis { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeProcessingConfig" /> class.
        /// </summary>
        /// <param name="customVocabulary">
        /// If true, enable custom vocabulary for the transcription.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="customVocabularyConfig">
        /// Custom vocabulary configuration, if `custom_vocabulary` is enabled
        /// </param>
        /// <param name="customSpelling">
        /// If true, enable custom spelling for the transcription.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="customSpellingConfig">
        /// Custom spelling configuration, if `custom_spelling` is enabled
        /// </param>
        /// <param name="translation">
        /// If true, enable translation for the transcription<br/>
        /// Default Value: false
        /// </param>
        /// <param name="translationConfig">
        /// Translation configuration, if `translation` is enabled
        /// </param>
        /// <param name="namedEntityRecognition">
        /// If true, enable named entity recognition for the transcription.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="sentimentAnalysis">
        /// If true, enable sentiment analysis for the transcription.<br/>
        /// Default Value: false
        /// </param>
        public RealtimeProcessingConfig(
            bool? customVocabulary,
            global::G.CustomVocabularyConfigDTO? customVocabularyConfig,
            bool? customSpelling,
            global::G.CustomSpellingConfigDTO? customSpellingConfig,
            bool? translation,
            global::G.TranslationConfigDTO? translationConfig,
            bool? namedEntityRecognition,
            bool? sentimentAnalysis)
        {
            this.CustomVocabulary = customVocabulary;
            this.CustomVocabularyConfig = customVocabularyConfig;
            this.CustomSpelling = customSpelling;
            this.CustomSpellingConfig = customSpellingConfig;
            this.Translation = translation;
            this.TranslationConfig = translationConfig;
            this.NamedEntityRecognition = namedEntityRecognition;
            this.SentimentAnalysis = sentimentAnalysis;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeProcessingConfig" /> class.
        /// </summary>
        public RealtimeProcessingConfig()
        {
        }
    }
}