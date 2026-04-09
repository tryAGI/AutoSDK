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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.BlobStorageIntegrationTypeJsonConverter))]
        public global::G.BlobStorageIntegrationType Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bucketName", Required = global::Newtonsoft.Json.Required.Always)]
        public string BucketName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endpoint")]
        public string? Endpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("region", Required = global::Newtonsoft.Json.Required.Always)]
        public string Region { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accessKeyId")]
        public string? AccessKeyId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prefix", Required = global::Newtonsoft.Json.Required.Always)]
        public string Prefix { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exportFrequency", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.BlobStorageExportFrequencyJsonConverter))]
        public global::G.BlobStorageExportFrequency ExportFrequency { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Enabled { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("forcePathStyle", Required = global::Newtonsoft.Json.Required.Always)]
        public bool ForcePathStyle { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fileType", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.BlobStorageIntegrationFileTypeJsonConverter))]
        public global::G.BlobStorageIntegrationFileType FileType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exportMode", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.BlobStorageExportModeJsonConverter))]
        public global::G.BlobStorageExportMode ExportMode { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exportStartDate")]
        public global::System.DateTime? ExportStartDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("nextSyncAt")]
        public global::System.DateTime? NextSyncAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lastSyncAt")]
        public global::System.DateTime? LastSyncAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lastError")]
        public string? LastError { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lastErrorAt")]
        public global::System.DateTime? LastErrorAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updatedAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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