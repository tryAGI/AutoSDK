//HintName: G.Models.EmbeddingTaskResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An object containing the status of the embedding task and the embeddings (when ready).
    /// </summary>
    public sealed partial class EmbeddingTaskResponse
    {
        /// <summary>
        /// The unique identifier of the embedding task.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The current status of the task.<br/>
        /// **Values**:<br/>
        /// - `processing`: The platform is creating the embeddings<br/>
        /// - `ready`: Processing is complete. Embeddings are available in the `data` field<br/>
        /// - `failed`: The task failed. The `data` field is `null`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EmbeddingTaskResponseStatus Status { get; set; } = default!;

        /// <summary>
        /// A string representing the date and time, in RFC 3339 format (“YYYY-MM-DDTHH:mm:ssZ”), when the resource was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// A string representing the date and time, in RFC 3339 format (“YYYY-MM-DDTHH:mm:ssZ”), when the resource was last updated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// An object containing the embedding results, or `null` otherwise.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::System.Collections.Generic.IList<global::G.EmbeddingData>? Data { get; set; }

        /// <summary>
        /// Metadata for the media input.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.EmbeddingTaskMediaMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingTaskResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the embedding task.
        /// </param>
        /// <param name="status">
        /// The current status of the task.<br/>
        /// **Values**:<br/>
        /// - `processing`: The platform is creating the embeddings<br/>
        /// - `ready`: Processing is complete. Embeddings are available in the `data` field<br/>
        /// - `failed`: The task failed. The `data` field is `null`
        /// </param>
        /// <param name="createdAt">
        /// A string representing the date and time, in RFC 3339 format (“YYYY-MM-DDTHH:mm:ssZ”), when the resource was created.
        /// </param>
        /// <param name="updatedAt">
        /// A string representing the date and time, in RFC 3339 format (“YYYY-MM-DDTHH:mm:ssZ”), when the resource was last updated.
        /// </param>
        /// <param name="data">
        /// An object containing the embedding results, or `null` otherwise.
        /// </param>
        /// <param name="metadata">
        /// Metadata for the media input.
        /// </param>
        public EmbeddingTaskResponse(
            string id,
            global::G.EmbeddingTaskResponseStatus status,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            global::System.Collections.Generic.IList<global::G.EmbeddingData>? data,
            global::G.EmbeddingTaskMediaMetadata? metadata)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Data = data;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingTaskResponse" /> class.
        /// </summary>
        public EmbeddingTaskResponse()
        {
        }
    }
}