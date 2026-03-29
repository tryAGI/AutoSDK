//HintName: G.Models.DirectoryFileResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// API response schema for a directory file.
    /// </summary>
    public sealed partial class DirectoryFileResponse
    {
        /// <summary>
        /// Unique identifier for the directory file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Creation datetime
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Update datetime
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Project the directory file belongs to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectId { get; set; } = default!;

        /// <summary>
        /// Directory the file belongs to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("directory_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string DirectoryId { get; set; } = default!;

        /// <summary>
        /// Unique identifier for the file in the directory
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("unique_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string UniqueId { get; set; } = default!;

        /// <summary>
        /// Display name for the file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("display_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string DisplayName { get; set; } = default!;

        /// <summary>
        /// Optional data source credential associated with the file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data_source_id")]
        public string? DataSourceId { get; set; }

        /// <summary>
        /// File ID for the storage location.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_id")]
        public string? FileId { get; set; }

        /// <summary>
        /// Soft delete marker when the file is removed upstream or by user action.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deleted_at")]
        public global::System.DateTime? DeletedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryFileResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the directory file.
        /// </param>
        /// <param name="projectId">
        /// Project the directory file belongs to.
        /// </param>
        /// <param name="directoryId">
        /// Directory the file belongs to.
        /// </param>
        /// <param name="uniqueId">
        /// Unique identifier for the file in the directory
        /// </param>
        /// <param name="displayName">
        /// Display name for the file.
        /// </param>
        /// <param name="createdAt">
        /// Creation datetime
        /// </param>
        /// <param name="updatedAt">
        /// Update datetime
        /// </param>
        /// <param name="dataSourceId">
        /// Optional data source credential associated with the file.
        /// </param>
        /// <param name="fileId">
        /// File ID for the storage location.
        /// </param>
        /// <param name="deletedAt">
        /// Soft delete marker when the file is removed upstream or by user action.
        /// </param>
        public DirectoryFileResponse(
            string id,
            string projectId,
            string directoryId,
            string uniqueId,
            string displayName,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            string? dataSourceId,
            string? fileId,
            global::System.DateTime? deletedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.DirectoryId = directoryId ?? throw new global::System.ArgumentNullException(nameof(directoryId));
            this.UniqueId = uniqueId ?? throw new global::System.ArgumentNullException(nameof(uniqueId));
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.DataSourceId = dataSourceId;
            this.FileId = fileId;
            this.DeletedAt = deletedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryFileResponse" /> class.
        /// </summary>
        public DirectoryFileResponse()
        {
        }
    }
}