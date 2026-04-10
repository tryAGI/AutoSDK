//HintName: G.Models.FallbackElevenLabsTranscriber.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FallbackElevenLabsTranscriber
    {
        /// <summary>
        /// This is the transcription provider that will be used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.FallbackElevenLabsTranscriberProviderJsonConverter))]
        public global::G.FallbackElevenLabsTranscriberProvider Provider { get; set; }

        /// <summary>
        /// This is the model that will be used for the transcription.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.FallbackElevenLabsTranscriberModelJsonConverter))]
        public global::G.FallbackElevenLabsTranscriberModel? Model { get; set; }

        /// <summary>
        /// This is the language that will be used for the transcription.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.FallbackElevenLabsTranscriberLanguageJsonConverter))]
        public global::G.FallbackElevenLabsTranscriberLanguage? Language { get; set; }

        /// <summary>
        /// This is the number of seconds of silence before VAD commits (0.3-3.0).<br/>
        /// Example: 1.5F
        /// </summary>
        /// <example>1.5F</example>
        [global::Newtonsoft.Json.JsonProperty("silenceThresholdSeconds")]
        public double? SilenceThresholdSeconds { get; set; }

        /// <summary>
        /// This is the VAD sensitivity (0.1-0.9, lower indicates more sensitive).<br/>
        /// Example: 0.4F
        /// </summary>
        /// <example>0.4F</example>
        [global::Newtonsoft.Json.JsonProperty("confidenceThreshold")]
        public double? ConfidenceThreshold { get; set; }

        /// <summary>
        /// This is the minimum speech duration for VAD (50-2000ms).<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::Newtonsoft.Json.JsonProperty("minSpeechDurationMs")]
        public double? MinSpeechDurationMs { get; set; }

        /// <summary>
        /// This is the minimum silence duration for VAD (50-2000ms).<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::Newtonsoft.Json.JsonProperty("minSilenceDurationMs")]
        public double? MinSilenceDurationMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackElevenLabsTranscriber" /> class.
        /// </summary>
        /// <param name="provider">
        /// This is the transcription provider that will be used.
        /// </param>
        /// <param name="model">
        /// This is the model that will be used for the transcription.
        /// </param>
        /// <param name="language">
        /// This is the language that will be used for the transcription.
        /// </param>
        /// <param name="silenceThresholdSeconds">
        /// This is the number of seconds of silence before VAD commits (0.3-3.0).<br/>
        /// Example: 1.5F
        /// </param>
        /// <param name="confidenceThreshold">
        /// This is the VAD sensitivity (0.1-0.9, lower indicates more sensitive).<br/>
        /// Example: 0.4F
        /// </param>
        /// <param name="minSpeechDurationMs">
        /// This is the minimum speech duration for VAD (50-2000ms).<br/>
        /// Example: 100
        /// </param>
        /// <param name="minSilenceDurationMs">
        /// This is the minimum silence duration for VAD (50-2000ms).<br/>
        /// Example: 100
        /// </param>
        public FallbackElevenLabsTranscriber(
            global::G.FallbackElevenLabsTranscriberProvider provider,
            global::G.FallbackElevenLabsTranscriberModel? model,
            global::G.FallbackElevenLabsTranscriberLanguage? language,
            double? silenceThresholdSeconds,
            double? confidenceThreshold,
            double? minSpeechDurationMs,
            double? minSilenceDurationMs)
        {
            this.Provider = provider;
            this.Model = model;
            this.Language = language;
            this.SilenceThresholdSeconds = silenceThresholdSeconds;
            this.ConfidenceThreshold = confidenceThreshold;
            this.MinSpeechDurationMs = minSpeechDurationMs;
            this.MinSilenceDurationMs = minSilenceDurationMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackElevenLabsTranscriber" /> class.
        /// </summary>
        public FallbackElevenLabsTranscriber()
        {
        }
    }
}