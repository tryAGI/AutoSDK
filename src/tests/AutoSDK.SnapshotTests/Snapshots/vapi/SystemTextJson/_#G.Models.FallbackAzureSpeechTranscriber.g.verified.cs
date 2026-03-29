//HintName: G.Models.FallbackAzureSpeechTranscriber.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FallbackAzureSpeechTranscriber
    {
        /// <summary>
        /// This is the transcription provider that will be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FallbackAzureSpeechTranscriberProviderJsonConverter))]
        public global::G.FallbackAzureSpeechTranscriberProvider Provider { get; set; }

        /// <summary>
        /// This is the language that will be set for the transcription. The list of languages Azure supports can be found here: https://learn.microsoft.com/en-us/azure/ai-services/speech-service/language-support?tabs=stt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FallbackAzureSpeechTranscriberLanguageJsonConverter))]
        public global::G.FallbackAzureSpeechTranscriberLanguage? Language { get; set; }

        /// <summary>
        /// Controls how phrase boundaries are detected, enabling either simple time/silence heuristics or more advanced semantic segmentation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segmentationStrategy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FallbackAzureSpeechTranscriberSegmentationStrategyJsonConverter))]
        public global::G.FallbackAzureSpeechTranscriberSegmentationStrategy? SegmentationStrategy { get; set; }

        /// <summary>
        /// Duration of detected silence after which the service finalizes a phrase. Configure to adjust sensitivity to pauses in speech.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segmentationSilenceTimeoutMs")]
        public double? SegmentationSilenceTimeoutMs { get; set; }

        /// <summary>
        /// Maximum duration a segment can reach before being cut off when using time-based segmentation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segmentationMaximumTimeMs")]
        public double? SegmentationMaximumTimeMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackAzureSpeechTranscriber" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FallbackAzureSpeechTranscriber(
            global::G.FallbackAzureSpeechTranscriberProvider provider,
            global::G.FallbackAzureSpeechTranscriberLanguage? language,
            global::G.FallbackAzureSpeechTranscriberSegmentationStrategy? segmentationStrategy,
            double? segmentationSilenceTimeoutMs,
            double? segmentationMaximumTimeMs)
        {
            this.Provider = provider;
            this.Language = language;
            this.SegmentationStrategy = segmentationStrategy;
            this.SegmentationSilenceTimeoutMs = segmentationSilenceTimeoutMs;
            this.SegmentationMaximumTimeMs = segmentationMaximumTimeMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackAzureSpeechTranscriber" /> class.
        /// </summary>
        public FallbackAzureSpeechTranscriber()
        {
        }
    }
}