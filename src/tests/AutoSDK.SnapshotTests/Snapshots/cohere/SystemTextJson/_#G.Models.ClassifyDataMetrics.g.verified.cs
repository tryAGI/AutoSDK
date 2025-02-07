//HintName: G.Models.ClassifyDataMetrics.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClassifyDataMetrics
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label_metrics")]
        public global::System.Collections.Generic.IList<global::G.LabelMetric>? LabelMetrics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyDataMetrics" /> class.
        /// </summary>
        /// <param name="labelMetrics"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClassifyDataMetrics(
            global::System.Collections.Generic.IList<global::G.LabelMetric>? labelMetrics)
        {
            this.LabelMetrics = labelMetrics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyDataMetrics" /> class.
        /// </summary>
        public ClassifyDataMetrics()
        {
        }
    }
}