//HintName: G.Models.FallbackNeuphonicVoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FallbackNeuphonicVoice
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
        public global::G.FallbackNeuphonicVoiceProvider Provider { get; set; }

        /// <summary>
        /// This is the provider-specific ID that will be used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voiceId", Required = global::Newtonsoft.Json.Required.Always)]
        public string VoiceId { get; set; } = default!;

        /// <summary>
        /// This is the model that will be used. Defaults to 'neu_fast' if not specified.<br/>
        /// Example: neu_fast
        /// </summary>
        /// <example>neu_fast</example>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public global::G.FallbackNeuphonicVoiceModel? Model { get; set; }

        /// <summary>
        /// This is the language (ISO 639-1) that is enforced for the model.<br/>
        /// Example: en
        /// </summary>
        /// <example>en</example>
        [global::Newtonsoft.Json.JsonProperty("language", Required = global::Newtonsoft.Json.Required.Always)]
        public object Language { get; set; } = default!;

        /// <summary>
        /// This is the speed multiplier that will be used.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::Newtonsoft.Json.JsonProperty("speed")]
        public double? Speed { get; set; }

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
        /// Initializes a new instance of the <see cref="FallbackNeuphonicVoice" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// This is the provider-specific ID that will be used.
        /// </param>
        /// <param name="language">
        /// This is the language (ISO 639-1) that is enforced for the model.<br/>
        /// Example: en
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
        /// This is the model that will be used. Defaults to 'neu_fast' if not specified.<br/>
        /// Example: neu_fast
        /// </param>
        /// <param name="speed">
        /// This is the speed multiplier that will be used.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="chunkPlan">
        /// This is the plan for chunking the model output before it is sent to the voice provider.
        /// </param>
        public FallbackNeuphonicVoice(
            string voiceId,
            object language,
            bool? cachingEnabled,
            global::G.FallbackNeuphonicVoiceProvider provider,
            global::G.FallbackNeuphonicVoiceModel? model,
            double? speed,
            global::G.ChunkPlan? chunkPlan)
        {
            this.CachingEnabled = cachingEnabled;
            this.Provider = provider;
            this.VoiceId = voiceId;
            this.Model = model;
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.Speed = speed;
            this.ChunkPlan = chunkPlan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackNeuphonicVoice" /> class.
        /// </summary>
        public FallbackNeuphonicVoice()
        {
        }
    }
}