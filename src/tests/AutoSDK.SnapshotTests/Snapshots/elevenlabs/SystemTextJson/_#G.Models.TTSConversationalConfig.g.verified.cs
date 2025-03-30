//HintName: G.Models.TTSConversationalConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TTSConversationalConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TTSConversationalModelJsonConverter))]
        public global::G.TTSConversationalModel? ModelId { get; set; }

        /// <summary>
        /// The voice ID to use for TTS<br/>
        /// Default Value: cjVigY5qzO86Huf0OWal
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_output_audio_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TTSOutputFormatJsonConverter))]
        public global::G.TTSOutputFormat? AgentOutputAudioFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("optimize_streaming_latency")]
        public int? OptimizeStreamingLatency { get; set; }

        /// <summary>
        /// The stability of generated speech<br/>
        /// Default Value: 0.5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stability")]
        public double? Stability { get; set; }

        /// <summary>
        /// The speed of generated speech<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// The similarity boost for generated speech<br/>
        /// Default Value: 0.8
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("similarity_boost")]
        public double? SimilarityBoost { get; set; }

        /// <summary>
        /// The pronunciation dictionary locators
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pronunciation_dictionary_locators")]
        public global::System.Collections.Generic.IList<global::G.PydanticPronunciationDictionaryVersionLocator>? PronunciationDictionaryLocators { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSConversationalConfig" /> class.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="voiceId">
        /// The voice ID to use for TTS<br/>
        /// Default Value: cjVigY5qzO86Huf0OWal
        /// </param>
        /// <param name="agentOutputAudioFormat"></param>
        /// <param name="optimizeStreamingLatency"></param>
        /// <param name="stability">
        /// The stability of generated speech<br/>
        /// Default Value: 0.5
        /// </param>
        /// <param name="speed">
        /// The speed of generated speech<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="similarityBoost">
        /// The similarity boost for generated speech<br/>
        /// Default Value: 0.8
        /// </param>
        /// <param name="pronunciationDictionaryLocators">
        /// The pronunciation dictionary locators
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TTSConversationalConfig(
            global::G.TTSConversationalModel? modelId,
            string? voiceId,
            global::G.TTSOutputFormat? agentOutputAudioFormat,
            int? optimizeStreamingLatency,
            double? stability,
            double? speed,
            double? similarityBoost,
            global::System.Collections.Generic.IList<global::G.PydanticPronunciationDictionaryVersionLocator>? pronunciationDictionaryLocators)
        {
            this.ModelId = modelId;
            this.VoiceId = voiceId;
            this.AgentOutputAudioFormat = agentOutputAudioFormat;
            this.OptimizeStreamingLatency = optimizeStreamingLatency;
            this.Stability = stability;
            this.Speed = speed;
            this.SimilarityBoost = similarityBoost;
            this.PronunciationDictionaryLocators = pronunciationDictionaryLocators;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSConversationalConfig" /> class.
        /// </summary>
        public TTSConversationalConfig()
        {
        }
    }
}