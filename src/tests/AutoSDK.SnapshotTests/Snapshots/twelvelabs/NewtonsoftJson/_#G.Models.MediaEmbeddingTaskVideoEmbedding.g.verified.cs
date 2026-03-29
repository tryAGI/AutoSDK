//HintName: G.Models.MediaEmbeddingTaskVideoEmbedding.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An object containing the metadata associated with the embedding.
    /// </summary>
    public sealed partial class MediaEmbeddingTaskVideoEmbedding
    {
        /// <summary>
        /// An object containing metadata associated with the embedding.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.VideoEmbeddingMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaEmbeddingTaskVideoEmbedding" /> class.
        /// </summary>
        /// <param name="metadata">
        /// An object containing metadata associated with the embedding.
        /// </param>
        public MediaEmbeddingTaskVideoEmbedding(
            global::G.VideoEmbeddingMetadata? metadata)
        {
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaEmbeddingTaskVideoEmbedding" /> class.
        /// </summary>
        public MediaEmbeddingTaskVideoEmbedding()
        {
        }
    }
}