//HintName: G.Models.RecognitionMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Summary information about the output from an ASR job, comprising the job type and configuration parameters used when generating the output.
    /// </summary>
    public sealed partial class RecognitionMetadata
    {
        /// <summary>
        /// The UTC date time the transcription output was created.<br/>
        /// Example: 2018-01-09 12:29:01.853047+00:00
        /// </summary>
        /// <example>2018-01-09 12:29:01.853047+00:00</example>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.JobTypeJsonConverter))]
        public global::G.JobType Type { get; set; } = default!;

        /// <summary>
        /// Example: {"language":"en","output_locale":"en-GB","additional_vocab":[{"content":"Speechmatics","sounds_like":["speechmatics"]},{"content":"gnocchi","sounds_like":["nyohki","nokey","nochi"]},{"content":"CEO","sounds_like":["C.E.O."]},{"content":"financial crisis"}],"diarization":"channel","channel_diarization_labels":["Caller","Agent"]}
        /// </summary>
        /// <example>{"language":"en","output_locale":"en-GB","additional_vocab":[{"content":"Speechmatics","sounds_like":["speechmatics"]},{"content":"gnocchi","sounds_like":["nyohki","nokey","nochi"]},{"content":"CEO","sounds_like":["C.E.O."]},{"content":"financial crisis"}],"diarization":"channel","channel_diarization_labels":["Caller","Agent"]}</example>
        [global::Newtonsoft.Json.JsonProperty("transcription_config")]
        public global::G.TranscriptionConfig? TranscriptionConfig { get; set; }

        /// <summary>
        /// The engine version used to generate transcription output.<br/>
        /// Example: 2025.11.07+cd4ff775c0+14.7.0
        /// </summary>
        /// <example>2025.11.07+cd4ff775c0+14.7.0</example>
        [global::Newtonsoft.Json.JsonProperty("orchestrator_version")]
        public string? OrchestratorVersion { get; set; }

        /// <summary>
        /// List of errors that occurred in the translation stage.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("translation_errors")]
        public global::System.Collections.Generic.IList<global::G.TranslationError>? TranslationErrors { get; set; }

        /// <summary>
        /// List of errors that occurred in the summarization stage.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summarization_errors")]
        public global::System.Collections.Generic.IList<global::G.SummarizationError>? SummarizationErrors { get; set; }

        /// <summary>
        /// List of errors that occurred in the sentiment analysis stage.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sentiment_analysis_errors")]
        public global::System.Collections.Generic.IList<global::G.SentimentAnalysisError>? SentimentAnalysisErrors { get; set; }

        /// <summary>
        /// List of errors that occurred in the topic detection stage.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("topic_detection_errors")]
        public global::System.Collections.Generic.IList<global::G.TopicDetectionError>? TopicDetectionErrors { get; set; }

        /// <summary>
        /// List of errors that occurred in the auto chapters stage.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auto_chapters_errors")]
        public global::System.Collections.Generic.IList<global::G.AutoChaptersResultError>? AutoChaptersErrors { get; set; }

        /// <summary>
        /// Example: {"language":"en"}
        /// </summary>
        /// <example>{"language":"en"}</example>
        [global::Newtonsoft.Json.JsonProperty("alignment_config")]
        public global::G.AlignmentConfig? AlignmentConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_config")]
        public global::G.OutputConfig? OutputConfig { get; set; }

        /// <summary>
        /// Properties of the language pack.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language_pack_info")]
        public global::G.LanguagePackInfo? LanguagePackInfo { get; set; }

        /// <summary>
        /// Example: {"results":[{"alternatives":[{"language":"en","confidence":0.98},{"language":"fr","confidence":0.02}],"start_time":0,"end_time":5.5},{"alternatives":[{"language":"en","confidence":0.95},{"language":"fr","confidence":0.05}],"start_time":5.6,"end_time":10}]}
        /// </summary>
        /// <example>{"results":[{"alternatives":[{"language":"en","confidence":0.98},{"language":"fr","confidence":0.02}],"start_time":0,"end_time":5.5},{"alternatives":[{"language":"en","confidence":0.95},{"language":"fr","confidence":0.05}],"start_time":5.6,"end_time":10}]}</example>
        [global::Newtonsoft.Json.JsonProperty("language_identification")]
        public global::G.LanguageIdentificationResult? LanguageIdentification { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RecognitionMetadata" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// The UTC date time the transcription output was created.<br/>
        /// Example: 2018-01-09 12:29:01.853047+00:00
        /// </param>
        /// <param name="type"></param>
        /// <param name="transcriptionConfig">
        /// Example: {"language":"en","output_locale":"en-GB","additional_vocab":[{"content":"Speechmatics","sounds_like":["speechmatics"]},{"content":"gnocchi","sounds_like":["nyohki","nokey","nochi"]},{"content":"CEO","sounds_like":["C.E.O."]},{"content":"financial crisis"}],"diarization":"channel","channel_diarization_labels":["Caller","Agent"]}
        /// </param>
        /// <param name="orchestratorVersion">
        /// The engine version used to generate transcription output.<br/>
        /// Example: 2025.11.07+cd4ff775c0+14.7.0
        /// </param>
        /// <param name="translationErrors">
        /// List of errors that occurred in the translation stage.
        /// </param>
        /// <param name="summarizationErrors">
        /// List of errors that occurred in the summarization stage.
        /// </param>
        /// <param name="sentimentAnalysisErrors">
        /// List of errors that occurred in the sentiment analysis stage.
        /// </param>
        /// <param name="topicDetectionErrors">
        /// List of errors that occurred in the topic detection stage.
        /// </param>
        /// <param name="autoChaptersErrors">
        /// List of errors that occurred in the auto chapters stage.
        /// </param>
        /// <param name="alignmentConfig">
        /// Example: {"language":"en"}
        /// </param>
        /// <param name="outputConfig"></param>
        /// <param name="languagePackInfo">
        /// Properties of the language pack.
        /// </param>
        /// <param name="languageIdentification">
        /// Example: {"results":[{"alternatives":[{"language":"en","confidence":0.98},{"language":"fr","confidence":0.02}],"start_time":0,"end_time":5.5},{"alternatives":[{"language":"en","confidence":0.95},{"language":"fr","confidence":0.05}],"start_time":5.6,"end_time":10}]}
        /// </param>
        public RecognitionMetadata(
            global::System.DateTime createdAt,
            global::G.JobType type,
            global::G.TranscriptionConfig? transcriptionConfig,
            string? orchestratorVersion,
            global::System.Collections.Generic.IList<global::G.TranslationError>? translationErrors,
            global::System.Collections.Generic.IList<global::G.SummarizationError>? summarizationErrors,
            global::System.Collections.Generic.IList<global::G.SentimentAnalysisError>? sentimentAnalysisErrors,
            global::System.Collections.Generic.IList<global::G.TopicDetectionError>? topicDetectionErrors,
            global::System.Collections.Generic.IList<global::G.AutoChaptersResultError>? autoChaptersErrors,
            global::G.AlignmentConfig? alignmentConfig,
            global::G.OutputConfig? outputConfig,
            global::G.LanguagePackInfo? languagePackInfo,
            global::G.LanguageIdentificationResult? languageIdentification)
        {
            this.CreatedAt = createdAt;
            this.Type = type;
            this.TranscriptionConfig = transcriptionConfig;
            this.OrchestratorVersion = orchestratorVersion;
            this.TranslationErrors = translationErrors;
            this.SummarizationErrors = summarizationErrors;
            this.SentimentAnalysisErrors = sentimentAnalysisErrors;
            this.TopicDetectionErrors = topicDetectionErrors;
            this.AutoChaptersErrors = autoChaptersErrors;
            this.AlignmentConfig = alignmentConfig;
            this.OutputConfig = outputConfig;
            this.LanguagePackInfo = languagePackInfo;
            this.LanguageIdentification = languageIdentification;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecognitionMetadata" /> class.
        /// </summary>
        public RecognitionMetadata()
        {
        }
    }
}