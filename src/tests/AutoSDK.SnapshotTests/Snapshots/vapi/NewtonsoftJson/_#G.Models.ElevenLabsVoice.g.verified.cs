//HintName: G.Models.ElevenLabsVoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ElevenLabsVoice
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
        public global::G.ElevenLabsVoiceProvider Provider { get; set; }

        /// <summary>
        /// This is the provider-specific ID that will be used. Ensure the Voice is present in your 11Labs Voice Library.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voiceId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.ElevenLabsVoiceVoiceId?, string> VoiceId { get; set; } = default!;

        /// <summary>
        /// Defines the stability for voice settings.<br/>
        /// Example: 0.5F
        /// </summary>
        /// <example>0.5F</example>
        [global::Newtonsoft.Json.JsonProperty("stability")]
        public double? Stability { get; set; }

        /// <summary>
        /// Defines the similarity boost for voice settings.<br/>
        /// Example: 0.75F
        /// </summary>
        /// <example>0.75F</example>
        [global::Newtonsoft.Json.JsonProperty("similarityBoost")]
        public double? SimilarityBoost { get; set; }

        /// <summary>
        /// Defines the style for voice settings.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::Newtonsoft.Json.JsonProperty("style")]
        public double? Style { get; set; }

        /// <summary>
        /// Defines the use speaker boost for voice settings.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("useSpeakerBoost")]
        public bool? UseSpeakerBoost { get; set; }

        /// <summary>
        /// Defines the speed for voice settings.<br/>
        /// Example: 0.9F
        /// </summary>
        /// <example>0.9F</example>
        [global::Newtonsoft.Json.JsonProperty("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// Defines the optimize streaming latency for voice settings. Defaults to 3.<br/>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::Newtonsoft.Json.JsonProperty("optimizeStreamingLatency")]
        public double? OptimizeStreamingLatency { get; set; }

        /// <summary>
        /// This enables the use of https://elevenlabs.io/docs/speech-synthesis/prompting#pronunciation. Defaults to false to save latency.<br/>
        /// @default false<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("enableSsmlParsing")]
        public bool? EnableSsmlParsing { get; set; }

        /// <summary>
        /// Defines the auto mode for voice settings. Defaults to false.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("autoMode")]
        public bool? AutoMode { get; set; }

        /// <summary>
        /// This is the model that will be used. Defaults to 'eleven_turbo_v2' if not specified.<br/>
        /// Example: eleven_turbo_v2_5
        /// </summary>
        /// <example>eleven_turbo_v2_5</example>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public global::G.ElevenLabsVoiceModel? Model { get; set; }

        /// <summary>
        /// This is the language (ISO 639-1) that is enforced for the model. Currently only Turbo v2.5 supports language enforcement. For other models, an error will be returned if language code is provided.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language")]
        public string? Language { get; set; }

        /// <summary>
        /// This is the plan for chunking the model output before it is sent to the voice provider.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chunkPlan")]
        public global::G.ChunkPlan? ChunkPlan { get; set; }

        /// <summary>
        /// This is the pronunciation dictionary locators to use.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pronunciationDictionaryLocators")]
        public global::System.Collections.Generic.IList<global::G.ElevenLabsPronunciationDictionaryLocator>? PronunciationDictionaryLocators { get; set; }

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
        /// Initializes a new instance of the <see cref="ElevenLabsVoice" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// This is the provider-specific ID that will be used. Ensure the Voice is present in your 11Labs Voice Library.
        /// </param>
        /// <param name="cachingEnabled">
        /// This is the flag to toggle voice caching for the assistant.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="provider">
        /// This is the voice provider that will be used.
        /// </param>
        /// <param name="stability">
        /// Defines the stability for voice settings.<br/>
        /// Example: 0.5F
        /// </param>
        /// <param name="similarityBoost">
        /// Defines the similarity boost for voice settings.<br/>
        /// Example: 0.75F
        /// </param>
        /// <param name="style">
        /// Defines the style for voice settings.<br/>
        /// Example: 0
        /// </param>
        /// <param name="useSpeakerBoost">
        /// Defines the use speaker boost for voice settings.<br/>
        /// Example: false
        /// </param>
        /// <param name="speed">
        /// Defines the speed for voice settings.<br/>
        /// Example: 0.9F
        /// </param>
        /// <param name="optimizeStreamingLatency">
        /// Defines the optimize streaming latency for voice settings. Defaults to 3.<br/>
        /// Example: 3
        /// </param>
        /// <param name="enableSsmlParsing">
        /// This enables the use of https://elevenlabs.io/docs/speech-synthesis/prompting#pronunciation. Defaults to false to save latency.<br/>
        /// @default false<br/>
        /// Example: false
        /// </param>
        /// <param name="autoMode">
        /// Defines the auto mode for voice settings. Defaults to false.<br/>
        /// Example: false
        /// </param>
        /// <param name="model">
        /// This is the model that will be used. Defaults to 'eleven_turbo_v2' if not specified.<br/>
        /// Example: eleven_turbo_v2_5
        /// </param>
        /// <param name="language">
        /// This is the language (ISO 639-1) that is enforced for the model. Currently only Turbo v2.5 supports language enforcement. For other models, an error will be returned if language code is provided.
        /// </param>
        /// <param name="chunkPlan">
        /// This is the plan for chunking the model output before it is sent to the voice provider.
        /// </param>
        /// <param name="pronunciationDictionaryLocators">
        /// This is the pronunciation dictionary locators to use.
        /// </param>
        /// <param name="fallbackPlan">
        /// This is the plan for voice provider fallbacks in the event that the primary voice provider fails.
        /// </param>
        public ElevenLabsVoice(
            global::G.OneOf<global::G.ElevenLabsVoiceVoiceId?, string> voiceId,
            bool? cachingEnabled,
            global::G.ElevenLabsVoiceProvider provider,
            double? stability,
            double? similarityBoost,
            double? style,
            bool? useSpeakerBoost,
            double? speed,
            double? optimizeStreamingLatency,
            bool? enableSsmlParsing,
            bool? autoMode,
            global::G.ElevenLabsVoiceModel? model,
            string? language,
            global::G.ChunkPlan? chunkPlan,
            global::System.Collections.Generic.IList<global::G.ElevenLabsPronunciationDictionaryLocator>? pronunciationDictionaryLocators,
            global::G.FallbackPlan? fallbackPlan)
        {
            this.CachingEnabled = cachingEnabled;
            this.Provider = provider;
            this.VoiceId = voiceId;
            this.Stability = stability;
            this.SimilarityBoost = similarityBoost;
            this.Style = style;
            this.UseSpeakerBoost = useSpeakerBoost;
            this.Speed = speed;
            this.OptimizeStreamingLatency = optimizeStreamingLatency;
            this.EnableSsmlParsing = enableSsmlParsing;
            this.AutoMode = autoMode;
            this.Model = model;
            this.Language = language;
            this.ChunkPlan = chunkPlan;
            this.PronunciationDictionaryLocators = pronunciationDictionaryLocators;
            this.FallbackPlan = fallbackPlan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ElevenLabsVoice" /> class.
        /// </summary>
        public ElevenLabsVoice()
        {
        }
    }
}