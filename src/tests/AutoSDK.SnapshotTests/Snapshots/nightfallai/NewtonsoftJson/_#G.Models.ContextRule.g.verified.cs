//HintName: G.Models.ContextRule.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContextRule
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("regex", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Regex Regex { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("proximity", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Proximity Proximity { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("confidenceAdjustment", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ConfidenceAdjustment ConfidenceAdjustment { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextRule" /> class.
        /// </summary>
        /// <param name="regex"></param>
        /// <param name="proximity"></param>
        /// <param name="confidenceAdjustment"></param>
        public ContextRule(
            global::G.Regex regex,
            global::G.Proximity proximity,
            global::G.ConfidenceAdjustment confidenceAdjustment)
        {
            this.Regex = regex ?? throw new global::System.ArgumentNullException(nameof(regex));
            this.Proximity = proximity ?? throw new global::System.ArgumentNullException(nameof(proximity));
            this.ConfidenceAdjustment = confidenceAdjustment ?? throw new global::System.ArgumentNullException(nameof(confidenceAdjustment));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextRule" /> class.
        /// </summary>
        public ContextRule()
        {
        }
    }
}