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
        [global::Newtonsoft.Json.JsonProperty("predictions", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Sam2SegmentationPrediction> Predictions { get; set; } = default!;

        /// <summary>
        /// The time in seconds it took to produce the segmentation including preprocessing
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("time", Required = global::Newtonsoft.Json.Required.Always)]
        public double Time { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Sam2SegmentationResponse" /> class.
        /// </summary>
        /// <param name="predictions"></param>
        /// <param name="time">
        /// The time in seconds it took to produce the segmentation including preprocessing
        /// </param>
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