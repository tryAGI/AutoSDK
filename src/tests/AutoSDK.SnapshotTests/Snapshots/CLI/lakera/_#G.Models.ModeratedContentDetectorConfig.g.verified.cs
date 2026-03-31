//HintName: G.Models.ModeratedContentDetectorConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for the moderated content detector (toxicity, hate speech, etc.).
    /// </summary>
    public sealed partial class ModeratedContentDetectorConfig
    {
        /// <summary>
        /// Whether this detector is enabled.<br/>
        /// Default Value: true
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
        /// List of moderated content categories to detect.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("categories")]
        public global::System.Collections.Generic.IList<global::G.ModeratedContentDetectorConfigCategorie>? Categories { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModeratedContentDetectorConfig" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether this detector is enabled.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="threshold">
        /// Confidence threshold (0.0 to 1.0).<br/>
        /// Default Value: 0.5
        /// </param>
        /// <param name="categories">
        /// List of moderated content categories to detect.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModeratedContentDetectorConfig(
            bool? enabled,
            double? threshold,
            global::System.Collections.Generic.IList<global::G.ModeratedContentDetectorConfigCategorie>? categories)
        {
            this.Enabled = enabled;
            this.Threshold = threshold;
            this.Categories = categories;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModeratedContentDetectorConfig" /> class.
        /// </summary>
        public ModeratedContentDetectorConfig()
        {
        }
    }
}