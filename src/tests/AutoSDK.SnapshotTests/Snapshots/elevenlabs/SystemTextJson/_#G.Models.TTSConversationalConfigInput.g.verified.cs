//HintName: G.Models.TTSConversationalConfigInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"agent_output_audio_format":"pcm_16000","model_id":"eleven_turbo_v2","optimize_streaming_latency":3,"pronunciation_dictionary_locators":[],"similarity_boost":0.8,"speed":1,"stability":0.5,"voice_id":"cjVigY5qzO86Huf0OWal"}
    /// </summary>
    public sealed partial class TTSConversationalConfigInput
    {
        /// <summary>
        /// The model to use for TTS<br/>
        /// Default Value: eleven_turbo_v2
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
        /// Additional supported voices for the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported_voices")]
        public global::System.Collections.Generic.IList<global::G.SupportedVoice>? SupportedVoices { get; set; }

        /// <summary>
        /// The audio format to use for TTS<br/>
        /// Default Value: pcm_16000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_output_audio_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TTSOutputFormatJsonConverter))]
        public global::G.TTSOutputFormat? AgentOutputAudioFormat { get; set; }

        /// <summary>
        /// The optimization for streaming latency<br/>
        /// Default Value: 3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("optimize_streaming_latency")]
        public int? OptimizeStreamingLatency { get; set; }

        /// <summary>
        /// The stability of generated speech<br/>
        /// Default Value: 0.5F
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
        /// Default Value: 0.8F
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
        /// Initializes a new instance of the <see cref="TTSConversationalConfigInput" /> class.
        /// </summary>
        /// <param name="modelId">
        /// The model to use for TTS<br/>
        /// Default Value: eleven_turbo_v2
        /// </param>
        /// <param name="voiceId">
        /// The voice ID to use for TTS<br/>
        /// Default Value: cjVigY5qzO86Huf0OWal
        /// </param>
        /// <param name="supportedVoices">
        /// Additional supported voices for the agent
        /// </param>
        /// <param name="agentOutputAudioFormat">
        /// The audio format to use for TTS<br/>
        /// Default Value: pcm_16000
        /// </param>
        /// <param name="optimizeStreamingLatency">
        /// The optimization for streaming latency<br/>
        /// Default Value: 3
        /// </param>
        /// <param name="stability">
        /// The stability of generated speech<br/>
        /// Default Value: 0.5F
        /// </param>
        /// <param name="speed">
        /// The speed of generated speech<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="similarityBoost">
        /// The similarity boost for generated speech<br/>
        /// Default Value: 0.8F
        /// </param>
        /// <param name="pronunciationDictionaryLocators">
        /// The pronunciation dictionary locators
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TTSConversationalConfigInput(
            global::G.TTSConversationalModel? modelId,
            string? voiceId,
            global::System.Collections.Generic.IList<global::G.SupportedVoice>? supportedVoices,
            global::G.TTSOutputFormat? agentOutputAudioFormat,
            int? optimizeStreamingLatency,
            double? stability,
            double? speed,
            double? similarityBoost,
            global::System.Collections.Generic.IList<global::G.PydanticPronunciationDictionaryVersionLocator>? pronunciationDictionaryLocators)
        {
            this.ModelId = modelId;
            this.VoiceId = voiceId;
            this.SupportedVoices = supportedVoices;
            this.AgentOutputAudioFormat = agentOutputAudioFormat;
            this.OptimizeStreamingLatency = optimizeStreamingLatency;
            this.Stability = stability;
            this.Speed = speed;
            this.SimilarityBoost = similarityBoost;
            this.PronunciationDictionaryLocators = pronunciationDictionaryLocators;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSConversationalConfigInput" /> class.
        /// </summary>
        public TTSConversationalConfigInput()
        {
        }
    }
}