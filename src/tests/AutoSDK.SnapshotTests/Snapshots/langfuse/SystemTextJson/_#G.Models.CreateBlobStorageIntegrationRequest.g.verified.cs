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
        /// Name of the storage bucket
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucketName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BucketName { get; set; }

        /// <summary>
        /// Custom endpoint URL (required for S3_COMPATIBLE type)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        public string? Endpoint { get; set; }

        /// <summary>
        /// Storage region
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Region { get; set; }

        /// <summary>
        /// Access key ID for authentication
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accessKeyId")]
        public string? AccessKeyId { get; set; }

        /// <summary>
        /// Secret access key for authentication (will be encrypted when stored)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secretAccessKey")]
        public string? SecretAccessKey { get; set; }

        /// <summary>
        /// Path prefix for exported files (must end with forward slash if provided)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix")]
        public string? Prefix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exportFrequency")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BlobStorageExportFrequencyJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.BlobStorageExportFrequency ExportFrequency { get; set; }

        /// <summary>
        /// Whether the integration is active
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Use path-style URLs for S3 requests
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
        /// Custom start date for exports (required when exportMode is FROM_CUSTOM_DATE)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exportStartDate")]
        public global::System.DateTime? ExportStartDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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