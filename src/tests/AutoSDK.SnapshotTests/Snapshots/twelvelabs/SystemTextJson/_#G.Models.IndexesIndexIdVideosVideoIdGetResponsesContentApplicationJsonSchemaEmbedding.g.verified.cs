//HintName: G.Models.IndexesIndexIdVideosVideoIdGetResponsesContentApplicationJsonSchemaEmbedding.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Contains the embedding and the associated information. The platform returns this field when the `embedding_option` parameter is specified in the request.
    /// </summary>
    public sealed partial class IndexesIndexIdVideosVideoIdGetResponsesContentApplicationJsonSchemaEmbedding
    {
        /// <summary>
        /// The name of the video understanding model used to create the embedding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        public string? ModelName { get; set; }

        /// <summary>
        /// An object that contains the embeddings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_embedding")]
        public global::G.IndexesIndexIdVideosVideoIdGetResponsesContentApplicationJsonSchemaEmbeddingVideoEmbedding? VideoEmbedding { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexesIndexIdVideosVideoIdGetResponsesContentApplicationJsonSchemaEmbedding" /> class.
        /// </summary>
        /// <param name="modelName">
        /// The name of the video understanding model used to create the embedding.
        /// </param>
        /// <param name="videoEmbedding">
        /// An object that contains the embeddings.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IndexesIndexIdVideosVideoIdGetResponsesContentApplicationJsonSchemaEmbedding(
            string? modelName,
            global::G.IndexesIndexIdVideosVideoIdGetResponsesContentApplicationJsonSchemaEmbeddingVideoEmbedding? videoEmbedding)
        {
            this.ModelName = modelName;
            this.VideoEmbedding = videoEmbedding;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexesIndexIdVideosVideoIdGetResponsesContentApplicationJsonSchemaEmbedding" /> class.
        /// </summary>
        public IndexesIndexIdVideosVideoIdGetResponsesContentApplicationJsonSchemaEmbedding()
        {
        }
    }
}