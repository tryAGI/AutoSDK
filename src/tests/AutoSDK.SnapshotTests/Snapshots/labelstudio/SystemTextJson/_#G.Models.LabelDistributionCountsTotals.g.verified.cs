//HintName: G.Models.LabelDistributionCountsTotals.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LabelDistributionCountsTotals
    {
        /// <summary>
        /// Total annotation counts keyed by dimension name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotation_totals_by_dimension")]
        public global::System.Collections.Generic.Dictionary<string, int>? AnnotationTotalsByDimension { get; set; }

        /// <summary>
        /// Total prediction counts keyed by dimension name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prediction_totals_by_dimension")]
        public global::System.Collections.Generic.Dictionary<string, int>? PredictionTotalsByDimension { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelDistributionCountsTotals" /> class.
        /// </summary>
        /// <param name="annotationTotalsByDimension">
        /// Total annotation counts keyed by dimension name.
        /// </param>
        /// <param name="predictionTotalsByDimension">
        /// Total prediction counts keyed by dimension name.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LabelDistributionCountsTotals(
            global::System.Collections.Generic.Dictionary<string, int>? annotationTotalsByDimension,
            global::System.Collections.Generic.Dictionary<string, int>? predictionTotalsByDimension)
        {
            this.AnnotationTotalsByDimension = annotationTotalsByDimension;
            this.PredictionTotalsByDimension = predictionTotalsByDimension;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelDistributionCountsTotals" /> class.
        /// </summary>
        public LabelDistributionCountsTotals()
        {
        }
    }
}