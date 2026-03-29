//HintName: G.Models.SemanticSegmentationInferenceResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Semantic Segmentation inference response.<br/>
    /// Attributes:<br/>
    ///     predictions (inference.core.entities.responses.inference.SemanticSegmentationPrediction): Semantic segmentation predictions.
    /// </summary>
    public sealed partial class SemanticSegmentationInferenceResponse
    {
        /// <summary>
        /// Base64 encoded string containing prediction visualization image data
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("visualization")]
        public string? Visualization { get; set; }

        /// <summary>
        /// Unique identifier of inference
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inference_id")]
        public string? InferenceId { get; set; }

        /// <summary>
        /// The frame id of the image used in inference if the input was a video
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("frame_id")]
        public int? FrameId { get; set; }

        /// <summary>
        /// The time in seconds it took to produce the predictions including image preprocessing
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("time")]
        public double? Time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<global::System.Collections.Generic.IList<global::G.InferenceResponseImage>, global::G.InferenceResponseImage> Image { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("predictions", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SemanticSegmentationPrediction Predictions { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SemanticSegmentationInferenceResponse" /> class.
        /// </summary>
        /// <param name="image"></param>
        /// <param name="predictions"></param>
        /// <param name="visualization">
        /// Base64 encoded string containing prediction visualization image data
        /// </param>
        /// <param name="inferenceId">
        /// Unique identifier of inference
        /// </param>
        /// <param name="frameId">
        /// The frame id of the image used in inference if the input was a video
        /// </param>
        /// <param name="time">
        /// The time in seconds it took to produce the predictions including image preprocessing
        /// </param>
        public SemanticSegmentationInferenceResponse(
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.InferenceResponseImage>, global::G.InferenceResponseImage> image,
            global::G.SemanticSegmentationPrediction predictions,
            string? visualization,
            string? inferenceId,
            int? frameId,
            double? time)
        {
            this.Visualization = visualization;
            this.InferenceId = inferenceId;
            this.FrameId = frameId;
            this.Time = time;
            this.Image = image;
            this.Predictions = predictions ?? throw new global::System.ArgumentNullException(nameof(predictions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SemanticSegmentationInferenceResponse" /> class.
        /// </summary>
        public SemanticSegmentationInferenceResponse()
        {
        }
    }
}