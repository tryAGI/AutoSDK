//HintName: G.Models.WellSaidVoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WellSaidVoice
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
        public global::G.WellSaidVoiceProvider Provider { get; set; }

        /// <summary>
        /// The WellSaid speaker ID to synthesize.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voiceId", Required = global::Newtonsoft.Json.Required.Always)]
        public string VoiceId { get; set; } = default!;

        /// <summary>
        /// This is the model that will be used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public global::G.WellSaidVoiceModel? Model { get; set; }

        /// <summary>
        /// Enables limited SSML translation for input text.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enableSsml")]
        public bool? EnableSsml { get; set; }

        /// <summary>
        /// Array of library IDs to use for voice synthesis.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("libraryIds")]
        public global::System.Collections.Generic.IList<string>? LibraryIds { get; set; }

        /// <summary>
        /// This is the plan for chunking the model output before it is sent to the voice provider.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chunkPlan")]
        public global::G.ChunkPlan? ChunkPlan { get; set; }

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
        /// Initializes a new instance of the <see cref="WellSaidVoice" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// The WellSaid speaker ID to synthesize.
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
        /// This is the model that will be used.
        /// </param>
        /// <param name="enableSsml">
        /// Enables limited SSML translation for input text.
        /// </param>
        /// <param name="libraryIds">
        /// Array of library IDs to use for voice synthesis.
        /// </param>
        /// <param name="chunkPlan">
        /// This is the plan for chunking the model output before it is sent to the voice provider.
        /// </param>
        /// <param name="fallbackPlan">
        /// This is the plan for voice provider fallbacks in the event that the primary voice provider fails.
        /// </param>
        public WellSaidVoice(
            string voiceId,
            bool? cachingEnabled,
            global::G.WellSaidVoiceProvider provider,
            global::G.WellSaidVoiceModel? model,
            bool? enableSsml,
            global::System.Collections.Generic.IList<string>? libraryIds,
            global::G.ChunkPlan? chunkPlan,
            global::G.FallbackPlan? fallbackPlan)
        {
            this.CachingEnabled = cachingEnabled;
            this.Provider = provider;
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
            this.Model = model;
            this.EnableSsml = enableSsml;
            this.LibraryIds = libraryIds;
            this.ChunkPlan = chunkPlan;
            this.FallbackPlan = fallbackPlan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WellSaidVoice" /> class.
        /// </summary>
        public WellSaidVoice()
        {
        }
    }
}