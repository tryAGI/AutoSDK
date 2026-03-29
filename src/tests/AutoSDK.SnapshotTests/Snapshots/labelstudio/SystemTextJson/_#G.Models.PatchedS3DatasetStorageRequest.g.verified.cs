//HintName: G.Models.PatchedS3DatasetStorageRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchedS3DatasetStorageRequest
    {
        /// <summary>
        /// AWS_ACCESS_KEY_ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_access_key_id")]
        public string? AwsAccessKeyId { get; set; }

        /// <summary>
        /// AWS_SECRET_ACCESS_KEY
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_secret_access_key")]
        public string? AwsSecretAccessKey { get; set; }

        /// <summary>
        /// AWS_SESSION_TOKEN
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_session_token")]
        public string? AwsSessionToken { get; set; }

        /// <summary>
        /// AWS SSE KMS Key ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_sse_kms_key_id")]
        public string? AwsSseKmsKeyId { get; set; }

        /// <summary>
        /// S3 bucket name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucket")]
        public string? Bucket { get; set; }

        /// <summary>
        /// A unique integer value identifying this dataset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset")]
        public int? Dataset { get; set; }

        /// <summary>
        /// Cloud storage description
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Glob pattern for syncing from bucket
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("glob_pattern")]
        public string? GlobPattern { get; set; }

        /// <summary>
        /// Last sync finished time
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_sync")]
        public global::System.DateTime? LastSync { get; set; }

        /// <summary>
        /// Count of tasks synced last time
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_sync_count")]
        public int? LastSyncCount { get; set; }

        /// <summary>
        /// Last sync job ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_sync_job")]
        public string? LastSyncJob { get; set; }

        /// <summary>
        /// Meta and debug information about storage processes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        public object? Meta { get; set; }

        /// <summary>
        /// S3 bucket prefix
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix")]
        public string? Prefix { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presign")]
        public bool? Presign { get; set; }

        /// <summary>
        /// Presigned URLs TTL (in minutes)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presign_ttl")]
        public int? PresignTtl { get; set; }

        /// <summary>
        /// Perform recursive scan over the bucket content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recursive_scan")]
        public bool? RecursiveScan { get; set; }

        /// <summary>
        /// Cloud storage regex for filtering objects
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("regex_filter")]
        public string? RegexFilter { get; set; }

        /// <summary>
        /// AWS Region
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region_name")]
        public string? RegionName { get; set; }

        /// <summary>
        /// S3 Endpoint
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("s3_endpoint")]
        public string? S3Endpoint { get; set; }

        /// <summary>
        /// * `initialized` - Initialized<br/>
        /// * `queued` - Queued<br/>
        /// * `in_progress` - In progress<br/>
        /// * `failed` - Failed<br/>
        /// * `completed` - Completed<br/>
        /// * `completed_with_errors` - Completed with errors
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.StatusC5aEnumJsonConverter))]
        public global::G.StatusC5aEnum? Status { get; set; }

        /// <summary>
        /// Flag if dataset has been previously synced or not
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("synced")]
        public bool? Synced { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("synchronizable")]
        public bool? Synchronizable { get; set; }

        /// <summary>
        /// Cloud storage title
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Traceback report for the last failed sync
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traceback")]
        public string? Traceback { get; set; }

        /// <summary>
        /// Interpret objects as BLOBs and generate URLs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_blob_urls")]
        public bool? UseBlobUrls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedS3DatasetStorageRequest" /> class.
        /// </summary>
        /// <param name="awsAccessKeyId">
        /// AWS_ACCESS_KEY_ID
        /// </param>
        /// <param name="awsSecretAccessKey">
        /// AWS_SECRET_ACCESS_KEY
        /// </param>
        /// <param name="awsSessionToken">
        /// AWS_SESSION_TOKEN
        /// </param>
        /// <param name="awsSseKmsKeyId">
        /// AWS SSE KMS Key ID
        /// </param>
        /// <param name="bucket">
        /// S3 bucket name
        /// </param>
        /// <param name="dataset">
        /// A unique integer value identifying this dataset.
        /// </param>
        /// <param name="description">
        /// Cloud storage description
        /// </param>
        /// <param name="globPattern">
        /// Glob pattern for syncing from bucket
        /// </param>
        /// <param name="lastSync">
        /// Last sync finished time
        /// </param>
        /// <param name="lastSyncCount">
        /// Count of tasks synced last time
        /// </param>
        /// <param name="lastSyncJob">
        /// Last sync job ID
        /// </param>
        /// <param name="meta">
        /// Meta and debug information about storage processes
        /// </param>
        /// <param name="prefix">
        /// S3 bucket prefix
        /// </param>
        /// <param name="presign">
        /// Default Value: true
        /// </param>
        /// <param name="presignTtl">
        /// Presigned URLs TTL (in minutes)
        /// </param>
        /// <param name="recursiveScan">
        /// Perform recursive scan over the bucket content
        /// </param>
        /// <param name="regexFilter">
        /// Cloud storage regex for filtering objects
        /// </param>
        /// <param name="regionName">
        /// AWS Region
        /// </param>
        /// <param name="s3Endpoint">
        /// S3 Endpoint
        /// </param>
        /// <param name="status">
        /// * `initialized` - Initialized<br/>
        /// * `queued` - Queued<br/>
        /// * `in_progress` - In progress<br/>
        /// * `failed` - Failed<br/>
        /// * `completed` - Completed<br/>
        /// * `completed_with_errors` - Completed with errors
        /// </param>
        /// <param name="synced">
        /// Flag if dataset has been previously synced or not
        /// </param>
        /// <param name="synchronizable">
        /// Default Value: true
        /// </param>
        /// <param name="title">
        /// Cloud storage title
        /// </param>
        /// <param name="traceback">
        /// Traceback report for the last failed sync
        /// </param>
        /// <param name="useBlobUrls">
        /// Interpret objects as BLOBs and generate URLs
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchedS3DatasetStorageRequest(
            string? awsAccessKeyId,
            string? awsSecretAccessKey,
            string? awsSessionToken,
            string? awsSseKmsKeyId,
            string? bucket,
            int? dataset,
            string? description,
            string? globPattern,
            global::System.DateTime? lastSync,
            int? lastSyncCount,
            string? lastSyncJob,
            object? meta,
            string? prefix,
            bool? presign,
            int? presignTtl,
            bool? recursiveScan,
            string? regexFilter,
            string? regionName,
            string? s3Endpoint,
            global::G.StatusC5aEnum? status,
            bool? synced,
            bool? synchronizable,
            string? title,
            string? traceback,
            bool? useBlobUrls)
        {
            this.AwsAccessKeyId = awsAccessKeyId;
            this.AwsSecretAccessKey = awsSecretAccessKey;
            this.AwsSessionToken = awsSessionToken;
            this.AwsSseKmsKeyId = awsSseKmsKeyId;
            this.Bucket = bucket;
            this.Dataset = dataset;
            this.Description = description;
            this.GlobPattern = globPattern;
            this.LastSync = lastSync;
            this.LastSyncCount = lastSyncCount;
            this.LastSyncJob = lastSyncJob;
            this.Meta = meta;
            this.Prefix = prefix;
            this.Presign = presign;
            this.PresignTtl = presignTtl;
            this.RecursiveScan = recursiveScan;
            this.RegexFilter = regexFilter;
            this.RegionName = regionName;
            this.S3Endpoint = s3Endpoint;
            this.Status = status;
            this.Synced = synced;
            this.Synchronizable = synchronizable;
            this.Title = title;
            this.Traceback = traceback;
            this.UseBlobUrls = useBlobUrls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedS3DatasetStorageRequest" /> class.
        /// </summary>
        public PatchedS3DatasetStorageRequest()
        {
        }
    }
}