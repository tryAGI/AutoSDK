//HintName: G.Models.OCRInferenceResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// OCR Inference response.<br/>
    /// Attributes:<br/>
    ///     result (str): The combined OCR recognition result.<br/>
    ///     predictions (List[ObjectDetectionPrediction]): List of objects detected by OCR<br/>
    ///     time (float): The time in seconds it took to produce the inference including preprocessing
    /// </summary>
    public sealed partial class OCRInferenceResponse
    {
        /// <summary>
        /// The combined OCR recognition result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Result { get; set; }

        /// <summary>
        /// Metadata about input image dimensions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public global::G.InferenceResponseImage? Image { get; set; }

        /// <summary>
        /// List of objects detected by OCR
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("predictions")]
        public global::System.Collections.Generic.IList<global::G.ObjectDetectionPrediction>? Predictions { get; set; }

        /// <summary>
        /// The time in seconds it took to produce the inference including preprocessing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Time { get; set; }

        /// <summary>
        /// Identifier of parent image region. Useful when stack of detection-models is in use to refer the RoI being the input to inference
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_id")]
        public string? ParentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OCRInferenceResponse" /> class.
        /// </summary>
        /// <param name="result">
        /// The combined OCR recognition result.
        /// </param>
        /// <param name="time">
        /// The time in seconds it took to produce the inference including preprocessing.
        /// </param>
        /// <param name="image">
        /// Metadata about input image dimensions
        /// </param>
        /// <param name="predictions">
        /// List of objects detected by OCR
        /// </param>
        /// <param name="parentId">
        /// Identifier of parent image region. Useful when stack of detection-models is in use to refer the RoI being the input to inference
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OCRInferenceResponse(
            string result,
            double time,
            global::G.InferenceResponseImage? image,
            global::System.Collections.Generic.IList<global::G.ObjectDetectionPrediction>? predictions,
            string? parentId)
        {
            this.Result = result ?? throw new global::System.ArgumentNullException(nameof(result));
            this.Image = image;
            this.Predictions = predictions;
            this.Time = time;
            this.ParentId = parentId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OCRInferenceResponse" /> class.
        /// </summary>
        public OCRInferenceResponse()
        {
        }
    }
}