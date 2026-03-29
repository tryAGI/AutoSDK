//HintName: G.Models.SemanticSegmentationPrediction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SemanticSegmentationPrediction
    {
        /// <summary>
        /// base64-encoded PNG of predicted class label at each pixel
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segmentation_mask")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SegmentationMask { get; set; }

        /// <summary>
        /// Map of pixel intensity value to class label
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class_map")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> ClassMap { get; set; }

        /// <summary>
        /// base64-encoded PNG of predicted class confidence at each pixel
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence_mask")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConfidenceMask { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SemanticSegmentationPrediction" /> class.
        /// </summary>
        /// <param name="segmentationMask">
        /// base64-encoded PNG of predicted class label at each pixel
        /// </param>
        /// <param name="classMap">
        /// Map of pixel intensity value to class label
        /// </param>
        /// <param name="confidenceMask">
        /// base64-encoded PNG of predicted class confidence at each pixel
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SemanticSegmentationPrediction(
            string segmentationMask,
            global::System.Collections.Generic.Dictionary<string, string> classMap,
            string confidenceMask)
        {
            this.SegmentationMask = segmentationMask ?? throw new global::System.ArgumentNullException(nameof(segmentationMask));
            this.ClassMap = classMap ?? throw new global::System.ArgumentNullException(nameof(classMap));
            this.ConfidenceMask = confidenceMask ?? throw new global::System.ArgumentNullException(nameof(confidenceMask));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SemanticSegmentationPrediction" /> class.
        /// </summary>
        public SemanticSegmentationPrediction()
        {
        }
    }
}