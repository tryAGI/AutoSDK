//HintName: G.Models.EmbedTasksTaskIdGetResponsesContentApplicationJsonSchemaVideoEmbedding.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbedTasksTaskIdGetResponsesContentApplicationJsonSchemaVideoEmbedding
    {
        /// <summary>
        /// An object containing metadata associated with the embedding.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.VideoEmbeddingMetadata? Metadata { get; set; }

        /// <summary>
        /// An array of objects containing the embeddings for each video segment and the associated information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("segments")]
        public global::System.Collections.Generic.IList<global::G.VideoSegment>? Segments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedTasksTaskIdGetResponsesContentApplicationJsonSchemaVideoEmbedding" /> class.
        /// </summary>
        /// <param name="metadata">
        /// An object containing metadata associated with the embedding.
        /// </param>
        /// <param name="segments">
        /// An array of objects containing the embeddings for each video segment and the associated information.
        /// </param>
        public EmbedTasksTaskIdGetResponsesContentApplicationJsonSchemaVideoEmbedding(
            global::G.VideoEmbeddingMetadata? metadata,
            global::System.Collections.Generic.IList<global::G.VideoSegment>? segments)
        {
            this.Metadata = metadata;
            this.Segments = segments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedTasksTaskIdGetResponsesContentApplicationJsonSchemaVideoEmbedding" /> class.
        /// </summary>
        public EmbedTasksTaskIdGetResponsesContentApplicationJsonSchemaVideoEmbedding()
        {
        }
    }
}