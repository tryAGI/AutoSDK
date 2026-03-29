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
        [global::Newtonsoft.Json.JsonProperty("segmentation_mask", Required = global::Newtonsoft.Json.Required.Always)]
        public string SegmentationMask { get; set; } = default!;

        /// <summary>
        /// Map of pixel intensity value to class label
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("class_map", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, string> ClassMap { get; set; } = default!;

        /// <summary>
        /// base64-encoded PNG of predicted class confidence at each pixel
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("confidence_mask", Required = global::Newtonsoft.Json.Required.Always)]
        public string ConfidenceMask { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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