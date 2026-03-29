//HintName: G.Models.InworldVoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InworldVoice
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
        public global::G.InworldVoiceProvider Provider { get; set; }

        /// <summary>
        /// Available voices by language:<br/>
        /// • en: Alex, Ashley, Craig, Deborah, Dennis, Edward, Elizabeth, Hades, Julia, Pixie, Mark, Olivia, Priya, Ronald, Sarah, Shaun, Theodore, Timothy, Wendy, Dominus, Hana, Clive, Carter, Blake, Luna<br/>
        /// • zh: Yichen, Xiaoyin, Xinyi, Jing<br/>
        /// • nl: Erik, Katrien, Lennart, Lore<br/>
        /// • fr: Alain, Hélène, Mathieu, Étienne<br/>
        /// • de: Johanna, Josef<br/>
        /// • it: Gianni, Orietta<br/>
        /// • ja: Asuka, Satoshi<br/>
        /// • ko: Hyunwoo, Minji, Seojun, Yoona<br/>
        /// • pl: Szymon, Wojciech<br/>
        /// • pt: Heitor, Maitê<br/>
        /// • es: Diego, Lupita, Miguel, Rafael<br/>
        /// • ru: Svetlana, Elena, Dmitry, Nikolai<br/>
        /// • hi: Riya, Manoj<br/>
        /// • he: Yael, Oren<br/>
        /// • ar: Nour, Omar<br/>
        /// Example: Alex
        /// </summary>
        /// <example>Alex</example>
        [global::Newtonsoft.Json.JsonProperty("voiceId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.InworldVoiceVoiceId VoiceId { get; set; } = default!;

        /// <summary>
        /// This is the model that will be used.<br/>
        /// Default Value: inworld-tts-1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public global::G.InworldVoiceModel? Model { get; set; }

        /// <summary>
        /// Language code for Inworld TTS synthesis<br/>
        /// Default Value: en
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("languageCode")]
        public global::G.InworldVoiceLanguageCode? LanguageCode { get; set; }

        /// <summary>
        /// A floating point number between 0, exclusive, and 2, inclusive. If equal to null or not provided, the model's default temperature of 1.1 will be used. The temperature parameter controls variance.<br/>
        /// Higher values will make the output more random and can lead to more expressive results. Lower values will make it more deterministic.<br/>
        /// See https://docs.inworld.ai/docs/tts/capabilities/generating-audio#additional-configurations for more details.<br/>
        /// Default Value: 1.1F<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// A floating point number between 0.5, inclusive, and 1.5, inclusive. If equal to null or not provided, the model's default speaking speed of 1.0 will be used.<br/>
        /// Values above 0.8 are recommended for higher quality.<br/>
        /// See https://docs.inworld.ai/docs/tts/capabilities/generating-audio#additional-configurations for more details.<br/>
        /// Default Value: 1<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::Newtonsoft.Json.JsonProperty("speakingRate")]
        public double? SpeakingRate { get; set; }

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
        /// Initializes a new instance of the <see cref="InworldVoice" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// Available voices by language:<br/>
        /// • en: Alex, Ashley, Craig, Deborah, Dennis, Edward, Elizabeth, Hades, Julia, Pixie, Mark, Olivia, Priya, Ronald, Sarah, Shaun, Theodore, Timothy, Wendy, Dominus, Hana, Clive, Carter, Blake, Luna<br/>
        /// • zh: Yichen, Xiaoyin, Xinyi, Jing<br/>
        /// • nl: Erik, Katrien, Lennart, Lore<br/>
        /// • fr: Alain, Hélène, Mathieu, Étienne<br/>
        /// • de: Johanna, Josef<br/>
        /// • it: Gianni, Orietta<br/>
        /// • ja: Asuka, Satoshi<br/>
        /// • ko: Hyunwoo, Minji, Seojun, Yoona<br/>
        /// • pl: Szymon, Wojciech<br/>
        /// • pt: Heitor, Maitê<br/>
        /// • es: Diego, Lupita, Miguel, Rafael<br/>
        /// • ru: Svetlana, Elena, Dmitry, Nikolai<br/>
        /// • hi: Riya, Manoj<br/>
        /// • he: Yael, Oren<br/>
        /// • ar: Nour, Omar<br/>
        /// Example: Alex
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
        /// Default Value: inworld-tts-1
        /// </param>
        /// <param name="languageCode">
        /// Language code for Inworld TTS synthesis<br/>
        /// Default Value: en
        /// </param>
        /// <param name="temperature">
        /// A floating point number between 0, exclusive, and 2, inclusive. If equal to null or not provided, the model's default temperature of 1.1 will be used. The temperature parameter controls variance.<br/>
        /// Higher values will make the output more random and can lead to more expressive results. Lower values will make it more deterministic.<br/>
        /// See https://docs.inworld.ai/docs/tts/capabilities/generating-audio#additional-configurations for more details.<br/>
        /// Default Value: 1.1F<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="speakingRate">
        /// A floating point number between 0.5, inclusive, and 1.5, inclusive. If equal to null or not provided, the model's default speaking speed of 1.0 will be used.<br/>
        /// Values above 0.8 are recommended for higher quality.<br/>
        /// See https://docs.inworld.ai/docs/tts/capabilities/generating-audio#additional-configurations for more details.<br/>
        /// Default Value: 1<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="chunkPlan">
        /// This is the plan for chunking the model output before it is sent to the voice provider.
        /// </param>
        /// <param name="fallbackPlan">
        /// This is the plan for voice provider fallbacks in the event that the primary voice provider fails.
        /// </param>
        public InworldVoice(
            global::G.InworldVoiceVoiceId voiceId,
            bool? cachingEnabled,
            global::G.InworldVoiceProvider provider,
            global::G.InworldVoiceModel? model,
            global::G.InworldVoiceLanguageCode? languageCode,
            double? temperature,
            double? speakingRate,
            global::G.ChunkPlan? chunkPlan,
            global::G.FallbackPlan? fallbackPlan)
        {
            this.CachingEnabled = cachingEnabled;
            this.Provider = provider;
            this.VoiceId = voiceId;
            this.Model = model;
            this.LanguageCode = languageCode;
            this.Temperature = temperature;
            this.SpeakingRate = speakingRate;
            this.ChunkPlan = chunkPlan;
            this.FallbackPlan = fallbackPlan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InworldVoice" /> class.
        /// </summary>
        public InworldVoice()
        {
        }
    }
}