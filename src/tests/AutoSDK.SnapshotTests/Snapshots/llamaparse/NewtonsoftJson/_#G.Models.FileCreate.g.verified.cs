//HintName: G.Models.FileCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Schema for creating a file.
    /// </summary>
    public sealed partial class FileCreate
    {
        /// <summary>
        /// Name that will be used for created file. If possible, always include the file extension in the name.
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
        /// Storage type for the file. Valid values: 'Ephemeral', 'Permanent' (no expiration). If not specified, defaults to permanent storage.<br/>
        /// Default Value: permanent
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("storage_type")]
        public global::G.AnyOf<global::G.FileCreateStorageType?, string>? StorageType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileCreate" /> class.
        /// </summary>
        /// <param name="name">
        /// Name that will be used for created file. If possible, always include the file extension in the name.
        /// </param>
        /// <param name="externalFileId">
        /// The ID of the file in the external system
        /// </param>
        /// <param name="fileSize">
        /// Size of the file in bytes
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
        /// <param name="storageType">
        /// Storage type for the file. Valid values: 'Ephemeral', 'Permanent' (no expiration). If not specified, defaults to permanent storage.<br/>
        /// Default Value: permanent
        /// </param>
        public FileCreate(
            string name,
            string? externalFileId,
            long? fileSize,
            global::System.DateTime? lastModifiedAt,
            object? resourceInfo,
            object? permissionInfo,
            global::System.Guid? dataSourceId,
            global::G.AnyOf<global::G.FileCreateStorageType?, string>? storageType)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ExternalFileId = externalFileId;
            this.FileSize = fileSize;
            this.LastModifiedAt = lastModifiedAt;
            this.ResourceInfo = resourceInfo;
            this.PermissionInfo = permissionInfo;
            this.DataSourceId = dataSourceId;
            this.StorageType = storageType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileCreate" /> class.
        /// </summary>
        public FileCreate()
        {
        }
    }
}