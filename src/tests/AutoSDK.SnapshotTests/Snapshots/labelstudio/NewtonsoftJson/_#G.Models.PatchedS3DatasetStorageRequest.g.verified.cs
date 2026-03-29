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
        [global::Newtonsoft.Json.JsonProperty("aws_access_key_id")]
        public string? AwsAccessKeyId { get; set; }

        /// <summary>
        /// AWS_SECRET_ACCESS_KEY
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("aws_secret_access_key")]
        public string? AwsSecretAccessKey { get; set; }

        /// <summary>
        /// AWS_SESSION_TOKEN
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("aws_session_token")]
        public string? AwsSessionToken { get; set; }

        /// <summary>
        /// AWS SSE KMS Key ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("aws_sse_kms_key_id")]
        public string? AwsSseKmsKeyId { get; set; }

        /// <summary>
        /// S3 bucket name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bucket")]
        public string? Bucket { get; set; }

        /// <summary>
        /// A unique integer value identifying this dataset.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset")]
        public int? Dataset { get; set; }

        /// <summary>
        /// Cloud storage description
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Glob pattern for syncing from bucket
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("glob_pattern")]
        public string? GlobPattern { get; set; }

        /// <summary>
        /// Last sync finished time
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_sync")]
        public global::System.DateTime? LastSync { get; set; }

        /// <summary>
        /// Count of tasks synced last time
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_sync_count")]
        public int? LastSyncCount { get; set; }

        /// <summary>
        /// Last sync job ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_sync_job")]
        public string? LastSyncJob { get; set; }

        /// <summary>
        /// Meta and debug information about storage processes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("meta")]
        public object? Meta { get; set; }

        /// <summary>
        /// S3 bucket prefix
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prefix")]
        public string? Prefix { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("presign")]
        public bool? Presign { get; set; }

        /// <summary>
        /// Presigned URLs TTL (in minutes)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("presign_ttl")]
        public int? PresignTtl { get; set; }

        /// <summary>
        /// Perform recursive scan over the bucket content
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("recursive_scan")]
        public bool? RecursiveScan { get; set; }

        /// <summary>
        /// Cloud storage regex for filtering objects
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("regex_filter")]
        public string? RegexFilter { get; set; }

        /// <summary>
        /// AWS Region
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("region_name")]
        public string? RegionName { get; set; }

        /// <summary>
        /// S3 Endpoint
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("s3_endpoint")]
        public string? S3Endpoint { get; set; }

        /// <summary>
        /// * `initialized` - Initialized<br/>
        /// * `queued` - Queued<br/>
        /// * `in_progress` - In progress<br/>
        /// * `failed` - Failed<br/>
        /// * `completed` - Completed<br/>
        /// * `completed_with_errors` - Completed with errors
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.StatusC5aEnum? Status { get; set; }

        /// <summary>
        /// Flag if dataset has been previously synced or not
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("synced")]
        public bool? Synced { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("synchronizable")]
        public bool? Synchronizable { get; set; }

        /// <summary>
        /// Cloud storage title
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Traceback report for the last failed sync
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("traceback")]
        public string? Traceback { get; set; }

        /// <summary>
        /// Interpret objects as BLOBs and generate URLs
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("use_blob_urls")]
        public bool? UseBlobUrls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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