//HintName: G.Models.PipelineFile.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A file associated with a pipeline.
    /// </summary>
    public sealed partial class PipelineFile
    {
        /// <summary>
        /// Unique identifier for the pipeline file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Name of the file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The ID of the file in the external system.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("external_file_id")]
        public string? ExternalFileId { get; set; }

        /// <summary>
        /// Size of the file in bytes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_size")]
        public long? FileSize { get; set; }

        /// <summary>
        /// File type (e.g. pdf, docx, etc.).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_type")]
        public string? FileType { get; set; }

        /// <summary>
        /// The ID of the project that the file belongs to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// The last modified time of the file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_modified_at")]
        public global::System.DateTime? LastModifiedAt { get; set; }

        /// <summary>
        /// The ID of the file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_id")]
        public global::System.Guid? FileId { get; set; }

        /// <summary>
        /// The ID of the pipeline that the file is associated with.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pipeline_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid PipelineId { get; set; } = default!;

        /// <summary>
        /// Resource information for the file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resource_info")]
        public object? ResourceInfo { get; set; }

        /// <summary>
        /// Permission information for the file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permission_info")]
        public object? PermissionInfo { get; set; }

        /// <summary>
        /// Custom metadata for the file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_metadata")]
        public object? CustomMetadata { get; set; }

        /// <summary>
        /// The ID of the data source that the file belongs to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data_source_id")]
        public global::System.Guid? DataSourceId { get; set; }

        /// <summary>
        /// Hashes for the configuration of the pipeline.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config_hash")]
        public object? ConfigHash { get; set; }

        /// <summary>
        /// The number of pages that have been indexed for this file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("indexed_page_count")]
        public int? IndexedPageCount { get; set; }

        /// <summary>
        /// Status of the pipeline file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.PipelineFileStatus2? Status { get; set; }

        /// <summary>
        /// The last time the status was updated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status_updated_at")]
        public global::System.DateTime? StatusUpdatedAt { get; set; }

        /// <summary>
        /// When the pipeline file was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// When the pipeline file was last updated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineFile" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the pipeline file.
        /// </param>
        /// <param name="pipelineId">
        /// The ID of the pipeline that the file is associated with.
        /// </param>
        /// <param name="name">
        /// Name of the file.
        /// </param>
        /// <param name="externalFileId">
        /// The ID of the file in the external system.
        /// </param>
        /// <param name="fileSize">
        /// Size of the file in bytes.
        /// </param>
        /// <param name="fileType">
        /// File type (e.g. pdf, docx, etc.).
        /// </param>
        /// <param name="projectId">
        /// The ID of the project that the file belongs to.
        /// </param>
        /// <param name="lastModifiedAt">
        /// The last modified time of the file.
        /// </param>
        /// <param name="fileId">
        /// The ID of the file.
        /// </param>
        /// <param name="resourceInfo">
        /// Resource information for the file.
        /// </param>
        /// <param name="permissionInfo">
        /// Permission information for the file.
        /// </param>
        /// <param name="customMetadata">
        /// Custom metadata for the file.
        /// </param>
        /// <param name="dataSourceId">
        /// The ID of the data source that the file belongs to.
        /// </param>
        /// <param name="configHash">
        /// Hashes for the configuration of the pipeline.
        /// </param>
        /// <param name="indexedPageCount">
        /// The number of pages that have been indexed for this file.
        /// </param>
        /// <param name="status">
        /// Status of the pipeline file.
        /// </param>
        /// <param name="statusUpdatedAt">
        /// The last time the status was updated.
        /// </param>
        /// <param name="createdAt">
        /// When the pipeline file was created.
        /// </param>
        /// <param name="updatedAt">
        /// When the pipeline file was last updated.
        /// </param>
        public PipelineFile(
            global::System.Guid id,
            global::System.Guid pipelineId,
            string? name,
            string? externalFileId,
            long? fileSize,
            string? fileType,
            global::System.Guid? projectId,
            global::System.DateTime? lastModifiedAt,
            global::System.Guid? fileId,
            object? resourceInfo,
            object? permissionInfo,
            object? customMetadata,
            global::System.Guid? dataSourceId,
            object? configHash,
            int? indexedPageCount,
            global::G.PipelineFileStatus2? status,
            global::System.DateTime? statusUpdatedAt,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Id = id;
            this.Name = name;
            this.ExternalFileId = externalFileId;
            this.FileSize = fileSize;
            this.FileType = fileType;
            this.ProjectId = projectId;
            this.LastModifiedAt = lastModifiedAt;
            this.FileId = fileId;
            this.PipelineId = pipelineId;
            this.ResourceInfo = resourceInfo;
            this.PermissionInfo = permissionInfo;
            this.CustomMetadata = customMetadata;
            this.DataSourceId = dataSourceId;
            this.ConfigHash = configHash;
            this.IndexedPageCount = indexedPageCount;
            this.Status = status;
            this.StatusUpdatedAt = statusUpdatedAt;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineFile" /> class.
        /// </summary>
        public PipelineFile()
        {
        }
    }
}