//HintName: G.Models.Sam2SegmentationResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Sam2SegmentationResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("predictions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Sam2SegmentationPrediction> Predictions { get; set; }

        /// <summary>
        /// The time in seconds it took to produce the segmentation including preprocessing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Time { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Sam2SegmentationResponse" /> class.
        /// </summary>
        /// <param name="predictions"></param>
        /// <param name="time">
        /// The time in seconds it took to produce the segmentation including preprocessing
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Sam2SegmentationResponse(
            global::System.Collections.Generic.IList<global::G.Sam2SegmentationPrediction> predictions,
            double time)
        {
            this.Predictions = predictions ?? throw new global::System.ArgumentNullException(nameof(predictions));
            this.Time = time;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Sam2SegmentationResponse" /> class.
        /// </summary>
        public Sam2SegmentationResponse()
        {
        }
    }
}