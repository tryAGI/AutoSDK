//HintName: G.Models.FallbackRimeAIVoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FallbackRimeAIVoice
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
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.FallbackRimeAIVoiceProviderJsonConverter))]
        public global::G.FallbackRimeAIVoiceProvider Provider { get; set; }

        /// <summary>
        /// This is the provider-specific ID that will be used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voiceId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.FallbackRimeAIVoiceVoiceId?, string> VoiceId { get; set; } = default!;

        /// <summary>
        /// This is the model that will be used. Defaults to 'arcana' when not specified.<br/>
        /// Example: arcana
        /// </summary>
        /// <example>arcana</example>
        [global::Newtonsoft.Json.JsonProperty("model")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.FallbackRimeAIVoiceModelJsonConverter))]
        public global::G.FallbackRimeAIVoiceModel? Model { get; set; }

        /// <summary>
        /// This is the speed multiplier that will be used.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::Newtonsoft.Json.JsonProperty("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// This is a flag that controls whether to add slight pauses using angle brackets. Example: "Hi. &lt;200&gt; I'd love to have a conversation with you." adds a 200ms pause between the first and second sentences.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("pauseBetweenBrackets")]
        public bool? PauseBetweenBrackets { get; set; }

        /// <summary>
        /// This is a flag that controls whether text inside brackets should be phonemized (converted to phonetic pronunciation) - Example: "{h'El.o} World" will pronounce "Hello" as expected.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("phonemizeBetweenBrackets")]
        public bool? PhonemizeBetweenBrackets { get; set; }

        /// <summary>
        /// This is a flag that controls whether to optimize for reduced latency in streaming. https://docs.rime.ai/api-reference/endpoint/websockets#param-reduce-latency<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("reduceLatency")]
        public bool? ReduceLatency { get; set; }

        /// <summary>
        /// This is a string that allows inline speed control using alpha notation. https://docs.rime.ai/api-reference/endpoint/websockets#param-inline-speed-alpha<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::Newtonsoft.Json.JsonProperty("inlineSpeedAlpha")]
        public string? InlineSpeedAlpha { get; set; }

        /// <summary>
        /// Language for speech synthesis. Uses ISO 639 codes. Supported: en, es, de, fr, ar, hi, ja, he, pt, ta, si.<br/>
        /// Example: en
        /// </summary>
        /// <example>en</example>
        [global::Newtonsoft.Json.JsonProperty("language")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.FallbackRimeAIVoiceLanguageJsonConverter))]
        public global::G.FallbackRimeAIVoiceLanguage? Language { get; set; }

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
        /// Initializes a new instance of the <see cref="FallbackRimeAIVoice" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// This is the provider-specific ID that will be used.
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
        /// This is the model that will be used. Defaults to 'arcana' when not specified.<br/>
        /// Example: arcana
        /// </param>
        /// <param name="speed">
        /// This is the speed multiplier that will be used.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="pauseBetweenBrackets">
        /// This is a flag that controls whether to add slight pauses using angle brackets. Example: "Hi. &lt;200&gt; I'd love to have a conversation with you." adds a 200ms pause between the first and second sentences.<br/>
        /// Example: false
        /// </param>
        /// <param name="phonemizeBetweenBrackets">
        /// This is a flag that controls whether text inside brackets should be phonemized (converted to phonetic pronunciation) - Example: "{h'El.o} World" will pronounce "Hello" as expected.<br/>
        /// Example: false
        /// </param>
        /// <param name="reduceLatency">
        /// This is a flag that controls whether to optimize for reduced latency in streaming. https://docs.rime.ai/api-reference/endpoint/websockets#param-reduce-latency<br/>
        /// Example: false
        /// </param>
        /// <param name="inlineSpeedAlpha">
        /// This is a string that allows inline speed control using alpha notation. https://docs.rime.ai/api-reference/endpoint/websockets#param-inline-speed-alpha<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="language">
        /// Language for speech synthesis. Uses ISO 639 codes. Supported: en, es, de, fr, ar, hi, ja, he, pt, ta, si.<br/>
        /// Example: en
        /// </param>
        /// <param name="chunkPlan">
        /// This is the plan for chunking the model output before it is sent to the voice provider.
        /// </param>
        public FallbackRimeAIVoice(
            global::G.OneOf<global::G.FallbackRimeAIVoiceVoiceId?, string> voiceId,
            bool? cachingEnabled,
            global::G.FallbackRimeAIVoiceProvider provider,
            global::G.FallbackRimeAIVoiceModel? model,
            double? speed,
            bool? pauseBetweenBrackets,
            bool? phonemizeBetweenBrackets,
            bool? reduceLatency,
            string? inlineSpeedAlpha,
            global::G.FallbackRimeAIVoiceLanguage? language,
            global::G.ChunkPlan? chunkPlan)
        {
            this.CachingEnabled = cachingEnabled;
            this.Provider = provider;
            this.VoiceId = voiceId;
            this.Model = model;
            this.Speed = speed;
            this.PauseBetweenBrackets = pauseBetweenBrackets;
            this.PhonemizeBetweenBrackets = phonemizeBetweenBrackets;
            this.ReduceLatency = reduceLatency;
            this.InlineSpeedAlpha = inlineSpeedAlpha;
            this.Language = language;
            this.ChunkPlan = chunkPlan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackRimeAIVoice" /> class.
        /// </summary>
        public FallbackRimeAIVoice()
        {
        }
    }
}