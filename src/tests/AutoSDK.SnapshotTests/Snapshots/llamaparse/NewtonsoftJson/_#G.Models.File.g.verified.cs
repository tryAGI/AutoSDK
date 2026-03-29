//HintName: G.Models.File.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Schema for a file.
    /// </summary>
    public sealed partial class File
    {
        /// <summary>
        /// Unique identifier
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

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
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The ID of the file in the external system
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("external_file_id")]
        public string? ExternalFileId { get; set; }

        /// <summary>
        /// Size of the file in bytes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_size")]
        public long? FileSize { get; set; }

        /// <summary>
        /// File type (e.g. pdf, docx, etc.)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_type")]
        public string? FileType { get; set; }

        /// <summary>
        /// The ID of the project that the file belongs to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// The last modified time of the file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_modified_at")]
        public global::System.DateTime? LastModifiedAt { get; set; }

        /// <summary>
        /// Resource information for the file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resource_info")]
        public object? ResourceInfo { get; set; }

        /// <summary>
        /// Permission information for the file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permission_info")]
        public object? PermissionInfo { get; set; }

        /// <summary>
        /// The ID of the data source that the file belongs to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data_source_id")]
        public global::System.Guid? DataSourceId { get; set; }

        /// <summary>
        /// The expiration date for the file. Files past this date can be deleted.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// The intended purpose of the file (e.g., 'user_data', 'parse', 'extract', 'split', 'classify')
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("purpose")]
        public string? Purpose { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="File" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier
        /// </param>
        /// <param name="name"></param>
        /// <param name="projectId">
        /// The ID of the project that the file belongs to
        /// </param>
        /// <param name="createdAt">
        /// Creation datetime
        /// </param>
        /// <param name="updatedAt">
        /// Update datetime
        /// </param>
        /// <param name="externalFileId">
        /// The ID of the file in the external system
        /// </param>
        /// <param name="fileSize">
        /// Size of the file in bytes
        /// </param>
        /// <param name="fileType">
        /// File type (e.g. pdf, docx, etc.)
        /// </param>
        /// <param name="lastModifiedAt">
        /// The last modified time of the file
        /// </param>
        /// <param name="resourceInfo">
        /// Resource information for the file
        /// </param>
        /// <param name="permissionInfo">
        /// Permission information for the file
        /// </param>
        /// <param name="dataSourceId">
        /// The ID of the data source that the file belongs to
        /// </param>
        /// <param name="expiresAt">
        /// The expiration date for the file. Files past this date can be deleted.
        /// </param>
        /// <param name="purpose">
        /// The intended purpose of the file (e.g., 'user_data', 'parse', 'extract', 'split', 'classify')
        /// </param>
        public File(
            global::System.Guid id,
            string name,
            global::System.Guid projectId,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            string? externalFileId,
            long? fileSize,
            string? fileType,
            global::System.DateTime? lastModifiedAt,
            object? resourceInfo,
            object? permissionInfo,
            global::System.Guid? dataSourceId,
            global::System.DateTime? expiresAt,
            string? purpose)
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ExternalFileId = externalFileId;
            this.FileSize = fileSize;
            this.FileType = fileType;
            this.ProjectId = projectId;
            this.LastModifiedAt = lastModifiedAt;
            this.ResourceInfo = resourceInfo;
            this.PermissionInfo = permissionInfo;
            this.DataSourceId = dataSourceId;
            this.ExpiresAt = expiresAt;
            this.Purpose = purpose;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="File" /> class.
        /// </summary>
        public File()
        {
        }
    }
}