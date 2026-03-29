//HintName: G.Models.PerceptionEncoderCompareResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response for PERCEPTION_ENCODER comparison.<br/>
    /// Attributes:<br/>
    ///     similarity (Union[List[float], Dict[str, float]]): Similarity scores.<br/>
    ///     time (float): The time in seconds it took to produce the similarity scores including preprocessing.
    /// </summary>
    public sealed partial class PerceptionEncoderCompareResponse
    {
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
        /// The time in seconds it took to produce the similarity scores including preprocessing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time")]
        public double? Time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("similarity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.Dictionary<string, double>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.Dictionary<string, double>> Similarity { get; set; }

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
        /// Initializes a new instance of the <see cref="PerceptionEncoderCompareResponse" /> class.
        /// </summary>
        /// <param name="similarity"></param>
        /// <param name="inferenceId">
        /// Unique identifier of inference
        /// </param>
        /// <param name="frameId">
        /// The frame id of the image used in inference if the input was a video
        /// </param>
        /// <param name="time">
        /// The time in seconds it took to produce the similarity scores including preprocessing
        /// </param>
        /// <param name="parentId">
        /// Identifier of parent image region. Useful when stack of detection-models is in use to refer the RoI being the input to inference
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PerceptionEncoderCompareResponse(
            global::G.AnyOf<global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.Dictionary<string, double>> similarity,
            string? inferenceId,
            int? frameId,
            double? time,
            string? parentId)
        {
            this.InferenceId = inferenceId;
            this.FrameId = frameId;
            this.Time = time;
            this.Similarity = similarity;
            this.ParentId = parentId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PerceptionEncoderCompareResponse" /> class.
        /// </summary>
        public PerceptionEncoderCompareResponse()
        {
        }
    }
}