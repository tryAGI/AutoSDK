//HintName: G.Models.FallbackCartesiaVoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FallbackCartesiaVoice
    {
        /// <summary>
        /// This is the flag to toggle voice caching for the assistant.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("cachingEnabled")]
        public bool? CachingEnabled { get; set; }

        /// <summary>
        /// This is the voice provider that will be used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public global::G.FallbackCartesiaVoiceProvider Provider { get; set; }

        /// <summary>
        /// The ID of the particular voice you want to use.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voiceId", Required = global::Newtonsoft.Json.Required.Always)]
        public string VoiceId { get; set; } = default!;

        /// <summary>
        /// This is the model that will be used. This is optional and will default to the correct model for the voiceId.<br/>
        /// Example: sonic-english
        /// </summary>
        /// <example>sonic-english</example>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public global::G.FallbackCartesiaVoiceModel? Model { get; set; }

        /// <summary>
        /// This is the language that will be used. This is optional and will default to the correct language for the voiceId.<br/>
        /// Example: en
        /// </summary>
        /// <example>en</example>
        [global::Newtonsoft.Json.JsonProperty("language")]
        public global::G.FallbackCartesiaVoiceLanguage? Language { get; set; }

        /// <summary>
        /// Experimental controls for Cartesia voice generation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("experimentalControls")]
        public global::G.CartesiaExperimentalControls? ExperimentalControls { get; set; }

        /// <summary>
        /// Generation config for fine-grained control of sonic-3 voice output (speed, volume, and experimental controls). Only available for sonic-3 model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generationConfig")]
        public global::G.CartesiaGenerationConfig? GenerationConfig { get; set; }

        /// <summary>
        /// Pronunciation dictionary ID for sonic-3. Allows custom pronunciations for specific words. Only available for sonic-3 model.<br/>
        /// Example: dict_abc123
        /// </summary>
        /// <example>dict_abc123</example>
        [global::Newtonsoft.Json.JsonProperty("pronunciationDictId")]
        public string? PronunciationDictId { get; set; }

        /// <summary>
        /// This is the plan for chunking the model output before it is sent to the voice provider.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chunkPlan")]
        public global::G.ChunkPlan? ChunkPlan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackCartesiaVoice" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// The ID of the particular voice you want to use.
        /// </param>
        /// <param name="cachingEnabled">
        /// This is the flag to toggle voice caching for the assistant.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="provider">
        /// This is the voice provider that will be used.
        /// </param>
        /// <param name="model">
        /// This is the model that will be used. This is optional and will default to the correct model for the voiceId.<br/>
        /// Example: sonic-english
        /// </param>
        /// <param name="language">
        /// This is the language that will be used. This is optional and will default to the correct language for the voiceId.<br/>
        /// Example: en
        /// </param>
        /// <param name="experimentalControls">
        /// Experimental controls for Cartesia voice generation
        /// </param>
        /// <param name="generationConfig">
        /// Generation config for fine-grained control of sonic-3 voice output (speed, volume, and experimental controls). Only available for sonic-3 model.
        /// </param>
        /// <param name="pronunciationDictId">
        /// Pronunciation dictionary ID for sonic-3. Allows custom pronunciations for specific words. Only available for sonic-3 model.<br/>
        /// Example: dict_abc123
        /// </param>
        /// <param name="chunkPlan">
        /// This is the plan for chunking the model output before it is sent to the voice provider.
        /// </param>
        public FallbackCartesiaVoice(
            string voiceId,
            bool? cachingEnabled,
            global::G.FallbackCartesiaVoiceProvider provider,
            global::G.FallbackCartesiaVoiceModel? model,
            global::G.FallbackCartesiaVoiceLanguage? language,
            global::G.CartesiaExperimentalControls? experimentalControls,
            global::G.CartesiaGenerationConfig? generationConfig,
            string? pronunciationDictId,
            global::G.ChunkPlan? chunkPlan)
        {
            this.CachingEnabled = cachingEnabled;
            this.Provider = provider;
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
            this.Model = model;
            this.Language = language;
            this.ExperimentalControls = experimentalControls;
            this.GenerationConfig = generationConfig;
            this.PronunciationDictId = pronunciationDictId;
            this.ChunkPlan = chunkPlan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackCartesiaVoice" /> class.
        /// </summary>
        public FallbackCartesiaVoice()
        {
        }
    }
}