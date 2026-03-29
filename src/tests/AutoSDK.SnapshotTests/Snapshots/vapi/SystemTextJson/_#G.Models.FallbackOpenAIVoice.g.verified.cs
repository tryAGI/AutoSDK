//HintName: G.Models.FallbackOpenAIVoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FallbackOpenAIVoice
    {
        /// <summary>
        /// This is the flag to toggle voice caching for the assistant.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cachingEnabled")]
        public bool? CachingEnabled { get; set; }

        /// <summary>
        /// This is the voice provider that will be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FallbackOpenAIVoiceProviderJsonConverter))]
        public global::G.FallbackOpenAIVoiceProvider Provider { get; set; }

        /// <summary>
        /// This is the provider-specific ID that will be used.<br/>
        /// Please note that ash, ballad, coral, sage, and verse may only be used with realtime models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voiceId")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.FallbackOpenAIVoiceVoiceId?, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<global::G.FallbackOpenAIVoiceVoiceId?, string> VoiceId { get; set; }

        /// <summary>
        /// This is the model that will be used for text-to-speech.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FallbackOpenAIVoiceModelJsonConverter))]
        public global::G.FallbackOpenAIVoiceModel? Model { get; set; }

        /// <summary>
        /// This is a prompt that allows you to control the voice of your generated audio.<br/>
        /// Does not work with 'tts-1' or 'tts-1-hd' models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// This is the speed multiplier that will be used.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// This is the plan for chunking the model output before it is sent to the voice provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunkPlan")]
        public global::G.ChunkPlan? ChunkPlan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackOpenAIVoice" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// This is the provider-specific ID that will be used.<br/>
        /// Please note that ash, ballad, coral, sage, and verse may only be used with realtime models.
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
        /// This is the model that will be used for text-to-speech.
        /// </param>
        /// <param name="instructions">
        /// This is a prompt that allows you to control the voice of your generated audio.<br/>
        /// Does not work with 'tts-1' or 'tts-1-hd' models.
        /// </param>
        /// <param name="speed">
        /// This is the speed multiplier that will be used.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="chunkPlan">
        /// This is the plan for chunking the model output before it is sent to the voice provider.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FallbackOpenAIVoice(
            global::G.OneOf<global::G.FallbackOpenAIVoiceVoiceId?, string> voiceId,
            bool? cachingEnabled,
            global::G.FallbackOpenAIVoiceProvider provider,
            global::G.FallbackOpenAIVoiceModel? model,
            string? instructions,
            double? speed,
            global::G.ChunkPlan? chunkPlan)
        {
            this.CachingEnabled = cachingEnabled;
            this.Provider = provider;
            this.VoiceId = voiceId;
            this.Model = model;
            this.Instructions = instructions;
            this.Speed = speed;
            this.ChunkPlan = chunkPlan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackOpenAIVoice" /> class.
        /// </summary>
        public FallbackOpenAIVoice()
        {
        }
    }
}