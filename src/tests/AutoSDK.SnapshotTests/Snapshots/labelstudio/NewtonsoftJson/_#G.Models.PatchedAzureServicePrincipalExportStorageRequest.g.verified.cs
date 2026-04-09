//HintName: G.Models.PatchedAzureServicePrincipalExportStorageRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchedAzureServicePrincipalExportStorageRequest
    {
        /// <summary>
        /// Azure Blob account name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("account_name")]
        public string? AccountName { get; set; }

        /// <summary>
        /// Deletion from storage enabled
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("can_delete_objects")]
        public bool? CanDeleteObjects { get; set; }

        /// <summary>
        /// Azure Blob Service Principal Client ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("client_id")]
        public string? ClientId { get; set; }

        /// <summary>
        /// Azure Blob Service Principal Client Secret
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("client_secret")]
        public string? ClientSecret { get; set; }

        /// <summary>
        /// Azure blob container
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("container")]
        public string? Container { get; set; }

        /// <summary>
        /// Cloud storage description
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

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
        /// Azure blob prefix name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prefix")]
        public string? Prefix { get; set; }

        /// <summary>
        /// A unique integer value identifying this project.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project")]
        public int? Project { get; set; }

        /// <summary>
        /// Cloud storage regex for filtering objects
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("regex_filter")]
        public string? RegexFilter { get; set; }

        /// <summary>
        /// * `initialized` - Initialized<br/>
        /// * `queued` - Queued<br/>
        /// * `in_progress` - In progress<br/>
        /// * `failed` - Failed<br/>
        /// * `completed` - Completed<br/>
        /// * `completed_with_errors` - Completed with errors
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.StatusC5aEnumJsonConverter))]
        public global::G.StatusC5aEnum? Status { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("synchronizable")]
        public bool? Synchronizable { get; set; }

        /// <summary>
        /// Azure Tenant ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tenant_id")]
        public string? TenantId { get; set; }

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
        /// User Delegation Key (Backend)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_delegation_key")]
        public string? UserDelegationKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedAzureServicePrincipalExportStorageRequest" /> class.
        /// </summary>
        /// <param name="accountName">
        /// Azure Blob account name
        /// </param>
        /// <param name="canDeleteObjects">
        /// Deletion from storage enabled
        /// </param>
        /// <param name="clientId">
        /// Azure Blob Service Principal Client ID
        /// </param>
        /// <param name="clientSecret">
        /// Azure Blob Service Principal Client Secret
        /// </param>
        /// <param name="container">
        /// Azure blob container
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
        /// Azure blob prefix name
        /// </param>
        /// <param name="project">
        /// A unique integer value identifying this project.
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
        /// <param name="synchronizable">
        /// Default Value: true
        /// </param>
        /// <param name="tenantId">
        /// Azure Tenant ID
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
        /// <param name="userDelegationKey">
        /// User Delegation Key (Backend)
        /// </param>
        public PatchedAzureServicePrincipalExportStorageRequest(
            string? accountName,
            bool? canDeleteObjects,
            string? clientId,
            string? clientSecret,
            string? container,
            string? description,
            global::System.DateTime? lastSync,
            int? lastSyncCount,
            string? lastSyncJob,
            object? meta,
            string? prefix,
            int? project,
            string? regexFilter,
            global::G.StatusC5aEnum? status,
            bool? synchronizable,
            string? tenantId,
            string? title,
            string? traceback,
            bool? useBlobUrls,
            string? userDelegationKey)
        {
            this.AccountName = accountName;
            this.CanDeleteObjects = canDeleteObjects;
            this.ClientId = clientId;
            this.ClientSecret = clientSecret;
            this.Container = container;
            this.Description = description;
            this.LastSync = lastSync;
            this.LastSyncCount = lastSyncCount;
            this.LastSyncJob = lastSyncJob;
            this.Meta = meta;
            this.Prefix = prefix;
            this.Project = project;
            this.RegexFilter = regexFilter;
            this.Status = status;
            this.Synchronizable = synchronizable;
            this.TenantId = tenantId;
            this.Title = title;
            this.Traceback = traceback;
            this.UseBlobUrls = useBlobUrls;
            this.UserDelegationKey = userDelegationKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedAzureServicePrincipalExportStorageRequest" /> class.
        /// </summary>
        public PatchedAzureServicePrincipalExportStorageRequest()
        {
        }
    }
}