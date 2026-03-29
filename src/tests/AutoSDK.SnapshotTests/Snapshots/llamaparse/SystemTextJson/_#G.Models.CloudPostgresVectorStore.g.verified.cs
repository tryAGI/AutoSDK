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
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_nested_metadata_filters")]
        public bool? SupportsNestedMetadataFilters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("database")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Database { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("host")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Host { get; set; }

        /// <summary>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("password")]
        public string? Password { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("port")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Port { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("table_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TableName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SchemaName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embed_dim")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EmbedDim { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hybrid_search")]
        public bool? HybridSearch { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("perform_setup")]
        public bool? PerformSetup { get; set; }

        /// <summary>
        /// HNSW settings for PGVector index. Set to null to disable HNSW indexing in favor of a brute force indexing/exact search strategy instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hnsw_settings")]
        public global::G.PGVectorHNSWSettings? HnswSettings { get; set; }

        /// <summary>
        /// Default Value: CloudPostgresVectorStore
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class_name")]
        public string? ClassName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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