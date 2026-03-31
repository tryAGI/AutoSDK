//HintName: G.Models.LanguageDetectorConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for the relevant language detector.
    /// </summary>
    public sealed partial class LanguageDetectorConfig
    {
        /// <summary>
        /// Whether this detector is enabled.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Confidence threshold (0.0 to 1.0).<br/>
        /// Default Value: 0.5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        public double? Threshold { get; set; }

        /// <summary>
        /// List of ISO 639-1 language codes that are considered relevant.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages")]
        public global::System.Collections.Generic.IList<string>? Languages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageDetectorConfig" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether this detector is enabled.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="threshold">
        /// Confidence threshold (0.0 to 1.0).<br/>
        /// Default Value: 0.5
        /// </param>
        /// <param name="languages">
        /// List of ISO 639-1 language codes that are considered relevant.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LanguageDetectorConfig(
            bool? enabled,
            double? threshold,
            global::System.Collections.Generic.IList<string>? languages)
        {
            this.Enabled = enabled;
            this.Threshold = threshold;
            this.Languages = languages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageDetectorConfig" /> class.
        /// </summary>
        public LanguageDetectorConfig()
        {
        }
    }
}