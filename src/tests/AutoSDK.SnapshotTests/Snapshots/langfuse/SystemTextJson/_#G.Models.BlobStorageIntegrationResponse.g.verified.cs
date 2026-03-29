//HintName: G.Models.BlobStorageIntegrationResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BlobStorageIntegrationResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BlobStorageIntegrationTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.BlobStorageIntegrationType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucketName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BucketName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        public string? Endpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Region { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accessKeyId")]
        public string? AccessKeyId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prefix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exportFrequency")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BlobStorageExportFrequencyJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.BlobStorageExportFrequency ExportFrequency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("forcePathStyle")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ForcePathStyle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BlobStorageIntegrationFileTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.BlobStorageIntegrationFileType FileType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exportMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BlobStorageExportModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.BlobStorageExportMode ExportMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exportStartDate")]
        public global::System.DateTime? ExportStartDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextSyncAt")]
        public global::System.DateTime? NextSyncAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastSyncAt")]
        public global::System.DateTime? LastSyncAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastError")]
        public string? LastError { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastErrorAt")]
        public global::System.DateTime? LastErrorAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BlobStorageIntegrationResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="projectId"></param>
        /// <param name="type"></param>
        /// <param name="bucketName"></param>
        /// <param name="region"></param>
        /// <param name="prefix"></param>
        /// <param name="exportFrequency"></param>
        /// <param name="enabled"></param>
        /// <param name="forcePathStyle"></param>
        /// <param name="fileType"></param>
        /// <param name="exportMode"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="endpoint"></param>
        /// <param name="accessKeyId"></param>
        /// <param name="exportStartDate"></param>
        /// <param name="nextSyncAt"></param>
        /// <param name="lastSyncAt"></param>
        /// <param name="lastError"></param>
        /// <param name="lastErrorAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BlobStorageIntegrationResponse(
            string id,
            string projectId,
            global::G.BlobStorageIntegrationType type,
            string bucketName,
            string region,
            string prefix,
            global::G.BlobStorageExportFrequency exportFrequency,
            bool enabled,
            bool forcePathStyle,
            global::G.BlobStorageIntegrationFileType fileType,
            global::G.BlobStorageExportMode exportMode,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? endpoint,
            string? accessKeyId,
            global::System.DateTime? exportStartDate,
            global::System.DateTime? nextSyncAt,
            global::System.DateTime? lastSyncAt,
            string? lastError,
            global::System.DateTime? lastErrorAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Type = type;
            this.BucketName = bucketName ?? throw new global::System.ArgumentNullException(nameof(bucketName));
            this.Endpoint = endpoint;
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
            this.AccessKeyId = accessKeyId;
            this.Prefix = prefix ?? throw new global::System.ArgumentNullException(nameof(prefix));
            this.ExportFrequency = exportFrequency;
            this.Enabled = enabled;
            this.ForcePathStyle = forcePathStyle;
            this.FileType = fileType;
            this.ExportMode = exportMode;
            this.ExportStartDate = exportStartDate;
            this.NextSyncAt = nextSyncAt;
            this.LastSyncAt = lastSyncAt;
            this.LastError = lastError;
            this.LastErrorAt = lastErrorAt;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BlobStorageIntegrationResponse" /> class.
        /// </summary>
        public BlobStorageIntegrationResponse()
        {
        }
    }
}