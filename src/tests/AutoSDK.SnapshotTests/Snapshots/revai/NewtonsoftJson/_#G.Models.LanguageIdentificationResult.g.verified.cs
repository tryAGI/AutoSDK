//HintName: G.Models.LanguageIdentificationResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Language Identification Result
    /// </summary>
    public sealed partial class LanguageIdentificationResult
    {
        /// <summary>
        /// ISO language code of the most likely language
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_language")]
        public string? TopLanguage { get; set; }

        /// <summary>
        /// List of detected languages with confidence scores
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language_confidences")]
        public global::System.Collections.Generic.IList<global::G.LanguageConfidence>? LanguageConfidences { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageIdentificationResult" /> class.
        /// </summary>
        /// <param name="topLanguage">
        /// ISO language code of the most likely language
        /// </param>
        /// <param name="languageConfidences">
        /// List of detected languages with confidence scores
        /// </param>
        public LanguageIdentificationResult(
            string? topLanguage,
            global::System.Collections.Generic.IList<global::G.LanguageConfidence>? languageConfidences)
        {
            this.TopLanguage = topLanguage;
            this.LanguageConfidences = languageConfidences;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageIdentificationResult" /> class.
        /// </summary>
        public LanguageIdentificationResult()
        {
        }
    }
}