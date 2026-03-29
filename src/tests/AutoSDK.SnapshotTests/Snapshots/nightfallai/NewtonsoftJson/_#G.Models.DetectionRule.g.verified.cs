//HintName: G.Models.DetectionRule.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DetectionRule
    {
        /// <summary>
        /// Human-readable name for this detection rule
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// List of detectors to apply
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("detectors", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Detector> Detectors { get; set; } = default!;

        /// <summary>
        /// ANY = logical OR, ALL = logical AND
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logicalOp", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.LogicalOp LogicalOp { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectionRule" /> class.
        /// </summary>
        /// <param name="detectors">
        /// List of detectors to apply
        /// </param>
        /// <param name="logicalOp">
        /// ANY = logical OR, ALL = logical AND
        /// </param>
        /// <param name="name">
        /// Human-readable name for this detection rule
        /// </param>
        public DetectionRule(
            global::System.Collections.Generic.IList<global::G.Detector> detectors,
            global::G.LogicalOp logicalOp,
            string? name)
        {
            this.Name = name;
            this.Detectors = detectors ?? throw new global::System.ArgumentNullException(nameof(detectors));
            this.LogicalOp = logicalOp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectionRule" /> class.
        /// </summary>
        public DetectionRule()
        {
        }
    }
}