//HintName: G.Models.HumeVoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HumeVoice
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
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.HumeVoiceProviderJsonConverter))]
        public global::G.HumeVoiceProvider Provider { get; set; }

        /// <summary>
        /// This is the model that will be used.<br/>
        /// Example: octave2
        /// </summary>
        /// <example>octave2</example>
        [global::Newtonsoft.Json.JsonProperty("model")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.HumeVoiceModelJsonConverter))]
        public global::G.HumeVoiceModel? Model { get; set; }

        /// <summary>
        /// The ID of the particular voice you want to use.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voiceId", Required = global::Newtonsoft.Json.Required.Always)]
        public string VoiceId { get; set; } = default!;

        /// <summary>
        /// Indicates whether the chosen voice is a preset Hume AI voice or a custom voice.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("isCustomHumeVoice")]
        public bool? IsCustomHumeVoice { get; set; }

        /// <summary>
        /// This is the plan for chunking the model output before it is sent to the voice provider.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chunkPlan")]
        public global::G.ChunkPlan? ChunkPlan { get; set; }

        /// <summary>
        /// Natural language instructions describing how the synthesized speech should sound, including but not limited to tone, intonation, pacing, and accent (e.g., 'a soft, gentle voice with a strong British accent').<br/>
        /// If a Voice is specified in the request, this description serves as acting instructions.<br/>
        /// If no Voice is specified, a new voice is generated based on this description.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// This is the plan for voice provider fallbacks in the event that the primary voice provider fails.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fallbackPlan")]
        public global::G.FallbackPlan? FallbackPlan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HumeVoice" /> class.
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
        /// This is the model that will be used.<br/>
        /// Example: octave2
        /// </param>
        /// <param name="isCustomHumeVoice">
        /// Indicates whether the chosen voice is a preset Hume AI voice or a custom voice.<br/>
        /// Example: false
        /// </param>
        /// <param name="chunkPlan">
        /// This is the plan for chunking the model output before it is sent to the voice provider.
        /// </param>
        /// <param name="description">
        /// Natural language instructions describing how the synthesized speech should sound, including but not limited to tone, intonation, pacing, and accent (e.g., 'a soft, gentle voice with a strong British accent').<br/>
        /// If a Voice is specified in the request, this description serves as acting instructions.<br/>
        /// If no Voice is specified, a new voice is generated based on this description.
        /// </param>
        /// <param name="fallbackPlan">
        /// This is the plan for voice provider fallbacks in the event that the primary voice provider fails.
        /// </param>
        public HumeVoice(
            string voiceId,
            bool? cachingEnabled,
            global::G.HumeVoiceProvider provider,
            global::G.HumeVoiceModel? model,
            bool? isCustomHumeVoice,
            global::G.ChunkPlan? chunkPlan,
            string? description,
            global::G.FallbackPlan? fallbackPlan)
        {
            this.CachingEnabled = cachingEnabled;
            this.Provider = provider;
            this.Model = model;
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
            this.IsCustomHumeVoice = isCustomHumeVoice;
            this.ChunkPlan = chunkPlan;
            this.Description = description;
            this.FallbackPlan = fallbackPlan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HumeVoice" /> class.
        /// </summary>
        public HumeVoice()
        {
        }
    }
}