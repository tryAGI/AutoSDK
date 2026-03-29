//HintName: G.Models.GCSDatasetStorageRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GCSDatasetStorageRequest
    {
        /// <summary>
        /// GCS bucket name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucket")]
        public string? Bucket { get; set; }

        /// <summary>
        /// A unique integer value identifying this dataset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Dataset { get; set; }

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
        /// The content of GOOGLE_APPLICATION_CREDENTIALS json file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("google_application_credentials")]
        public string? GoogleApplicationCredentials { get; set; }

        /// <summary>
        /// Google project ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("google_project_id")]
        public string? GoogleProjectId { get; set; }

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
        /// GCS bucket prefix
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
        /// Initializes a new instance of the <see cref="GCSDatasetStorageRequest" /> class.
        /// </summary>
        /// <param name="dataset">
        /// A unique integer value identifying this dataset.
        /// </param>
        /// <param name="bucket">
        /// GCS bucket name
        /// </param>
        /// <param name="description">
        /// Cloud storage description
        /// </param>
        /// <param name="globPattern">
        /// Glob pattern for syncing from bucket
        /// </param>
        /// <param name="googleApplicationCredentials">
        /// The content of GOOGLE_APPLICATION_CREDENTIALS json file
        /// </param>
        /// <param name="googleProjectId">
        /// Google project ID
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
        /// GCS bucket prefix
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
        public GCSDatasetStorageRequest(
            int dataset,
            string? bucket,
            string? description,
            string? globPattern,
            string? googleApplicationCredentials,
            string? googleProjectId,
            global::System.DateTime? lastSync,
            int? lastSyncCount,
            string? lastSyncJob,
            object? meta,
            string? prefix,
            bool? presign,
            int? presignTtl,
            bool? recursiveScan,
            string? regexFilter,
            global::G.StatusC5aEnum? status,
            bool? synced,
            bool? synchronizable,
            string? title,
            string? traceback,
            bool? useBlobUrls)
        {
            this.Bucket = bucket;
            this.Dataset = dataset;
            this.Description = description;
            this.GlobPattern = globPattern;
            this.GoogleApplicationCredentials = googleApplicationCredentials;
            this.GoogleProjectId = googleProjectId;
            this.LastSync = lastSync;
            this.LastSyncCount = lastSyncCount;
            this.LastSyncJob = lastSyncJob;
            this.Meta = meta;
            this.Prefix = prefix;
            this.Presign = presign;
            this.PresignTtl = presignTtl;
            this.RecursiveScan = recursiveScan;
            this.RegexFilter = regexFilter;
            this.Status = status;
            this.Synced = synced;
            this.Synchronizable = synchronizable;
            this.Title = title;
            this.Traceback = traceback;
            this.UseBlobUrls = useBlobUrls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GCSDatasetStorageRequest" /> class.
        /// </summary>
        public GCSDatasetStorageRequest()
        {
        }
    }
}