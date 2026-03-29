//HintName: G.Models.IndexedAssetDetailedEmbedding.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Contains the embedding and the associated information. The platform returns this field when the `embedding_option` parameter is specified in the request.
    /// </summary>
    public sealed partial class IndexedAssetDetailedEmbedding
    {
        /// <summary>
        /// The name of the video understanding model used to create the embedding.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_name")]
        public string? ModelName { get; set; }

        /// <summary>
        /// An object that contains the embeddings.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("video_embedding")]
        public global::G.IndexedAssetDetailedEmbeddingVideoEmbedding? VideoEmbedding { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexedAssetDetailedEmbedding" /> class.
        /// </summary>
        /// <param name="modelName">
        /// The name of the video understanding model used to create the embedding.
        /// </param>
        /// <param name="videoEmbedding">
        /// An object that contains the embeddings.
        /// </param>
        public IndexedAssetDetailedEmbedding(
            string? modelName,
            global::G.IndexedAssetDetailedEmbeddingVideoEmbedding? videoEmbedding)
        {
            this.ModelName = modelName;
            this.VideoEmbedding = videoEmbedding;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexedAssetDetailedEmbedding" /> class.
        /// </summary>
        public IndexedAssetDetailedEmbedding()
        {
        }
    }
}