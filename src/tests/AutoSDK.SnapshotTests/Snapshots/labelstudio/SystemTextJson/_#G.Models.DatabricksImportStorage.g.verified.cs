//HintName: G.Models.DatabricksImportStorage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Serializer for Databricks import storage with multi-auth support.
    /// </summary>
    public sealed partial class DatabricksImportStorage
    {
        /// <summary>
        /// Authentication method: PAT, Databricks SP, or Azure AD SP<br/>
        /// * `pat` - Personal Access Token<br/>
        /// * `dbx_sp` - Databricks Service Principal<br/>
        /// * `azure_ad_sp` - Azure AD Service Principal<br/>
        /// Default Value: pat
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AuthTypeEnumJsonConverter))]
        public global::G.AuthTypeEnum? AuthType { get; set; }

        /// <summary>
        /// UC catalog name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("catalog")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Catalog { get; set; }

        /// <summary>
        /// Service principal client/application ID (required for SP modes)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        public string? ClientId { get; set; }

        /// <summary>
        /// Creation time<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Cloud storage description
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Databricks workspace base URL (https://...)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("host")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Host { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int Id { get; set; } = default!;

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
        /// Path under the volume
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix")]
        public string? Prefix { get; set; }

        /// <summary>
        /// Presign not supported; always proxied
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presign")]
        public bool? Presign { get; set; }

        /// <summary>
        /// Unused for Databricks; kept for compatibility
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presign_ttl")]
        public int? PresignTtl { get; set; }

        /// <summary>
        /// A unique integer value identifying this project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Project { get; set; }

        /// <summary>
        /// Perform recursive scan
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recursive_scan")]
        public bool? RecursiveScan { get; set; }

        /// <summary>
        /// Regex for filtering objects
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("regex_filter")]
        public string? RegexFilter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_timeout_s")]
        public int? RequestTimeoutS { get; set; }

        /// <summary>
        /// UC schema name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Schema { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_chunk_bytes")]
        public long? StreamChunkBytes { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("synchronizable")]
        public bool? Synchronizable { get; set; }

        /// <summary>
        /// Azure AD tenant ID (required for Azure AD SP mode)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_id")]
        public string? TenantId { get; set; }

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
        /// Default Value: databricks<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Generate blob URLs in tasks
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_blob_urls")]
        public bool? UseBlobUrls { get; set; }

        /// <summary>
        /// Verify TLS certificates
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verify_tls")]
        public bool? VerifyTls { get; set; }

        /// <summary>
        /// UC volume name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Volume { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatabricksImportStorage" /> class.
        /// </summary>
        /// <param name="catalog">
        /// UC catalog name
        /// </param>
        /// <param name="host">
        /// Databricks workspace base URL (https://...)
        /// </param>
        /// <param name="project">
        /// A unique integer value identifying this project.
        /// </param>
        /// <param name="schema">
        /// UC schema name
        /// </param>
        /// <param name="volume">
        /// UC volume name
        /// </param>
        /// <param name="authType">
        /// Authentication method: PAT, Databricks SP, or Azure AD SP<br/>
        /// * `pat` - Personal Access Token<br/>
        /// * `dbx_sp` - Databricks Service Principal<br/>
        /// * `azure_ad_sp` - Azure AD Service Principal<br/>
        /// Default Value: pat
        /// </param>
        /// <param name="clientId">
        /// Service principal client/application ID (required for SP modes)
        /// </param>
        /// <param name="description">
        /// Cloud storage description
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
        /// Path under the volume
        /// </param>
        /// <param name="presign">
        /// Presign not supported; always proxied
        /// </param>
        /// <param name="presignTtl">
        /// Unused for Databricks; kept for compatibility
        /// </param>
        /// <param name="recursiveScan">
        /// Perform recursive scan
        /// </param>
        /// <param name="regexFilter">
        /// Regex for filtering objects
        /// </param>
        /// <param name="requestTimeoutS"></param>
        /// <param name="status">
        /// * `initialized` - Initialized<br/>
        /// * `queued` - Queued<br/>
        /// * `in_progress` - In progress<br/>
        /// * `failed` - Failed<br/>
        /// * `completed` - Completed<br/>
        /// * `completed_with_errors` - Completed with errors
        /// </param>
        /// <param name="streamChunkBytes"></param>
        /// <param name="synchronizable">
        /// Default Value: true
        /// </param>
        /// <param name="tenantId">
        /// Azure AD tenant ID (required for Azure AD SP mode)
        /// </param>
        /// <param name="title">
        /// Cloud storage title
        /// </param>
        /// <param name="traceback">
        /// Traceback report for the last failed sync
        /// </param>
        /// <param name="useBlobUrls">
        /// Generate blob URLs in tasks
        /// </param>
        /// <param name="verifyTls">
        /// Verify TLS certificates
        /// </param>
        /// <param name="createdAt">
        /// Creation time<br/>
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="type">
        /// Default Value: databricks<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatabricksImportStorage(
            string catalog,
            string host,
            int project,
            string schema,
            string volume,
            global::G.AuthTypeEnum? authType,
            string? clientId,
            string? description,
            global::System.DateTime? lastSync,
            int? lastSyncCount,
            string? lastSyncJob,
            object? meta,
            string? prefix,
            bool? presign,
            int? presignTtl,
            bool? recursiveScan,
            string? regexFilter,
            int? requestTimeoutS,
            global::G.StatusC5aEnum? status,
            long? streamChunkBytes,
            bool? synchronizable,
            string? tenantId,
            string? title,
            string? traceback,
            bool? useBlobUrls,
            bool? verifyTls,
            global::System.DateTime createdAt = default!,
            int id = default!,
            string type = default!)
        {
            this.AuthType = authType;
            this.Catalog = catalog ?? throw new global::System.ArgumentNullException(nameof(catalog));
            this.ClientId = clientId;
            this.CreatedAt = createdAt;
            this.Description = description;
            this.Host = host ?? throw new global::System.ArgumentNullException(nameof(host));
            this.Id = id;
            this.LastSync = lastSync;
            this.LastSyncCount = lastSyncCount;
            this.LastSyncJob = lastSyncJob;
            this.Meta = meta;
            this.Prefix = prefix;
            this.Presign = presign;
            this.PresignTtl = presignTtl;
            this.Project = project;
            this.RecursiveScan = recursiveScan;
            this.RegexFilter = regexFilter;
            this.RequestTimeoutS = requestTimeoutS;
            this.Schema = schema ?? throw new global::System.ArgumentNullException(nameof(schema));
            this.Status = status;
            this.StreamChunkBytes = streamChunkBytes;
            this.Synchronizable = synchronizable;
            this.TenantId = tenantId;
            this.Title = title;
            this.Traceback = traceback;
            this.Type = type;
            this.UseBlobUrls = useBlobUrls;
            this.VerifyTls = verifyTls;
            this.Volume = volume ?? throw new global::System.ArgumentNullException(nameof(volume));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatabricksImportStorage" /> class.
        /// </summary>
        public DatabricksImportStorage()
        {
        }
    }
}