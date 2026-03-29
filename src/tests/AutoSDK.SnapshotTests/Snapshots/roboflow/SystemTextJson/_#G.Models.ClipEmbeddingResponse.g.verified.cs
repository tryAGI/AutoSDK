//HintName: G.Models.ClipEmbeddingResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response for CLIP embedding.<br/>
    /// Attributes:<br/>
    ///     embeddings (List[List[float]]): A list of embeddings, each embedding is a list of floats.<br/>
    ///     time (float): The time in seconds it took to produce the embeddings including preprocessing.
    /// </summary>
    public sealed partial class ClipEmbeddingResponse
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
        /// The time in seconds it took to produce the embeddings including preprocessing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time")]
        public double? Time { get; set; }

        /// <summary>
        /// A list of embeddings, each embedding is a list of floats
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embeddings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>> Embeddings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClipEmbeddingResponse" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClipEmbeddingResponse(
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
        /// Initializes a new instance of the <see cref="ClipEmbeddingResponse" /> class.
        /// </summary>
        public ClipEmbeddingResponse()
        {
        }
    }
}