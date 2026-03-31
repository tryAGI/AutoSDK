//HintName: G.Models.PiiDetectorConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for the PII (Personally Identifiable Information) detector.
    /// </summary>
    public sealed partial class PiiDetectorConfig
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
        /// List of PII entity types to detect. If not specified, all entity types are detected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entities")]
        public global::System.Collections.Generic.IList<string>? Entities { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PiiDetectorConfig" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether this detector is enabled.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="threshold">
        /// Confidence threshold (0.0 to 1.0).<br/>
        /// Default Value: 0.5
        /// </param>
        /// <param name="entities">
        /// List of PII entity types to detect. If not specified, all entity types are detected.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PiiDetectorConfig(
            bool? enabled,
            double? threshold,
            global::System.Collections.Generic.IList<string>? entities)
        {
            this.Enabled = enabled;
            this.Threshold = threshold;
            this.Entities = entities;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PiiDetectorConfig" /> class.
        /// </summary>
        public PiiDetectorConfig()
        {
        }
    }
}