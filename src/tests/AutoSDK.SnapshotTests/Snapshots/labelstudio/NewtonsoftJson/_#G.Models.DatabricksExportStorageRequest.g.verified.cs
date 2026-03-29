//HintName: G.Models.DatabricksExportStorageRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Serializer for Databricks export storage with multi-auth support.
    /// </summary>
    public sealed partial class DatabricksExportStorageRequest
    {
        /// <summary>
        /// Authentication method: PAT, Databricks SP, or Azure AD SP<br/>
        /// * `pat` - Personal Access Token<br/>
        /// * `dbx_sp` - Databricks Service Principal<br/>
        /// * `azure_ad_sp` - Azure AD Service Principal<br/>
        /// Default Value: pat
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auth_type")]
        public global::G.AuthTypeEnum? AuthType { get; set; }

        /// <summary>
        /// Deletion from storage enabled
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("can_delete_objects")]
        public bool? CanDeleteObjects { get; set; }

        /// <summary>
        /// UC catalog name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("catalog", Required = global::Newtonsoft.Json.Required.Always)]
        public string Catalog { get; set; } = default!;

        /// <summary>
        /// Service principal client/application ID (required for SP modes)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("client_id")]
        public string? ClientId { get; set; }

        /// <summary>
        /// Service principal client secret (required for SP modes)<br/>
        /// Included only in requests
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("client_secret")]
        public string? ClientSecret { get; set; }

        /// <summary>
        /// Cloud storage description
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Databricks workspace base URL (https://...)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("host", Required = global::Newtonsoft.Json.Required.Always)]
        public string Host { get; set; } = default!;

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
        /// Export path prefix under the volume
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prefix")]
        public string? Prefix { get; set; }

        /// <summary>
        /// A unique integer value identifying this project.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project", Required = global::Newtonsoft.Json.Required.Always)]
        public int Project { get; set; } = default!;

        /// <summary>
        /// Regex for filtering objects
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("regex_filter")]
        public string? RegexFilter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_timeout_s")]
        public int? RequestTimeoutS { get; set; }

        /// <summary>
        /// UC schema name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("schema", Required = global::Newtonsoft.Json.Required.Always)]
        public string Schema { get; set; } = default!;

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
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stream_chunk_bytes")]
        public long? StreamChunkBytes { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("synchronizable")]
        public bool? Synchronizable { get; set; }

        /// <summary>
        /// Azure AD tenant ID (required for Azure AD SP mode)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tenant_id")]
        public string? TenantId { get; set; }

        /// <summary>
        /// Cloud storage title
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Databricks personal access token (required for PAT mode)<br/>
        /// Included only in requests
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token")]
        public string? Token { get; set; }

        /// <summary>
        /// Traceback report for the last failed sync
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("traceback")]
        public string? Traceback { get; set; }

        /// <summary>
        /// Generate blob URLs in tasks
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("use_blob_urls")]
        public bool? UseBlobUrls { get; set; }

        /// <summary>
        /// Verify TLS certificates
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("verify_tls")]
        public bool? VerifyTls { get; set; }

        /// <summary>
        /// UC volume name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("volume", Required = global::Newtonsoft.Json.Required.Always)]
        public string Volume { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatabricksExportStorageRequest" /> class.
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
        /// <param name="canDeleteObjects">
        /// Deletion from storage enabled
        /// </param>
        /// <param name="clientId">
        /// Service principal client/application ID (required for SP modes)
        /// </param>
        /// <param name="clientSecret">
        /// Service principal client secret (required for SP modes)<br/>
        /// Included only in requests
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
        /// Export path prefix under the volume
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
        /// <param name="token">
        /// Databricks personal access token (required for PAT mode)<br/>
        /// Included only in requests
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
        public DatabricksExportStorageRequest(
            string catalog,
            string host,
            int project,
            string schema,
            string volume,
            global::G.AuthTypeEnum? authType,
            bool? canDeleteObjects,
            string? clientId,
            string? clientSecret,
            string? description,
            global::System.DateTime? lastSync,
            int? lastSyncCount,
            string? lastSyncJob,
            object? meta,
            string? prefix,
            string? regexFilter,
            int? requestTimeoutS,
            global::G.StatusC5aEnum? status,
            long? streamChunkBytes,
            bool? synchronizable,
            string? tenantId,
            string? title,
            string? token,
            string? traceback,
            bool? useBlobUrls,
            bool? verifyTls)
        {
            this.AuthType = authType;
            this.CanDeleteObjects = canDeleteObjects;
            this.Catalog = catalog ?? throw new global::System.ArgumentNullException(nameof(catalog));
            this.ClientId = clientId;
            this.ClientSecret = clientSecret;
            this.Description = description;
            this.Host = host ?? throw new global::System.ArgumentNullException(nameof(host));
            this.LastSync = lastSync;
            this.LastSyncCount = lastSyncCount;
            this.LastSyncJob = lastSyncJob;
            this.Meta = meta;
            this.Prefix = prefix;
            this.Project = project;
            this.RegexFilter = regexFilter;
            this.RequestTimeoutS = requestTimeoutS;
            this.Schema = schema ?? throw new global::System.ArgumentNullException(nameof(schema));
            this.Status = status;
            this.StreamChunkBytes = streamChunkBytes;
            this.Synchronizable = synchronizable;
            this.TenantId = tenantId;
            this.Title = title;
            this.Token = token;
            this.Traceback = traceback;
            this.UseBlobUrls = useBlobUrls;
            this.VerifyTls = verifyTls;
            this.Volume = volume ?? throw new global::System.ArgumentNullException(nameof(volume));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatabricksExportStorageRequest" /> class.
        /// </summary>
        public DatabricksExportStorageRequest()
        {
        }
    }
}