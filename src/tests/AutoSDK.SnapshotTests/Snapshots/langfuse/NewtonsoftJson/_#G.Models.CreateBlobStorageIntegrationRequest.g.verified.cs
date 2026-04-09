//HintName: G.Models.CreateBlobStorageIntegrationRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateBlobStorageIntegrationRequest
    {
        /// <summary>
        /// ID of the project in which to configure the blob storage integration
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
        /// Name of the storage bucket
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bucketName", Required = global::Newtonsoft.Json.Required.Always)]
        public string BucketName { get; set; } = default!;

        /// <summary>
        /// Custom endpoint URL (required for S3_COMPATIBLE type)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endpoint")]
        public string? Endpoint { get; set; }

        /// <summary>
        /// Storage region
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("region", Required = global::Newtonsoft.Json.Required.Always)]
        public string Region { get; set; } = default!;

        /// <summary>
        /// Access key ID for authentication
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accessKeyId")]
        public string? AccessKeyId { get; set; }

        /// <summary>
        /// Secret access key for authentication (will be encrypted when stored)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secretAccessKey")]
        public string? SecretAccessKey { get; set; }

        /// <summary>
        /// Path prefix for exported files (must end with forward slash if provided)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prefix")]
        public string? Prefix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exportFrequency", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.BlobStorageExportFrequencyJsonConverter))]
        public global::G.BlobStorageExportFrequency ExportFrequency { get; set; } = default!;

        /// <summary>
        /// Whether the integration is active
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Enabled { get; set; } = default!;

        /// <summary>
        /// Use path-style URLs for S3 requests
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
        /// Custom start date for exports (required when exportMode is FROM_CUSTOM_DATE)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exportStartDate")]
        public global::System.DateTime? ExportStartDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBlobStorageIntegrationRequest" /> class.
        /// </summary>
        /// <param name="projectId">
        /// ID of the project in which to configure the blob storage integration
        /// </param>
        /// <param name="type"></param>
        /// <param name="bucketName">
        /// Name of the storage bucket
        /// </param>
        /// <param name="region">
        /// Storage region
        /// </param>
        /// <param name="exportFrequency"></param>
        /// <param name="enabled">
        /// Whether the integration is active
        /// </param>
        /// <param name="forcePathStyle">
        /// Use path-style URLs for S3 requests
        /// </param>
        /// <param name="fileType"></param>
        /// <param name="exportMode"></param>
        /// <param name="endpoint">
        /// Custom endpoint URL (required for S3_COMPATIBLE type)
        /// </param>
        /// <param name="accessKeyId">
        /// Access key ID for authentication
        /// </param>
        /// <param name="secretAccessKey">
        /// Secret access key for authentication (will be encrypted when stored)
        /// </param>
        /// <param name="prefix">
        /// Path prefix for exported files (must end with forward slash if provided)
        /// </param>
        /// <param name="exportStartDate">
        /// Custom start date for exports (required when exportMode is FROM_CUSTOM_DATE)
        /// </param>
        public CreateBlobStorageIntegrationRequest(
            string projectId,
            global::G.BlobStorageIntegrationType type,
            string bucketName,
            string region,
            global::G.BlobStorageExportFrequency exportFrequency,
            bool enabled,
            bool forcePathStyle,
            global::G.BlobStorageIntegrationFileType fileType,
            global::G.BlobStorageExportMode exportMode,
            string? endpoint,
            string? accessKeyId,
            string? secretAccessKey,
            string? prefix,
            global::System.DateTime? exportStartDate)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Type = type;
            this.BucketName = bucketName ?? throw new global::System.ArgumentNullException(nameof(bucketName));
            this.Endpoint = endpoint;
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
            this.AccessKeyId = accessKeyId;
            this.SecretAccessKey = secretAccessKey;
            this.Prefix = prefix;
            this.ExportFrequency = exportFrequency;
            this.Enabled = enabled;
            this.ForcePathStyle = forcePathStyle;
            this.FileType = fileType;
            this.ExportMode = exportMode;
            this.ExportStartDate = exportStartDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBlobStorageIntegrationRequest" /> class.
        /// </summary>
        public CreateBlobStorageIntegrationRequest()
        {
        }
    }
}