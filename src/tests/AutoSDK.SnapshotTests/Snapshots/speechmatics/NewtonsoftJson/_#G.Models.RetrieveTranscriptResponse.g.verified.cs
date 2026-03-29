//HintName: G.Models.RetrieveTranscriptResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RetrieveTranscriptResponse
    {
        /// <summary>
        /// Speechmatics JSON transcript format version number.<br/>
        /// Example: 2.1
        /// </summary>
        /// <example>2.1</example>
        [global::Newtonsoft.Json.JsonProperty("format", Required = global::Newtonsoft.Json.Required.Always)]
        public string Format { get; set; } = default!;

        /// <summary>
        /// Summary information about an ASR job, to support identification and tracking.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("job", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.JobInfo Job { get; set; } = default!;

        /// <summary>
        /// Summary information about the output from an ASR job, comprising the job type and configuration parameters used when generating the output.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RecognitionMetadata Metadata { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.RecognitionResult> Results { get; set; } = default!;

        /// <summary>
        /// List of unique speaker identifiers detected in the transcript.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speakers")]
        public global::System.Collections.Generic.IList<global::G.SpeakersResultItem>? Speakers { get; set; }

        /// <summary>
        /// Translations of the transcript into other languages. It is a map of ISO language codes to arrays of translated sentences. Configured using `translation_config`.<br/>
        /// Example: {"de":[{"start_time":0.5,"end_time":1.3,"content":"Guten Tag, wie geht es dir?","speaker":"UU"}],"fr":[{"start_time":0.5,"end_time":1.3,"content":"Bonjour, comment \u00E7a va?","speaker":"UU"}]}
        /// </summary>
        /// <example>{"de":[{"start_time":0.5,"end_time":1.3,"content":"Guten Tag, wie geht es dir?","speaker":"UU"}],"fr":[{"start_time":0.5,"end_time":1.3,"content":"Bonjour, comment \u00E7a va?","speaker":"UU"}]}</example>
        [global::Newtonsoft.Json.JsonProperty("translations")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::G.TranslationSentence>>? Translations { get; set; }

        /// <summary>
        /// Summary of the transcript, configured using `summarization_config`.<br/>
        /// Example: {"content":"this is a summary"}
        /// </summary>
        /// <example>{"content":"this is a summary"}</example>
        [global::Newtonsoft.Json.JsonProperty("summary")]
        public global::G.SummarizationResult? Summary { get; set; }

        /// <summary>
        /// The main object that holds sentiment analysis data.<br/>
        /// Example: {"segments":[{"text":"I am happy with the product.","start_time":0,"end_time":5,"sentiment":"positive","speaker":"John Doe","channel":"Chat","confidence":0.9},{"text":"I don\u0027t like the customer service.","start_time":6,"end_time":12,"sentiment":"negative","speaker":"John Doe","channel":"Chat","confidence":0.8}],"summary":{"overall":{"positive_count":1,"negative_count":1,"neutral_count":0},"speakers":[{"speaker":"John Doe","positive_count":1,"negative_count":1,"neutral_count":0}],"channels":[{"channel":"Chat","positive_count":1,"negative_count":1,"neutral_count":0}]}}
        /// </summary>
        /// <example>{"segments":[{"text":"I am happy with the product.","start_time":0,"end_time":5,"sentiment":"positive","speaker":"John Doe","channel":"Chat","confidence":0.9},{"text":"I don\u0027t like the customer service.","start_time":6,"end_time":12,"sentiment":"negative","speaker":"John Doe","channel":"Chat","confidence":0.8}],"summary":{"overall":{"positive_count":1,"negative_count":1,"neutral_count":0},"speakers":[{"speaker":"John Doe","positive_count":1,"negative_count":1,"neutral_count":0}],"channels":[{"channel":"Chat","positive_count":1,"negative_count":1,"neutral_count":0}]}}</example>
        [global::Newtonsoft.Json.JsonProperty("sentiment_analysis")]
        public global::G.SentimentAnalysisResult? SentimentAnalysis { get; set; }

        /// <summary>
        /// Main object that holds topic detection results.<br/>
        /// Example: {"segments":[{"text":"I am happy with the product.","start_time":0,"end_time":5,"topics":[{"topic":"product"}]},{"text":"We will deploy this container for Spanish.","start_time":6,"end_time":12,"topics":[{"topic":"deployment"},{"topic":"languages"}]}],"summary":{"overall":{"deployment":1,"languages":1,"product":1}}}
        /// </summary>
        /// <example>{"segments":[{"text":"I am happy with the product.","start_time":0,"end_time":5,"topics":[{"topic":"product"}]},{"text":"We will deploy this container for Spanish.","start_time":6,"end_time":12,"topics":[{"topic":"deployment"},{"topic":"languages"}]}],"summary":{"overall":{"deployment":1,"languages":1,"product":1}}}</example>
        [global::Newtonsoft.Json.JsonProperty("topics")]
        public global::G.TopicDetectionResult? Topics { get; set; }

        /// <summary>
        /// An array of objects that represent summarized chapters of the transcript<br/>
        /// Example: [{"title":"Part 1","summary":"Summary of part 1","start_time":0,"end_time":5}, {"title":"Part 2","summary":"Summary of part 2","start_time":5,"end_time":10}]
        /// </summary>
        /// <example>[{"title":"Part 1","summary":"Summary of part 1","start_time":0,"end_time":5}, {"title":"Part 2","summary":"Summary of part 2","start_time":5,"end_time":10}]</example>
        [global::Newtonsoft.Json.JsonProperty("chapters")]
        public global::System.Collections.Generic.IList<global::G.Chapter>? Chapters { get; set; }

        /// <summary>
        /// Timestamped audio events, only set if `audio_events_config` is in the config
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_events")]
        public global::System.Collections.Generic.IList<global::G.AudioEventItem>? AudioEvents { get; set; }

        /// <summary>
        /// Summary statistics per event type, keyed by `type`, e.g. music
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_event_summary")]
        public global::G.RetrieveTranscriptResponseAudioEventSummary? AudioEventSummary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveTranscriptResponse" /> class.
        /// </summary>
        /// <param name="format">
        /// Speechmatics JSON transcript format version number.<br/>
        /// Example: 2.1
        /// </param>
        /// <param name="job">
        /// Summary information about an ASR job, to support identification and tracking.
        /// </param>
        /// <param name="metadata">
        /// Summary information about the output from an ASR job, comprising the job type and configuration parameters used when generating the output.
        /// </param>
        /// <param name="results"></param>
        /// <param name="speakers">
        /// List of unique speaker identifiers detected in the transcript.
        /// </param>
        /// <param name="translations">
        /// Translations of the transcript into other languages. It is a map of ISO language codes to arrays of translated sentences. Configured using `translation_config`.<br/>
        /// Example: {"de":[{"start_time":0.5,"end_time":1.3,"content":"Guten Tag, wie geht es dir?","speaker":"UU"}],"fr":[{"start_time":0.5,"end_time":1.3,"content":"Bonjour, comment \u00E7a va?","speaker":"UU"}]}
        /// </param>
        /// <param name="summary">
        /// Summary of the transcript, configured using `summarization_config`.<br/>
        /// Example: {"content":"this is a summary"}
        /// </param>
        /// <param name="sentimentAnalysis">
        /// The main object that holds sentiment analysis data.<br/>
        /// Example: {"segments":[{"text":"I am happy with the product.","start_time":0,"end_time":5,"sentiment":"positive","speaker":"John Doe","channel":"Chat","confidence":0.9},{"text":"I don\u0027t like the customer service.","start_time":6,"end_time":12,"sentiment":"negative","speaker":"John Doe","channel":"Chat","confidence":0.8}],"summary":{"overall":{"positive_count":1,"negative_count":1,"neutral_count":0},"speakers":[{"speaker":"John Doe","positive_count":1,"negative_count":1,"neutral_count":0}],"channels":[{"channel":"Chat","positive_count":1,"negative_count":1,"neutral_count":0}]}}
        /// </param>
        /// <param name="topics">
        /// Main object that holds topic detection results.<br/>
        /// Example: {"segments":[{"text":"I am happy with the product.","start_time":0,"end_time":5,"topics":[{"topic":"product"}]},{"text":"We will deploy this container for Spanish.","start_time":6,"end_time":12,"topics":[{"topic":"deployment"},{"topic":"languages"}]}],"summary":{"overall":{"deployment":1,"languages":1,"product":1}}}
        /// </param>
        /// <param name="chapters">
        /// An array of objects that represent summarized chapters of the transcript<br/>
        /// Example: [{"title":"Part 1","summary":"Summary of part 1","start_time":0,"end_time":5}, {"title":"Part 2","summary":"Summary of part 2","start_time":5,"end_time":10}]
        /// </param>
        /// <param name="audioEvents">
        /// Timestamped audio events, only set if `audio_events_config` is in the config
        /// </param>
        /// <param name="audioEventSummary">
        /// Summary statistics per event type, keyed by `type`, e.g. music
        /// </param>
        public RetrieveTranscriptResponse(
            string format,
            global::G.JobInfo job,
            global::G.RecognitionMetadata metadata,
            global::System.Collections.Generic.IList<global::G.RecognitionResult> results,
            global::System.Collections.Generic.IList<global::G.SpeakersResultItem>? speakers,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::G.TranslationSentence>>? translations,
            global::G.SummarizationResult? summary,
            global::G.SentimentAnalysisResult? sentimentAnalysis,
            global::G.TopicDetectionResult? topics,
            global::System.Collections.Generic.IList<global::G.Chapter>? chapters,
            global::System.Collections.Generic.IList<global::G.AudioEventItem>? audioEvents,
            global::G.RetrieveTranscriptResponseAudioEventSummary? audioEventSummary)
        {
            this.Format = format ?? throw new global::System.ArgumentNullException(nameof(format));
            this.Job = job ?? throw new global::System.ArgumentNullException(nameof(job));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.Speakers = speakers;
            this.Translations = translations;
            this.Summary = summary;
            this.SentimentAnalysis = sentimentAnalysis;
            this.Topics = topics;
            this.Chapters = chapters;
            this.AudioEvents = audioEvents;
            this.AudioEventSummary = audioEventSummary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveTranscriptResponse" /> class.
        /// </summary>
        public RetrieveTranscriptResponse()
        {
        }
    }
}