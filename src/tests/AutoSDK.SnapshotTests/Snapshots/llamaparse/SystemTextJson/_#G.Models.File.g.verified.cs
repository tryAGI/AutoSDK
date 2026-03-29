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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Creation datetime
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Update datetime
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The ID of the file in the external system
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_file_id")]
        public string? ExternalFileId { get; set; }

        /// <summary>
        /// Size of the file in bytes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_size")]
        public long? FileSize { get; set; }

        /// <summary>
        /// File type (e.g. pdf, docx, etc.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_type")]
        public string? FileType { get; set; }

        /// <summary>
        /// The ID of the project that the file belongs to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// The last modified time of the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_modified_at")]
        public global::System.DateTime? LastModifiedAt { get; set; }

        /// <summary>
        /// Resource information for the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_info")]
        public object? ResourceInfo { get; set; }

        /// <summary>
        /// Permission information for the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permission_info")]
        public object? PermissionInfo { get; set; }

        /// <summary>
        /// The ID of the data source that the file belongs to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_source_id")]
        public global::System.Guid? DataSourceId { get; set; }

        /// <summary>
        /// The expiration date for the file. Files past this date can be deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// The intended purpose of the file (e.g., 'user_data', 'parse', 'extract', 'split', 'classify')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purpose")]
        public string? Purpose { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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