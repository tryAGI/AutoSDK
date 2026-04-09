//HintName: G.Models.TTSConversationalConfigOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"agent_output_audio_format":"pcm_16000","model_id":"eleven_turbo_v2","optimize_streaming_latency":3,"pronunciation_dictionary_locators":[],"similarity_boost":0.8,"speed":1.0,"stability":0.5,"voice_id":"cjVigY5qzO86Huf0OWal"}
    /// </summary>
    public sealed partial class TTSConversationalConfigOutput
    {
        /// <summary>
        /// The model to use for TTS<br/>
        /// Default Value: eleven_flash_v2
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_id")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TTSConversationalModelJsonConverter))]
        public global::G.TTSConversationalModel? ModelId { get; set; }

        /// <summary>
        /// The voice ID to use for TTS<br/>
        /// Default Value: cjVigY5qzO86Huf0OWal
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_id")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// Additional supported voices for the agent
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("supported_voices")]
        public global::System.Collections.Generic.IList<global::G.SupportedVoice>? SupportedVoices { get; set; }

        /// <summary>
        /// When enabled, applies expressive audio tags prompt. Automatically disabled for non-v3 models.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expressive_mode")]
        public bool? ExpressiveMode { get; set; }

        /// <summary>
        /// Suggested audio tags to boost expressive speech (for eleven_v3 and eleven_v3_conversational models). The agent can still use other tags not listed here.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("suggested_audio_tags")]
        public global::System.Collections.Generic.IList<global::G.SuggestedAudioTag>? SuggestedAudioTags { get; set; }

        /// <summary>
        /// The audio format to use for TTS<br/>
        /// Default Value: pcm_16000
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_output_audio_format")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TTSOutputFormatJsonConverter))]
        public global::G.TTSOutputFormat? AgentOutputAudioFormat { get; set; }

        /// <summary>
        /// The optimization for streaming latency<br/>
        /// Default Value: 3
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("optimize_streaming_latency")]
        public int? OptimizeStreamingLatency { get; set; }

        /// <summary>
        /// The stability of generated speech<br/>
        /// Default Value: 0.5F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stability")]
        public double? Stability { get; set; }

        /// <summary>
        /// The speed of generated speech<br/>
        /// Default Value: 1F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// The similarity boost for generated speech<br/>
        /// Default Value: 0.8F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("similarity_boost")]
        public double? SimilarityBoost { get; set; }

        /// <summary>
        /// Method for converting numbers to words before converting text to speech. If set to SYSTEM_PROMPT, the system prompt will be updated to include normalization instructions. If set to ELEVENLABS, the text will be normalized after generation, incurring slight additional latency.<br/>
        /// Default Value: system_prompt
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text_normalisation_type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TextNormalisationTypeJsonConverter))]
        public global::G.TextNormalisationType? TextNormalisationType { get; set; }

        /// <summary>
        /// The pronunciation dictionary locators
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pronunciation_dictionary_locators")]
        public global::System.Collections.Generic.IList<global::G.PydanticPronunciationDictionaryVersionLocator>? PronunciationDictionaryLocators { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSConversationalConfigOutput" /> class.
        /// </summary>
        /// <param name="modelId">
        /// The model to use for TTS<br/>
        /// Default Value: eleven_flash_v2
        /// </param>
        /// <param name="voiceId">
        /// The voice ID to use for TTS<br/>
        /// Default Value: cjVigY5qzO86Huf0OWal
        /// </param>
        /// <param name="supportedVoices">
        /// Additional supported voices for the agent
        /// </param>
        /// <param name="expressiveMode">
        /// When enabled, applies expressive audio tags prompt. Automatically disabled for non-v3 models.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="suggestedAudioTags">
        /// Suggested audio tags to boost expressive speech (for eleven_v3 and eleven_v3_conversational models). The agent can still use other tags not listed here.
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
        /// Default Value: 1F
        /// </param>
        /// <param name="similarityBoost">
        /// The similarity boost for generated speech<br/>
        /// Default Value: 0.8F
        /// </param>
        /// <param name="textNormalisationType">
        /// Method for converting numbers to words before converting text to speech. If set to SYSTEM_PROMPT, the system prompt will be updated to include normalization instructions. If set to ELEVENLABS, the text will be normalized after generation, incurring slight additional latency.<br/>
        /// Default Value: system_prompt
        /// </param>
        /// <param name="pronunciationDictionaryLocators">
        /// The pronunciation dictionary locators
        /// </param>
        public TTSConversationalConfigOutput(
            global::G.TTSConversationalModel? modelId,
            string? voiceId,
            global::System.Collections.Generic.IList<global::G.SupportedVoice>? supportedVoices,
            bool? expressiveMode,
            global::System.Collections.Generic.IList<global::G.SuggestedAudioTag>? suggestedAudioTags,
            global::G.TTSOutputFormat? agentOutputAudioFormat,
            int? optimizeStreamingLatency,
            double? stability,
            double? speed,
            double? similarityBoost,
            global::G.TextNormalisationType? textNormalisationType,
            global::System.Collections.Generic.IList<global::G.PydanticPronunciationDictionaryVersionLocator>? pronunciationDictionaryLocators)
        {
            this.ModelId = modelId;
            this.VoiceId = voiceId;
            this.SupportedVoices = supportedVoices;
            this.ExpressiveMode = expressiveMode;
            this.SuggestedAudioTags = suggestedAudioTags;
            this.AgentOutputAudioFormat = agentOutputAudioFormat;
            this.OptimizeStreamingLatency = optimizeStreamingLatency;
            this.Stability = stability;
            this.Speed = speed;
            this.SimilarityBoost = similarityBoost;
            this.TextNormalisationType = textNormalisationType;
            this.PronunciationDictionaryLocators = pronunciationDictionaryLocators;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSConversationalConfigOutput" /> class.
        /// </summary>
        public TTSConversationalConfigOutput()
        {
        }
    }
}