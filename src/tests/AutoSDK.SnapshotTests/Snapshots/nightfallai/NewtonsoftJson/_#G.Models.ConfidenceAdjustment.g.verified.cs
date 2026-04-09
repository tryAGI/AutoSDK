//HintName: G.Models.ConfidenceAdjustment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConfidenceAdjustment
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fixedConfidence", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfidenceJsonConverter))]
        public global::G.Confidence FixedConfidence { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfidenceAdjustment" /> class.
        /// </summary>
        /// <param name="fixedConfidence"></param>
        public ConfidenceAdjustment(
            global::G.Confidence fixedConfidence)
        {
            this.FixedConfidence = fixedConfidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfidenceAdjustment" /> class.
        /// </summary>
        public ConfidenceAdjustment()
        {
        }
    }
}