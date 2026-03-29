//HintName: G.Models.Sam2EmbeddingResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// SAM embedding response.<br/>
    /// Attributes:<br/>
    ///     embeddings (Union[List[List[List[List[float]]]], Any]): The SAM embedding.<br/>
    ///     time (float): The time in seconds it took to produce the embeddings including preprocessing.
    /// </summary>
    public sealed partial class Sam2EmbeddingResponse
    {
        /// <summary>
        /// Image id embeddings are cached to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ImageId { get; set; }

        /// <summary>
        /// The time in seconds it took to produce the embeddings including preprocessing
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
        /// Initializes a new instance of the <see cref="Sam2EmbeddingResponse" /> class.
        /// </summary>
        /// <param name="imageId">
        /// Image id embeddings are cached to
        /// </param>
        /// <param name="time">
        /// The time in seconds it took to produce the embeddings including preprocessing
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Sam2EmbeddingResponse(
            string imageId,
            double time)
        {
            this.ImageId = imageId ?? throw new global::System.ArgumentNullException(nameof(imageId));
            this.Time = time;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Sam2EmbeddingResponse" /> class.
        /// </summary>
        public Sam2EmbeddingResponse()
        {
        }
    }
}