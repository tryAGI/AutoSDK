//HintName: G.Models.ClipCompareResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response for CLIP comparison.<br/>
    /// Attributes:<br/>
    ///     similarity (Union[List[float], Dict[str, float]]): Similarity scores.<br/>
    ///     time (float): The time in seconds it took to produce the similarity scores including preprocessing.
    /// </summary>
    public sealed partial class ClipCompareResponse
    {
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
        /// The time in seconds it took to produce the similarity scores including preprocessing
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("time")]
        public double? Time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("similarity", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.Dictionary<string, double>> Similarity { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="ClipCompareResponse" /> class.
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
        public ClipCompareResponse(
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
        /// Initializes a new instance of the <see cref="ClipCompareResponse" /> class.
        /// </summary>
        public ClipCompareResponse()
        {
        }
    }
}