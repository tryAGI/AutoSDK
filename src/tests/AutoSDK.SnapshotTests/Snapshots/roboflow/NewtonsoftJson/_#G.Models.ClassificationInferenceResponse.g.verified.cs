//HintName: G.Models.ClassificationInferenceResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Classification inference response.<br/>
    /// Attributes:<br/>
    ///     predictions (List[inference.core.entities.responses.inference.ClassificationPrediction]): List of classification predictions.<br/>
    ///     top (str): The top predicted class label.<br/>
    ///     confidence (float): The confidence of the top predicted class label.
    /// </summary>
    public sealed partial class ClassificationInferenceResponse
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
        public global::System.Collections.Generic.IList<global::G.ClassificationPrediction> Predictions { get; set; } = default!;

        /// <summary>
        /// The top predicted class label
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top")]
        public string? Top { get; set; }

        /// <summary>
        /// The confidence of the top predicted class label<br/>
        /// Default Value: 0F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        /// Identifier of parent image region. Useful when stack of detection-models is in use to refer the RoI being the input to inference
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parent_id")]
        public string? ParentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassificationInferenceResponse" /> class.
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
        /// <param name="top">
        /// The top predicted class label
        /// </param>
        /// <param name="confidence">
        /// The confidence of the top predicted class label<br/>
        /// Default Value: 0F
        /// </param>
        /// <param name="parentId">
        /// Identifier of parent image region. Useful when stack of detection-models is in use to refer the RoI being the input to inference
        /// </param>
        public ClassificationInferenceResponse(
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.InferenceResponseImage>, global::G.InferenceResponseImage> image,
            global::System.Collections.Generic.IList<global::G.ClassificationPrediction> predictions,
            string? visualization,
            string? inferenceId,
            int? frameId,
            double? time,
            string? top,
            double? confidence,
            string? parentId)
        {
            this.Visualization = visualization;
            this.InferenceId = inferenceId;
            this.FrameId = frameId;
            this.Time = time;
            this.Image = image;
            this.Predictions = predictions ?? throw new global::System.ArgumentNullException(nameof(predictions));
            this.Top = top;
            this.Confidence = confidence;
            this.ParentId = parentId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassificationInferenceResponse" /> class.
        /// </summary>
        public ClassificationInferenceResponse()
        {
        }
    }
}