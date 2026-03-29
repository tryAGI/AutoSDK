//HintName: G.Models.PerceptionEncoderEmbeddingResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response for PERCEPTION_ENCODER embedding.<br/>
    /// Attributes:<br/>
    ///     embeddings (List[List[float]]): A list of embeddings, each embedding is a list of floats.<br/>
    ///     time (float): The time in seconds it took to produce the embeddings including preprocessing.
    /// </summary>
    public sealed partial class PerceptionEncoderEmbeddingResponse
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
        /// The time in seconds it took to produce the embeddings including preprocessing
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("time")]
        public double? Time { get; set; }

        /// <summary>
        /// A list of embeddings, each embedding is a list of floats
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embeddings", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>> Embeddings { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PerceptionEncoderEmbeddingResponse" /> class.
        /// </summary>
        /// <param name="embeddings">
        /// A list of embeddings, each embedding is a list of floats
        /// </param>
        /// <param name="inferenceId">
        /// Unique identifier of inference
        /// </param>
        /// <param name="frameId">
        /// The frame id of the image used in inference if the input was a video
        /// </param>
        /// <param name="time">
        /// The time in seconds it took to produce the embeddings including preprocessing
        /// </param>
        public PerceptionEncoderEmbeddingResponse(
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>> embeddings,
            string? inferenceId,
            int? frameId,
            double? time)
        {
            this.InferenceId = inferenceId;
            this.FrameId = frameId;
            this.Time = time;
            this.Embeddings = embeddings ?? throw new global::System.ArgumentNullException(nameof(embeddings));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PerceptionEncoderEmbeddingResponse" /> class.
        /// </summary>
        public PerceptionEncoderEmbeddingResponse()
        {
        }
    }
}