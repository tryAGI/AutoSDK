//HintName: G.Models.FileResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FileResponse
    {
        /// <summary>
        /// A unique identifier of the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The timestamp when the file was uploaded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The name of the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A list of Knowledge Graph IDs that the file is associated with.<br/>
        /// If you provided a `graphId` during upload, the file is associated with that Knowledge Graph. However, the `graph_ids` field in the upload response is an empty list. The association will be visible in the `graph_ids` list when you retrieve the file using the file retrieval endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("graph_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> GraphIds { get; set; }

        /// <summary>
        /// The processing status of the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// A unique identifier of the file.
        /// </param>
        /// <param name="createdAt">
        /// The timestamp when the file was uploaded.
        /// </param>
        /// <param name="name">
        /// The name of the file.
        /// </param>
        /// <param name="graphIds">
        /// A list of Knowledge Graph IDs that the file is associated with.<br/>
        /// If you provided a `graphId` during upload, the file is associated with that Knowledge Graph. However, the `graph_ids` field in the upload response is an empty list. The association will be visible in the `graph_ids` list when you retrieve the file using the file retrieval endpoint.
        /// </param>
        /// <param name="status">
        /// The processing status of the file.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileResponse(
            string id,
            global::System.DateTime createdAt,
            string name,
            global::System.Collections.Generic.IList<global::System.Guid> graphIds,
            string status)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.GraphIds = graphIds ?? throw new global::System.ArgumentNullException(nameof(graphIds));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileResponse" /> class.
        /// </summary>
        public FileResponse()
        {
        }
    }
}