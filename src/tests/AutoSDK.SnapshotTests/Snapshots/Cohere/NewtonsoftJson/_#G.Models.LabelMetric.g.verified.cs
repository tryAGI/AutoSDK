//HintName: G.Models.LabelMetric.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LabelMetric
    {
        /// <summary>
        /// Total number of examples for this label
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_examples")]
        public double? TotalExamples { get; set; }

        /// <summary>
        /// value of the label
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label")]
        public string? Label { get; set; }

        /// <summary>
        /// samples for this label
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("samples")]
        public global::System.Collections.Generic.IList<string>? Samples { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelMetric" /> class.
        /// </summary>
        /// <param name="totalExamples">
        /// Total number of examples for this label
        /// </param>
        /// <param name="label">
        /// value of the label
        /// </param>
        /// <param name="samples">
        /// samples for this label
        /// </param>
        public LabelMetric(
            double? totalExamples,
            string? label,
            global::System.Collections.Generic.IList<string>? samples)
        {
            this.TotalExamples = totalExamples;
            this.Label = label;
            this.Samples = samples;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelMetric" /> class.
        /// </summary>
        public LabelMetric()
        {
        }
    }
}