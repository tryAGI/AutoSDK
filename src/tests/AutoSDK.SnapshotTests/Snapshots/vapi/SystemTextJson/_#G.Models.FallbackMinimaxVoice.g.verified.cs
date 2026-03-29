//HintName: G.Models.FallbackMinimaxVoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FallbackMinimaxVoice
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FallbackMinimaxVoiceProviderJsonConverter))]
        public global::G.FallbackMinimaxVoiceProvider Provider { get; set; }

        /// <summary>
        /// This is the provider-specific ID that will be used. Use a voice from MINIMAX_PREDEFINED_VOICES or a custom cloned voice ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voiceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceId { get; set; }

        /// <summary>
        /// This is the model that will be used. Options are 'speech-02-hd' and 'speech-02-turbo'.<br/>
        /// speech-02-hd is optimized for high-fidelity applications like voiceovers and audiobooks.<br/>
        /// speech-02-turbo is designed for real-time applications with low latency.<br/>
        /// @default "speech-02-turbo"<br/>
        /// Default Value: speech-02-turbo<br/>
        /// Example: speech-02-turbo
        /// </summary>
        /// <example>speech-02-turbo</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FallbackMinimaxVoiceModelJsonConverter))]
        public global::G.FallbackMinimaxVoiceModel? Model { get; set; }

        /// <summary>
        /// The emotion to use for the voice. If not provided, will use auto-detect mode.<br/>
        /// Options include: 'happy', 'sad', 'angry', 'fearful', 'surprised', 'disgusted', 'neutral'<br/>
        /// Example: happy
        /// </summary>
        /// <example>happy</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("emotion")]
        public string? Emotion { get; set; }

        /// <summary>
        /// Voice pitch adjustment. Range from -12 to 12 semitones.<br/>
        /// @default 0<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pitch")]
        public double? Pitch { get; set; }

        /// <summary>
        /// Voice speed adjustment. Range from 0.5 to 2.0.<br/>
        /// @default 1.0<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// Voice volume adjustment. Range from 0.5 to 2.0.<br/>
        /// @default 1.0<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume")]
        public double? Volume { get; set; }

        /// <summary>
        /// The region for Minimax API. Defaults to "worldwide".<br/>
        /// Default Value: worldwide
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FallbackMinimaxVoiceRegionJsonConverter))]
        public global::G.FallbackMinimaxVoiceRegion? Region { get; set; }

        /// <summary>
        /// Language hint for MiniMax T2A. Example: yue (Cantonese), zh (Chinese), en (English).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languageBoost")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FallbackMinimaxVoiceLanguageBoostJsonConverter))]
        public global::G.FallbackMinimaxVoiceLanguageBoost? LanguageBoost { get; set; }

        /// <summary>
        /// Enable MiniMax text normalization to improve number reading and formatting.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("textNormalizationEnabled")]
        public bool? TextNormalizationEnabled { get; set; }

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
        /// Initializes a new instance of the <see cref="FallbackMinimaxVoice" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// This is the provider-specific ID that will be used. Use a voice from MINIMAX_PREDEFINED_VOICES or a custom cloned voice ID.
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
        /// This is the model that will be used. Options are 'speech-02-hd' and 'speech-02-turbo'.<br/>
        /// speech-02-hd is optimized for high-fidelity applications like voiceovers and audiobooks.<br/>
        /// speech-02-turbo is designed for real-time applications with low latency.<br/>
        /// @default "speech-02-turbo"<br/>
        /// Default Value: speech-02-turbo<br/>
        /// Example: speech-02-turbo
        /// </param>
        /// <param name="emotion">
        /// The emotion to use for the voice. If not provided, will use auto-detect mode.<br/>
        /// Options include: 'happy', 'sad', 'angry', 'fearful', 'surprised', 'disgusted', 'neutral'<br/>
        /// Example: happy
        /// </param>
        /// <param name="pitch">
        /// Voice pitch adjustment. Range from -12 to 12 semitones.<br/>
        /// @default 0<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="speed">
        /// Voice speed adjustment. Range from 0.5 to 2.0.<br/>
        /// @default 1.0<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="volume">
        /// Voice volume adjustment. Range from 0.5 to 2.0.<br/>
        /// @default 1.0<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="region">
        /// The region for Minimax API. Defaults to "worldwide".<br/>
        /// Default Value: worldwide
        /// </param>
        /// <param name="languageBoost">
        /// Language hint for MiniMax T2A. Example: yue (Cantonese), zh (Chinese), en (English).
        /// </param>
        /// <param name="textNormalizationEnabled">
        /// Enable MiniMax text normalization to improve number reading and formatting.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="chunkPlan">
        /// This is the plan for chunking the model output before it is sent to the voice provider.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FallbackMinimaxVoice(
            string voiceId,
            bool? cachingEnabled,
            global::G.FallbackMinimaxVoiceProvider provider,
            global::G.FallbackMinimaxVoiceModel? model,
            string? emotion,
            double? pitch,
            double? speed,
            double? volume,
            global::G.FallbackMinimaxVoiceRegion? region,
            global::G.FallbackMinimaxVoiceLanguageBoost? languageBoost,
            bool? textNormalizationEnabled,
            global::G.ChunkPlan? chunkPlan)
        {
            this.CachingEnabled = cachingEnabled;
            this.Provider = provider;
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
            this.Model = model;
            this.Emotion = emotion;
            this.Pitch = pitch;
            this.Speed = speed;
            this.Volume = volume;
            this.Region = region;
            this.LanguageBoost = languageBoost;
            this.TextNormalizationEnabled = textNormalizationEnabled;
            this.ChunkPlan = chunkPlan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackMinimaxVoice" /> class.
        /// </summary>
        public FallbackMinimaxVoice()
        {
        }
    }
}