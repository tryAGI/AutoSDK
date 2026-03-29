//HintName: G.Models.CloudPostgresVectorStore.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CloudPostgresVectorStore
    {
        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("supports_nested_metadata_filters")]
        public bool? SupportsNestedMetadataFilters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("database", Required = global::Newtonsoft.Json.Required.Always)]
        public string Database { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("host", Required = global::Newtonsoft.Json.Required.Always)]
        public string Host { get; set; } = default!;

        /// <summary>
        /// Included only in requests
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("password")]
        public string? Password { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("port", Required = global::Newtonsoft.Json.Required.Always)]
        public int Port { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user", Required = global::Newtonsoft.Json.Required.Always)]
        public string User { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("table_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string TableName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("schema_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string SchemaName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embed_dim", Required = global::Newtonsoft.Json.Required.Always)]
        public int EmbedDim { get; set; } = default!;

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hybrid_search")]
        public bool? HybridSearch { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("perform_setup")]
        public bool? PerformSetup { get; set; }

        /// <summary>
        /// HNSW settings for PGVector index. Set to null to disable HNSW indexing in favor of a brute force indexing/exact search strategy instead.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hnsw_settings")]
        public global::G.PGVectorHNSWSettings? HnswSettings { get; set; }

        /// <summary>
        /// Default Value: CloudPostgresVectorStore
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("class_name")]
        public string? ClassName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudPostgresVectorStore" /> class.
        /// </summary>
        /// <param name="database"></param>
        /// <param name="host"></param>
        /// <param name="port"></param>
        /// <param name="user"></param>
        /// <param name="tableName"></param>
        /// <param name="schemaName"></param>
        /// <param name="embedDim"></param>
        /// <param name="supportsNestedMetadataFilters">
        /// Default Value: true
        /// </param>
        /// <param name="password">
        /// Included only in requests
        /// </param>
        /// <param name="hybridSearch">
        /// Default Value: true
        /// </param>
        /// <param name="performSetup">
        /// Default Value: true
        /// </param>
        /// <param name="hnswSettings">
        /// HNSW settings for PGVector index. Set to null to disable HNSW indexing in favor of a brute force indexing/exact search strategy instead.
        /// </param>
        /// <param name="className">
        /// Default Value: CloudPostgresVectorStore
        /// </param>
        public CloudPostgresVectorStore(
            string database,
            string host,
            int port,
            string user,
            string tableName,
            string schemaName,
            int embedDim,
            bool? supportsNestedMetadataFilters,
            string? password,
            bool? hybridSearch,
            bool? performSetup,
            global::G.PGVectorHNSWSettings? hnswSettings,
            string? className)
        {
            this.SupportsNestedMetadataFilters = supportsNestedMetadataFilters;
            this.Database = database ?? throw new global::System.ArgumentNullException(nameof(database));
            this.Host = host ?? throw new global::System.ArgumentNullException(nameof(host));
            this.Password = password;
            this.Port = port;
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.TableName = tableName ?? throw new global::System.ArgumentNullException(nameof(tableName));
            this.SchemaName = schemaName ?? throw new global::System.ArgumentNullException(nameof(schemaName));
            this.EmbedDim = embedDim;
            this.HybridSearch = hybridSearch;
            this.PerformSetup = performSetup;
            this.HnswSettings = hnswSettings;
            this.ClassName = className;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudPostgresVectorStore" /> class.
        /// </summary>
        public CloudPostgresVectorStore()
        {
        }
    }
}