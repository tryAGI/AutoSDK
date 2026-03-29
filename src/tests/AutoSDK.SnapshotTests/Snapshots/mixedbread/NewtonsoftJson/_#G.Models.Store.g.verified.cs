//HintName: G.Models.Store.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Model representing a store with its metadata and timestamps.
    /// </summary>
    public sealed partial class Store
    {
        /// <summary>
        /// Unique identifier for the store
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Name of the store
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Detailed description of the store's purpose and contents
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Whether the store can be accessed by anyone with valid login credentials<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_public")]
        public bool? IsPublic { get; set; }

        /// <summary>
        /// Additional metadata associated with the store
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Store-level configuration defaults
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config")]
        public global::G.StoreConfig2? Config { get; set; }

        /// <summary>
        /// Counts of files in different states
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_counts")]
        public global::G.FileCounts? FileCounts { get; set; }

        /// <summary>
        /// Optional expiration policy
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_after")]
        public global::G.ExpiresAfter? ExpiresAfter { get; set; }

        /// <summary>
        /// Processing status of the store<br/>
        /// Default Value: completed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.StoreStatus? Status { get; set; }

        /// <summary>
        /// Timestamp when the store was created
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Timestamp when the store was last updated
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Timestamp when the store was last used
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_active_at")]
        public global::System.DateTime? LastActiveAt { get; set; }

        /// <summary>
        /// Total storage usage in bytes<br/>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage_bytes")]
        public long? UsageBytes { get; set; }

        /// <summary>
        /// Total storage usage in tokens<br/>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage_tokens")]
        public int? UsageTokens { get; set; }

        /// <summary>
        /// Optional expiration timestamp for the store
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Type of the object<br/>
        /// Default Value: store
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Store" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the store
        /// </param>
        /// <param name="name">
        /// Name of the store
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the store was created
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp when the store was last updated
        /// </param>
        /// <param name="description">
        /// Detailed description of the store's purpose and contents
        /// </param>
        /// <param name="isPublic">
        /// Whether the store can be accessed by anyone with valid login credentials<br/>
        /// Default Value: false
        /// </param>
        /// <param name="metadata">
        /// Additional metadata associated with the store
        /// </param>
        /// <param name="config">
        /// Store-level configuration defaults
        /// </param>
        /// <param name="fileCounts">
        /// Counts of files in different states
        /// </param>
        /// <param name="expiresAfter">
        /// Optional expiration policy
        /// </param>
        /// <param name="status">
        /// Processing status of the store<br/>
        /// Default Value: completed
        /// </param>
        /// <param name="lastActiveAt">
        /// Timestamp when the store was last used
        /// </param>
        /// <param name="usageBytes">
        /// Total storage usage in bytes<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="usageTokens">
        /// Total storage usage in tokens<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="expiresAt">
        /// Optional expiration timestamp for the store
        /// </param>
        /// <param name="object">
        /// Type of the object<br/>
        /// Default Value: store
        /// </param>
        public Store(
            string id,
            string name,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? description,
            bool? isPublic,
            object? metadata,
            global::G.StoreConfig2? config,
            global::G.FileCounts? fileCounts,
            global::G.ExpiresAfter? expiresAfter,
            global::G.StoreStatus? status,
            global::System.DateTime? lastActiveAt,
            long? usageBytes,
            int? usageTokens,
            global::System.DateTime? expiresAt,
            string? @object)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.IsPublic = isPublic;
            this.Metadata = metadata;
            this.Config = config;
            this.FileCounts = fileCounts;
            this.ExpiresAfter = expiresAfter;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.LastActiveAt = lastActiveAt;
            this.UsageBytes = usageBytes;
            this.UsageTokens = usageTokens;
            this.ExpiresAt = expiresAt;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Store" /> class.
        /// </summary>
        public Store()
        {
        }
    }
}