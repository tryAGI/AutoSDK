//HintName: G.Models.FallbackAssemblyAITranscriber.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FallbackAssemblyAITranscriber
    {
        /// <summary>
        /// This is the transcription provider that will be used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.FallbackAssemblyAITranscriberProviderJsonConverter))]
        public global::G.FallbackAssemblyAITranscriberProvider Provider { get; set; }

        /// <summary>
        /// This is the language that will be set for the transcription.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.FallbackAssemblyAITranscriberLanguageJsonConverter))]
        public global::G.FallbackAssemblyAITranscriberLanguage? Language { get; set; }

        /// <summary>
        /// Transcripts below this confidence threshold will be discarded.<br/>
        /// @default 0.4<br/>
        /// Example: 0.4F
        /// </summary>
        /// <example>0.4F</example>
        [global::Newtonsoft.Json.JsonProperty("confidenceThreshold")]
        public double? ConfidenceThreshold { get; set; }

        /// <summary>
        /// This enables formatting of transcripts.<br/>
        /// @default true<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("formatTurns")]
        public bool? FormatTurns { get; set; }

        /// <summary>
        /// This is the end of turn confidence threshold. The minimum confidence that the end of turn is detected.<br/>
        /// Note: Only used if startSpeakingPlan.smartEndpointingPlan is not set.<br/>
        /// @min 0<br/>
        /// @max 1<br/>
        /// @default 0.7<br/>
        /// Example: 0.7F
        /// </summary>
        /// <example>0.7F</example>
        [global::Newtonsoft.Json.JsonProperty("endOfTurnConfidenceThreshold")]
        public double? EndOfTurnConfidenceThreshold { get; set; }

        /// <summary>
        /// This is the minimum end of turn silence when confident in milliseconds.<br/>
        /// Note: Only used if startSpeakingPlan.smartEndpointingPlan is not set.<br/>
        /// @default 160<br/>
        /// Example: 160
        /// </summary>
        /// <example>160</example>
        [global::Newtonsoft.Json.JsonProperty("minEndOfTurnSilenceWhenConfident")]
        public double? MinEndOfTurnSilenceWhenConfident { get; set; }

        /// <summary>
        /// Example: 160
        /// </summary>
        /// <example>160</example>
        [global::Newtonsoft.Json.JsonProperty("wordFinalizationMaxWaitTime")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public double? WordFinalizationMaxWaitTime { get; set; }

        /// <summary>
        /// This is the maximum turn silence time in milliseconds.<br/>
        /// Note: Only used if startSpeakingPlan.smartEndpointingPlan is not set.<br/>
        /// @default 400<br/>
        /// Example: 400
        /// </summary>
        /// <example>400</example>
        [global::Newtonsoft.Json.JsonProperty("maxTurnSilence")]
        public double? MaxTurnSilence { get; set; }

        /// <summary>
        /// Use VAD to assist with endpointing decisions from the transcriber.<br/>
        /// When enabled, transcriber endpointing will be buffered if VAD detects the user is still speaking, preventing premature turn-taking.<br/>
        /// When disabled, transcriber endpointing will be used immediately regardless of VAD state, allowing for quicker but more aggressive turn-taking.<br/>
        /// Note: Only used if startSpeakingPlan.smartEndpointingPlan is not set.<br/>
        /// @default true<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("vadAssistedEndpointingEnabled")]
        public bool? VadAssistedEndpointingEnabled { get; set; }

        /// <summary>
        /// This is the speech model used for the streaming session.<br/>
        /// Note: Keyterms prompting is not supported with multilingual streaming.<br/>
        /// @default 'universal-streaming-english'
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speechModel")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.FallbackAssemblyAITranscriberSpeechModelJsonConverter))]
        public global::G.FallbackAssemblyAITranscriberSpeechModel? SpeechModel { get; set; }

        /// <summary>
        /// The WebSocket URL that the transcriber connects to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("realtimeUrl")]
        public string? RealtimeUrl { get; set; }

        /// <summary>
        /// Add up to 2500 characters of custom vocabulary.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("wordBoost")]
        public global::System.Collections.Generic.IList<string>? WordBoost { get; set; }

        /// <summary>
        /// Keyterms prompting improves recognition accuracy for specific words and phrases.<br/>
        /// Can include up to 100 keyterms, each up to 50 characters.<br/>
        /// Costs an additional $0.04/hour when enabled.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("keytermsPrompt")]
        public global::System.Collections.Generic.IList<string>? KeytermsPrompt { get; set; }

        /// <summary>
        /// The duration of the end utterance silence threshold in milliseconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endUtteranceSilenceThreshold")]
        public double? EndUtteranceSilenceThreshold { get; set; }

        /// <summary>
        /// Disable partial transcripts.<br/>
        /// Set to `true` to not receive partial transcripts. Defaults to `false`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("disablePartialTranscripts")]
        public bool? DisablePartialTranscripts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackAssemblyAITranscriber" /> class.
        /// </summary>
        /// <param name="provider">
        /// This is the transcription provider that will be used.
        /// </param>
        /// <param name="language">
        /// This is the language that will be set for the transcription.
        /// </param>
        /// <param name="confidenceThreshold">
        /// Transcripts below this confidence threshold will be discarded.<br/>
        /// @default 0.4<br/>
        /// Example: 0.4F
        /// </param>
        /// <param name="formatTurns">
        /// This enables formatting of transcripts.<br/>
        /// @default true<br/>
        /// Example: true
        /// </param>
        /// <param name="endOfTurnConfidenceThreshold">
        /// This is the end of turn confidence threshold. The minimum confidence that the end of turn is detected.<br/>
        /// Note: Only used if startSpeakingPlan.smartEndpointingPlan is not set.<br/>
        /// @min 0<br/>
        /// @max 1<br/>
        /// @default 0.7<br/>
        /// Example: 0.7F
        /// </param>
        /// <param name="minEndOfTurnSilenceWhenConfident">
        /// This is the minimum end of turn silence when confident in milliseconds.<br/>
        /// Note: Only used if startSpeakingPlan.smartEndpointingPlan is not set.<br/>
        /// @default 160<br/>
        /// Example: 160
        /// </param>
        /// <param name="maxTurnSilence">
        /// This is the maximum turn silence time in milliseconds.<br/>
        /// Note: Only used if startSpeakingPlan.smartEndpointingPlan is not set.<br/>
        /// @default 400<br/>
        /// Example: 400
        /// </param>
        /// <param name="vadAssistedEndpointingEnabled">
        /// Use VAD to assist with endpointing decisions from the transcriber.<br/>
        /// When enabled, transcriber endpointing will be buffered if VAD detects the user is still speaking, preventing premature turn-taking.<br/>
        /// When disabled, transcriber endpointing will be used immediately regardless of VAD state, allowing for quicker but more aggressive turn-taking.<br/>
        /// Note: Only used if startSpeakingPlan.smartEndpointingPlan is not set.<br/>
        /// @default true<br/>
        /// Example: true
        /// </param>
        /// <param name="speechModel">
        /// This is the speech model used for the streaming session.<br/>
        /// Note: Keyterms prompting is not supported with multilingual streaming.<br/>
        /// @default 'universal-streaming-english'
        /// </param>
        /// <param name="realtimeUrl">
        /// The WebSocket URL that the transcriber connects to.
        /// </param>
        /// <param name="wordBoost">
        /// Add up to 2500 characters of custom vocabulary.
        /// </param>
        /// <param name="keytermsPrompt">
        /// Keyterms prompting improves recognition accuracy for specific words and phrases.<br/>
        /// Can include up to 100 keyterms, each up to 50 characters.<br/>
        /// Costs an additional $0.04/hour when enabled.
        /// </param>
        /// <param name="endUtteranceSilenceThreshold">
        /// The duration of the end utterance silence threshold in milliseconds.
        /// </param>
        /// <param name="disablePartialTranscripts">
        /// Disable partial transcripts.<br/>
        /// Set to `true` to not receive partial transcripts. Defaults to `false`.
        /// </param>
        public FallbackAssemblyAITranscriber(
            global::G.FallbackAssemblyAITranscriberProvider provider,
            global::G.FallbackAssemblyAITranscriberLanguage? language,
            double? confidenceThreshold,
            bool? formatTurns,
            double? endOfTurnConfidenceThreshold,
            double? minEndOfTurnSilenceWhenConfident,
            double? maxTurnSilence,
            bool? vadAssistedEndpointingEnabled,
            global::G.FallbackAssemblyAITranscriberSpeechModel? speechModel,
            string? realtimeUrl,
            global::System.Collections.Generic.IList<string>? wordBoost,
            global::System.Collections.Generic.IList<string>? keytermsPrompt,
            double? endUtteranceSilenceThreshold,
            bool? disablePartialTranscripts)
        {
            this.Provider = provider;
            this.Language = language;
            this.ConfidenceThreshold = confidenceThreshold;
            this.FormatTurns = formatTurns;
            this.EndOfTurnConfidenceThreshold = endOfTurnConfidenceThreshold;
            this.MinEndOfTurnSilenceWhenConfident = minEndOfTurnSilenceWhenConfident;
            this.MaxTurnSilence = maxTurnSilence;
            this.VadAssistedEndpointingEnabled = vadAssistedEndpointingEnabled;
            this.SpeechModel = speechModel;
            this.RealtimeUrl = realtimeUrl;
            this.WordBoost = wordBoost;
            this.KeytermsPrompt = keytermsPrompt;
            this.EndUtteranceSilenceThreshold = endUtteranceSilenceThreshold;
            this.DisablePartialTranscripts = disablePartialTranscripts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackAssemblyAITranscriber" /> class.
        /// </summary>
        public FallbackAssemblyAITranscriber()
        {
        }
    }
}