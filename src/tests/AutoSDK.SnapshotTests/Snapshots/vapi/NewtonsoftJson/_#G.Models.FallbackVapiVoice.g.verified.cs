//HintName: G.Models.FallbackVapiVoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FallbackVapiVoice
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
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.FallbackVapiVoiceProviderJsonConverter))]
        public global::G.FallbackVapiVoiceProvider Provider { get; set; }

        /// <summary>
        /// The voices provided by Vapi
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voiceId", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.FallbackVapiVoiceVoiceIdJsonConverter))]
        public global::G.FallbackVapiVoiceVoiceId VoiceId { get; set; } = default!;

        /// <summary>
        /// This is the speed multiplier that will be used.<br/>
        /// @default 1<br/>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// List of pronunciation dictionary locators for custom word pronunciations.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pronunciationDictionary")]
        public global::System.Collections.Generic.IList<global::G.VapiPronunciationDictionaryLocator>? PronunciationDictionary { get; set; }

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
        /// Initializes a new instance of the <see cref="FallbackVapiVoice" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// The voices provided by Vapi
        /// </param>
        /// <param name="cachingEnabled">
        /// This is the flag to toggle voice caching for the assistant.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="provider">
        /// This is the voice provider that will be used.
        /// </param>
        /// <param name="speed">
        /// This is the speed multiplier that will be used.<br/>
        /// @default 1<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="pronunciationDictionary">
        /// List of pronunciation dictionary locators for custom word pronunciations.
        /// </param>
        /// <param name="chunkPlan">
        /// This is the plan for chunking the model output before it is sent to the voice provider.
        /// </param>
        public FallbackVapiVoice(
            global::G.FallbackVapiVoiceVoiceId voiceId,
            bool? cachingEnabled,
            global::G.FallbackVapiVoiceProvider provider,
            double? speed,
            global::System.Collections.Generic.IList<global::G.VapiPronunciationDictionaryLocator>? pronunciationDictionary,
            global::G.ChunkPlan? chunkPlan)
        {
            this.CachingEnabled = cachingEnabled;
            this.Provider = provider;
            this.VoiceId = voiceId;
            this.Speed = speed;
            this.PronunciationDictionary = pronunciationDictionary;
            this.ChunkPlan = chunkPlan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackVapiVoice" /> class.
        /// </summary>
        public FallbackVapiVoice()
        {
        }
    }
}