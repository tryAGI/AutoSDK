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
        [global::System.Text.Json.Serialization.JsonPropertyName("total_examples")]
        public double? TotalExamples { get; set; }

        /// <summary>
        /// value of the label
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// samples for this label
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("samples")]
        public global::System.Collections.Generic.IList<string>? Samples { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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