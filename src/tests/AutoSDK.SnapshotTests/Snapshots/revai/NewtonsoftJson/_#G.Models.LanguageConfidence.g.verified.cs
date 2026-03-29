//HintName: G.Models.LanguageConfidence.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LanguageConfidence
    {
        /// <summary>
        /// ISO language code
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Confidence score for the language detection
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageConfidence" /> class.
        /// </summary>
        /// <param name="language">
        /// ISO language code
        /// </param>
        /// <param name="confidence">
        /// Confidence score for the language detection
        /// </param>
        public LanguageConfidence(
            string? language,
            double? confidence)
        {
            this.Language = language;
            this.Confidence = confidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageConfidence" /> class.
        /// </summary>
        public LanguageConfidence()
        {
        }
    }
}