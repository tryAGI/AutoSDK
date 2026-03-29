//HintName: G.Models.EmbedTasksRetrieveResponse200.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbedTasksRetrieveResponse200
    {
        /// <summary>
        /// The unique identifier of the video embedding task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        public string? Id { get; set; }

        /// <summary>
        /// The name of the video understanding model the platform used to create the embedding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        public string? ModelName { get; set; }

        /// <summary>
        /// A string indicating the status of the video indexing task. It can take one of the following values: `processing`, `ready` or `failed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// A string representing the date and time, in RFC 3339 format (“YYYY-MM-DDTHH:mm:ssZ”), when the resource was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// A string representing the date and time, in RFC 3339 format (“YYYY-MM-DDTHH:mm:ssZ”), when the resource was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_embedding")]
        public global::G.EmbedTasksTaskIdGetResponsesContentApplicationJsonSchemaVideoEmbedding? VideoEmbedding { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedTasksRetrieveResponse200" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the video embedding task.
        /// </param>
        /// <param name="modelName">
        /// The name of the video understanding model the platform used to create the embedding.
        /// </param>
        /// <param name="status">
        /// A string indicating the status of the video indexing task. It can take one of the following values: `processing`, `ready` or `failed`.
        /// </param>
        /// <param name="createdAt">
        /// A string representing the date and time, in RFC 3339 format (“YYYY-MM-DDTHH:mm:ssZ”), when the resource was created.
        /// </param>
        /// <param name="updatedAt">
        /// A string representing the date and time, in RFC 3339 format (“YYYY-MM-DDTHH:mm:ssZ”), when the resource was last updated.
        /// </param>
        /// <param name="videoEmbedding"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbedTasksRetrieveResponse200(
            string? id,
            string? modelName,
            string? status,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            global::G.EmbedTasksTaskIdGetResponsesContentApplicationJsonSchemaVideoEmbedding? videoEmbedding)
        {
            this.Id = id;
            this.ModelName = modelName;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.VideoEmbedding = videoEmbedding;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedTasksRetrieveResponse200" /> class.
        /// </summary>
        public EmbedTasksRetrieveResponse200()
        {
        }
    }
}