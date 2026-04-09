//HintName: G.Models.CartesiaTranscriber.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CartesiaTranscriber
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CartesiaTranscriberProviderJsonConverter))]
        public global::G.CartesiaTranscriberProvider Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CartesiaTranscriberModelJsonConverter))]
        public global::G.CartesiaTranscriberModel? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CartesiaTranscriberLanguageJsonConverter))]
        public global::G.CartesiaTranscriberLanguage? Language { get; set; }

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
        /// Initializes a new instance of the <see cref="CartesiaTranscriber" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="model"></param>
        /// <param name="language"></param>
        /// <param name="fallbackPlan">
        /// This is the plan for transcriber provider fallbacks in the event that the primary transcriber provider fails.
        /// </param>
        public CartesiaTranscriber(
            global::G.CartesiaTranscriberProvider provider,
            global::G.CartesiaTranscriberModel? model,
            global::G.CartesiaTranscriberLanguage? language,
            global::G.FallbackTranscriberPlan? fallbackPlan)
        {
            this.Provider = provider;
            this.Model = model;
            this.Language = language;
            this.FallbackPlan = fallbackPlan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CartesiaTranscriber" /> class.
        /// </summary>
        public CartesiaTranscriber()
        {
        }
    }
}