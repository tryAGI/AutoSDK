//HintName: G.Models.EmbeddingResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An object that contains the generated embedding vector and associated information.
    /// </summary>
    public sealed partial class EmbeddingResponse
    {
        /// <summary>
        /// The name of the video understanding model the platform has used to create this embedding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelName { get; set; }

        /// <summary>
        /// An object that contains the generated text embedding vector and associated information. Present when text was processed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_embedding")]
        public global::G.TextEmbeddingResult? TextEmbedding { get; set; }

        /// <summary>
        /// An object that contains the generated image embedding vector and associated information. Present when image was processed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_embedding")]
        public global::G.ImageEmbeddingResult? ImageEmbedding { get; set; }

        /// <summary>
        /// An object that contains the generated audio embedding vector and associated information. Present when audio was processed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_embedding")]
        public global::G.AudioEmbeddingResult? AudioEmbedding { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingResponse" /> class.
        /// </summary>
        /// <param name="modelName">
        /// The name of the video understanding model the platform has used to create this embedding.
        /// </param>
        /// <param name="textEmbedding">
        /// An object that contains the generated text embedding vector and associated information. Present when text was processed.
        /// </param>
        /// <param name="imageEmbedding">
        /// An object that contains the generated image embedding vector and associated information. Present when image was processed.
        /// </param>
        /// <param name="audioEmbedding">
        /// An object that contains the generated audio embedding vector and associated information. Present when audio was processed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbeddingResponse(
            string modelName,
            global::G.TextEmbeddingResult? textEmbedding,
            global::G.ImageEmbeddingResult? imageEmbedding,
            global::G.AudioEmbeddingResult? audioEmbedding)
        {
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.TextEmbedding = textEmbedding;
            this.ImageEmbedding = imageEmbedding;
            this.AudioEmbedding = audioEmbedding;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingResponse" /> class.
        /// </summary>
        public EmbeddingResponse()
        {
        }
    }
}