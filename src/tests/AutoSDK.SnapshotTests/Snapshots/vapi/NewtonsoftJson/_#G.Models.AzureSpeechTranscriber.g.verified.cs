//HintName: G.Models.AzureSpeechTranscriber.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AzureSpeechTranscriber
    {
        /// <summary>
        /// This is the transcription provider that will be used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AzureSpeechTranscriberProviderJsonConverter))]
        public global::G.AzureSpeechTranscriberProvider Provider { get; set; }

        /// <summary>
        /// This is the language that will be set for the transcription. The list of languages Azure supports can be found here: https://learn.microsoft.com/en-us/azure/ai-services/speech-service/language-support?tabs=stt
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AzureSpeechTranscriberLanguageJsonConverter))]
        public global::G.AzureSpeechTranscriberLanguage? Language { get; set; }

        /// <summary>
        /// Controls how phrase boundaries are detected, enabling either simple time/silence heuristics or more advanced semantic segmentation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("segmentationStrategy")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AzureSpeechTranscriberSegmentationStrategyJsonConverter))]
        public global::G.AzureSpeechTranscriberSegmentationStrategy? SegmentationStrategy { get; set; }

        /// <summary>
        /// Duration of detected silence after which the service finalizes a phrase. Configure to adjust sensitivity to pauses in speech.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("segmentationSilenceTimeoutMs")]
        public double? SegmentationSilenceTimeoutMs { get; set; }

        /// <summary>
        /// Maximum duration a segment can reach before being cut off when using time-based segmentation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("segmentationMaximumTimeMs")]
        public double? SegmentationMaximumTimeMs { get; set; }

        /// <summary>
        /// This is the plan for transcriber provider fallbacks in the event that the primary transcriber provider fails.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fallbackPlan")]
        public global::G.FallbackTranscriberPlan? FallbackPlan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AzureSpeechTranscriber" /> class.
        /// </summary>
        /// <param name="provider">
        /// This is the transcription provider that will be used.
        /// </param>
        /// <param name="language">
        /// This is the language that will be set for the transcription. The list of languages Azure supports can be found here: https://learn.microsoft.com/en-us/azure/ai-services/speech-service/language-support?tabs=stt
        /// </param>
        /// <param name="segmentationStrategy">
        /// Controls how phrase boundaries are detected, enabling either simple time/silence heuristics or more advanced semantic segmentation.
        /// </param>
        /// <param name="segmentationSilenceTimeoutMs">
        /// Duration of detected silence after which the service finalizes a phrase. Configure to adjust sensitivity to pauses in speech.
        /// </param>
        /// <param name="segmentationMaximumTimeMs">
        /// Maximum duration a segment can reach before being cut off when using time-based segmentation.
        /// </param>
        /// <param name="fallbackPlan">
        /// This is the plan for transcriber provider fallbacks in the event that the primary transcriber provider fails.
        /// </param>
        public AzureSpeechTranscriber(
            global::G.AzureSpeechTranscriberProvider provider,
            global::G.AzureSpeechTranscriberLanguage? language,
            global::G.AzureSpeechTranscriberSegmentationStrategy? segmentationStrategy,
            double? segmentationSilenceTimeoutMs,
            double? segmentationMaximumTimeMs,
            global::G.FallbackTranscriberPlan? fallbackPlan)
        {
            this.Provider = provider;
            this.Language = language;
            this.SegmentationStrategy = segmentationStrategy;
            this.SegmentationSilenceTimeoutMs = segmentationSilenceTimeoutMs;
            this.SegmentationMaximumTimeMs = segmentationMaximumTimeMs;
            this.FallbackPlan = fallbackPlan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AzureSpeechTranscriber" /> class.
        /// </summary>
        public AzureSpeechTranscriber()
        {
        }
    }
}