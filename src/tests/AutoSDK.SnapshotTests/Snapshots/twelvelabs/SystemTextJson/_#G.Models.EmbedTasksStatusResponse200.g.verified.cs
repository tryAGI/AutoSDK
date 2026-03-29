//HintName: G.Models.EmbedTasksStatusResponse200.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbedTasksStatusResponse200
    {
        /// <summary>
        /// The unique identifier of the video embedding task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        public string? Id { get; set; }

        /// <summary>
        /// A string indicating the status of the video indexing task. It can take one of the following values: `processing`, `ready` or `failed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// The name of the video understanding model the platform used to create the embedding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        public string? ModelName { get; set; }

        /// <summary>
        /// An object containing the metadata associated with the embedding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_embedding")]
        public global::G.EmbedTasksTaskIdStatusGetResponsesContentApplicationJsonSchemaVideoEmbedding? VideoEmbedding { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedTasksStatusResponse200" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the video embedding task.
        /// </param>
        /// <param name="status">
        /// A string indicating the status of the video indexing task. It can take one of the following values: `processing`, `ready` or `failed`.
        /// </param>
        /// <param name="modelName">
        /// The name of the video understanding model the platform used to create the embedding.
        /// </param>
        /// <param name="videoEmbedding">
        /// An object containing the metadata associated with the embedding.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbedTasksStatusResponse200(
            string? id,
            string? status,
            string? modelName,
            global::G.EmbedTasksTaskIdStatusGetResponsesContentApplicationJsonSchemaVideoEmbedding? videoEmbedding)
        {
            this.Id = id;
            this.Status = status;
            this.ModelName = modelName;
            this.VideoEmbedding = videoEmbedding;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedTasksStatusResponse200" /> class.
        /// </summary>
        public EmbedTasksStatusResponse200()
        {
        }
    }
}