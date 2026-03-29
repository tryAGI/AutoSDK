//HintName: G.Models.JobConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// JSON object that contains various groups of job configuration<br/>
    /// parameters. Based on the value of `type`, a type-specific object<br/>
    /// such as `transcription_config` is required to be present to<br/>
    /// specify all configuration settings or parameters needed to<br/>
    /// process the job inputs as expected.<br/>
    /// If the results of the job are to be forwarded on completion,<br/>
    /// `notification_config` can be provided with a list of callbacks<br/>
    /// to be made; no assumptions should be made about the order in<br/>
    /// which they will occur.<br/>
    /// Customer specific job details or metadata can be supplied in<br/>
    /// `tracking`, and this information will be available where<br/>
    /// possible in the job results and in callbacks.
    /// </summary>
    public sealed partial class JobConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.JobType Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fetch_data")]
        public global::G.DataFetchConfig? FetchData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fetch_text")]
        public global::G.DataFetchConfig? FetchText { get; set; }

        /// <summary>
        /// Example: {"language":"en"}
        /// </summary>
        /// <example>{"language":"en"}</example>
        [global::Newtonsoft.Json.JsonProperty("alignment_config")]
        public global::G.AlignmentConfig? AlignmentConfig { get; set; }

        /// <summary>
        /// Example: {"language":"en","output_locale":"en-GB","additional_vocab":[{"content":"Speechmatics","sounds_like":["speechmatics"]},{"content":"gnocchi","sounds_like":["nyohki","nokey","nochi"]},{"content":"CEO","sounds_like":["C.E.O."]},{"content":"financial crisis"}],"diarization":"channel","channel_diarization_labels":["Caller","Agent"]}
        /// </summary>
        /// <example>{"language":"en","output_locale":"en-GB","additional_vocab":[{"content":"Speechmatics","sounds_like":["speechmatics"]},{"content":"gnocchi","sounds_like":["nyohki","nokey","nochi"]},{"content":"CEO","sounds_like":["C.E.O."]},{"content":"financial crisis"}],"diarization":"channel","channel_diarization_labels":["Caller","Agent"]}</example>
        [global::Newtonsoft.Json.JsonProperty("transcription_config")]
        public global::G.TranscriptionConfig? TranscriptionConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("notification_config")]
        public global::System.Collections.Generic.IList<global::G.NotificationConfig>? NotificationConfig { get; set; }

        /// <summary>
        /// Example: {"title":"ACME Q12018 Earnings Call","reference":"/data/clients/ACME/statements/segs/2018Q1-seg8","tags":["quick-review","segment"],"details":{"client":"ACME Corp","segment":8,"seg_start":963.201,"seg_end":1091.481}}
        /// </summary>
        /// <example>{"title":"ACME Q12018 Earnings Call","reference":"/data/clients/ACME/statements/segs/2018Q1-seg8","tags":["quick-review","segment"],"details":{"client":"ACME Corp","segment":8,"seg_start":963.201,"seg_end":1091.481}}</example>
        [global::Newtonsoft.Json.JsonProperty("tracking")]
        public global::G.TrackingData? Tracking { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_config")]
        public global::G.OutputConfig? OutputConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("translation_config")]
        public global::G.TranslationConfig? TranslationConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language_identification_config")]
        public global::G.LanguageIdentificationConfig? LanguageIdentificationConfig { get; set; }

        /// <summary>
        /// Configuration options for summarization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summarization_config")]
        public global::G.SummarizationConfig? SummarizationConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sentiment_analysis_config")]
        public global::G.SentimentAnalysisConfig? SentimentAnalysisConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("topic_detection_config")]
        public global::G.TopicDetectionConfig? TopicDetectionConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auto_chapters_config")]
        public global::G.AutoChaptersConfig? AutoChaptersConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_events_config")]
        public global::G.AudioEventsConfig? AudioEventsConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JobConfig" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="fetchData"></param>
        /// <param name="fetchText"></param>
        /// <param name="alignmentConfig">
        /// Example: {"language":"en"}
        /// </param>
        /// <param name="transcriptionConfig">
        /// Example: {"language":"en","output_locale":"en-GB","additional_vocab":[{"content":"Speechmatics","sounds_like":["speechmatics"]},{"content":"gnocchi","sounds_like":["nyohki","nokey","nochi"]},{"content":"CEO","sounds_like":["C.E.O."]},{"content":"financial crisis"}],"diarization":"channel","channel_diarization_labels":["Caller","Agent"]}
        /// </param>
        /// <param name="notificationConfig"></param>
        /// <param name="tracking">
        /// Example: {"title":"ACME Q12018 Earnings Call","reference":"/data/clients/ACME/statements/segs/2018Q1-seg8","tags":["quick-review","segment"],"details":{"client":"ACME Corp","segment":8,"seg_start":963.201,"seg_end":1091.481}}
        /// </param>
        /// <param name="outputConfig"></param>
        /// <param name="translationConfig"></param>
        /// <param name="languageIdentificationConfig"></param>
        /// <param name="summarizationConfig">
        /// Configuration options for summarization.
        /// </param>
        /// <param name="sentimentAnalysisConfig"></param>
        /// <param name="topicDetectionConfig"></param>
        /// <param name="autoChaptersConfig"></param>
        /// <param name="audioEventsConfig"></param>
        public JobConfig(
            global::G.JobType type,
            global::G.DataFetchConfig? fetchData,
            global::G.DataFetchConfig? fetchText,
            global::G.AlignmentConfig? alignmentConfig,
            global::G.TranscriptionConfig? transcriptionConfig,
            global::System.Collections.Generic.IList<global::G.NotificationConfig>? notificationConfig,
            global::G.TrackingData? tracking,
            global::G.OutputConfig? outputConfig,
            global::G.TranslationConfig? translationConfig,
            global::G.LanguageIdentificationConfig? languageIdentificationConfig,
            global::G.SummarizationConfig? summarizationConfig,
            global::G.SentimentAnalysisConfig? sentimentAnalysisConfig,
            global::G.TopicDetectionConfig? topicDetectionConfig,
            global::G.AutoChaptersConfig? autoChaptersConfig,
            global::G.AudioEventsConfig? audioEventsConfig)
        {
            this.Type = type;
            this.FetchData = fetchData;
            this.FetchText = fetchText;
            this.AlignmentConfig = alignmentConfig;
            this.TranscriptionConfig = transcriptionConfig;
            this.NotificationConfig = notificationConfig;
            this.Tracking = tracking;
            this.OutputConfig = outputConfig;
            this.TranslationConfig = translationConfig;
            this.LanguageIdentificationConfig = languageIdentificationConfig;
            this.SummarizationConfig = summarizationConfig;
            this.SentimentAnalysisConfig = sentimentAnalysisConfig;
            this.TopicDetectionConfig = topicDetectionConfig;
            this.AutoChaptersConfig = autoChaptersConfig;
            this.AudioEventsConfig = audioEventsConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobConfig" /> class.
        /// </summary>
        public JobConfig()
        {
        }
    }
}