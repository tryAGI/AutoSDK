//HintName: G.Models.SonioxTranscriber.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SonioxTranscriber
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SonioxTranscriberProviderJsonConverter))]
        public global::G.SonioxTranscriberProvider Provider { get; set; }

        /// <summary>
        /// The Soniox model to use for transcription.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SonioxTranscriberModelJsonConverter))]
        public global::G.SonioxTranscriberModel? Model { get; set; }

        /// <summary>
        /// The language for transcription. Uses ISO 639-1 codes. Soniox supports 60+ languages with a single universal model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SonioxTranscriberLanguageJsonConverter))]
        public global::G.SonioxTranscriberLanguage? Language { get; set; }

        /// <summary>
        /// When enabled, restricts transcription to the language specified in the language field. When disabled, the model can detect and transcribe any of 60+ supported languages. Defaults to true.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("languageHintsStrict")]
        public bool? LanguageHintsStrict { get; set; }

        /// <summary>
        /// Maximum delay in milliseconds between when the speaker stops and when the endpoint is detected. Lower values mean faster turn-taking but more false endpoints. Range: 500-3000. Default: 500.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maxEndpointDelayMs")]
        public double? MaxEndpointDelayMs { get; set; }

        /// <summary>
        /// Custom vocabulary terms to boost recognition accuracy. Useful for brand names, product names, and domain-specific terminology. Maps to Soniox context.terms.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("customVocabulary")]
        public global::System.Collections.Generic.IList<string>? CustomVocabulary { get; set; }

        /// <summary>
        /// This is the plan for transcriber provider fallbacks in the event that the primary transcriber provider fails.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fallbackPlan")]
        public global::G.FallbackTranscriberPlan? FallbackPlan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SonioxTranscriber" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="model">
        /// The Soniox model to use for transcription.
        /// </param>
        /// <param name="language">
        /// The language for transcription. Uses ISO 639-1 codes. Soniox supports 60+ languages with a single universal model.
        /// </param>
        /// <param name="languageHintsStrict">
        /// When enabled, restricts transcription to the language specified in the language field. When disabled, the model can detect and transcribe any of 60+ supported languages. Defaults to true.
        /// </param>
        /// <param name="maxEndpointDelayMs">
        /// Maximum delay in milliseconds between when the speaker stops and when the endpoint is detected. Lower values mean faster turn-taking but more false endpoints. Range: 500-3000. Default: 500.
        /// </param>
        /// <param name="customVocabulary">
        /// Custom vocabulary terms to boost recognition accuracy. Useful for brand names, product names, and domain-specific terminology. Maps to Soniox context.terms.
        /// </param>
        /// <param name="fallbackPlan">
        /// This is the plan for transcriber provider fallbacks in the event that the primary transcriber provider fails.
        /// </param>
        public SonioxTranscriber(
            global::G.SonioxTranscriberProvider provider,
            global::G.SonioxTranscriberModel? model,
            global::G.SonioxTranscriberLanguage? language,
            bool? languageHintsStrict,
            double? maxEndpointDelayMs,
            global::System.Collections.Generic.IList<string>? customVocabulary,
            global::G.FallbackTranscriberPlan? fallbackPlan)
        {
            this.Provider = provider;
            this.Model = model;
            this.Language = language;
            this.LanguageHintsStrict = languageHintsStrict;
            this.MaxEndpointDelayMs = maxEndpointDelayMs;
            this.CustomVocabulary = customVocabulary;
            this.FallbackPlan = fallbackPlan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SonioxTranscriber" /> class.
        /// </summary>
        public SonioxTranscriber()
        {
        }
    }
}