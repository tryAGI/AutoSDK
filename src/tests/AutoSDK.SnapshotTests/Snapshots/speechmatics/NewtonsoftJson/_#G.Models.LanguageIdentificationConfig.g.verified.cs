//HintName: G.Models.LanguageIdentificationConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LanguageIdentificationConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expected_languages")]
        public global::System.Collections.Generic.IList<string>? ExpectedLanguages { get; set; }

        /// <summary>
        /// Action to take if all of the predicted languages are below the confidence threshold
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("low_confidence_action")]
        public global::G.LanguageIdentificationConfigLowConfidenceAction? LowConfidenceAction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default_language")]
        public string? DefaultLanguage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageIdentificationConfig" /> class.
        /// </summary>
        /// <param name="expectedLanguages"></param>
        /// <param name="lowConfidenceAction">
        /// Action to take if all of the predicted languages are below the confidence threshold
        /// </param>
        /// <param name="defaultLanguage"></param>
        public LanguageIdentificationConfig(
            global::System.Collections.Generic.IList<string>? expectedLanguages,
            global::G.LanguageIdentificationConfigLowConfidenceAction? lowConfidenceAction,
            string? defaultLanguage)
        {
            this.ExpectedLanguages = expectedLanguages;
            this.LowConfidenceAction = lowConfidenceAction;
            this.DefaultLanguage = defaultLanguage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageIdentificationConfig" /> class.
        /// </summary>
        public LanguageIdentificationConfig()
        {
        }
    }
}