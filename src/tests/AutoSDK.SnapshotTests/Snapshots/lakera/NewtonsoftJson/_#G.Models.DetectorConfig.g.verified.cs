//HintName: G.Models.DetectorConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for a threat detector.
    /// </summary>
    public sealed partial class DetectorConfig
    {
        /// <summary>
        /// Whether this detector is enabled.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Confidence threshold (0.0 to 1.0). Content is flagged if the detector confidence exceeds this value.<br/>
        /// Default Value: 0.5
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("threshold")]
        public double? Threshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectorConfig" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether this detector is enabled.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="threshold">
        /// Confidence threshold (0.0 to 1.0). Content is flagged if the detector confidence exceeds this value.<br/>
        /// Default Value: 0.5
        /// </param>
        public DetectorConfig(
            bool? enabled,
            double? threshold)
        {
            this.Enabled = enabled;
            this.Threshold = threshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectorConfig" /> class.
        /// </summary>
        public DetectorConfig()
        {
        }
    }
}