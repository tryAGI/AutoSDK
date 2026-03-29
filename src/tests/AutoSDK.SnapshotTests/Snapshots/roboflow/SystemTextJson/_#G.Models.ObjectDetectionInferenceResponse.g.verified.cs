//HintName: G.Models.ObjectDetectionInferenceResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Object Detection inference response.<br/>
    /// Attributes:<br/>
    ///     predictions (List[inference.core.entities.responses.inference.ObjectDetectionPrediction]): List of object detection predictions.
    /// </summary>
    public sealed partial class ObjectDetectionInferenceResponse
    {
        /// <summary>
        /// Base64 encoded string containing prediction visualization image data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visualization")]
        public string? Visualization { get; set; }

        /// <summary>
        /// Unique identifier of inference
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inference_id")]
        public string? InferenceId { get; set; }

        /// <summary>
        /// The frame id of the image used in inference if the input was a video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frame_id")]
        public int? FrameId { get; set; }

        /// <summary>
        /// The time in seconds it took to produce the predictions including image preprocessing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time")]
        public double? Time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.InferenceResponseImage>, global::G.InferenceResponseImage>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<global::System.Collections.Generic.IList<global::G.InferenceResponseImage>, global::G.InferenceResponseImage> Image { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("predictions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ObjectDetectionPrediction> Predictions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectDetectionInferenceResponse" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ObjectDetectionInferenceResponse(
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.InferenceResponseImage>, global::G.InferenceResponseImage> image,
            global::System.Collections.Generic.IList<global::G.ObjectDetectionPrediction> predictions,
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
        /// Initializes a new instance of the <see cref="ObjectDetectionInferenceResponse" /> class.
        /// </summary>
        public ObjectDetectionInferenceResponse()
        {
        }
    }
}