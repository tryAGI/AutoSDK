//HintName: G.Models.FeatureFlags.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeatureFlags
    {
        /// <summary>
        /// Magic feature flag that enables all features.<br/>
        /// Note that this will only be applied to all flags when passed into [`init_feature_flags`].<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("all")]
        public bool? All { get; set; }

        /// <summary>
        /// Skip usage of RocksDB in new immutable payload indices.<br/>
        /// First implemented in Qdrant 1.13.5. Enabled by default in Qdrant 1.14.1.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("payload_index_skip_rocksdb")]
        public bool? PayloadIndexSkipRocksdb { get; set; }

        /// <summary>
        /// Skip usage of RocksDB in new mutable payload indices.<br/>
        /// First implemented in Qdrant 1.15.0. Enabled by default in Qdrant 1.16.0.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("payload_index_skip_mutable_rocksdb")]
        public bool? PayloadIndexSkipMutableRocksdb { get; set; }

        /// <summary>
        /// Skip usage of RocksDB in new payload storages.<br/>
        /// On-disk payload storages never use Gridstore.<br/>
        /// First implemented in Qdrant 1.15.0. Enabled by default in Qdrant 1.16.0.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("payload_storage_skip_rocksdb")]
        public bool? PayloadStorageSkipRocksdb { get; set; }

        /// <summary>
        /// Use incremental HNSW building.<br/>
        /// Enabled by default in Qdrant 1.14.1.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("incremental_hnsw_building")]
        public bool? IncrementalHnswBuilding { get; set; }

        /// <summary>
        /// Migrate RocksDB based ID trackers into file based ID tracker on start.<br/>
        /// Enabled by default in Qdrant 1.15.0.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("migrate_rocksdb_id_tracker")]
        public bool? MigrateRocksdbIdTracker { get; set; }

        /// <summary>
        /// Migrate RocksDB based vector storages into new format on start.<br/>
        /// Enabled by default in Qdrant 1.16.1.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("migrate_rocksdb_vector_storage")]
        public bool? MigrateRocksdbVectorStorage { get; set; }

        /// <summary>
        /// Migrate RocksDB based payload storages into new format on start.<br/>
        /// Enabled by default in Qdrant 1.16.1.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("migrate_rocksdb_payload_storage")]
        public bool? MigrateRocksdbPayloadStorage { get; set; }

        /// <summary>
        /// Migrate RocksDB based payload indices into new format on start.<br/>
        /// Rebuilds a new payload index from scratch.<br/>
        /// Enabled by default in Qdrant 1.16.1.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("migrate_rocksdb_payload_indices")]
        public bool? MigrateRocksdbPayloadIndices { get; set; }

        /// <summary>
        /// Use appendable quantization in appendable plain segments.<br/>
        /// Enabled by default in Qdrant 1.16.0.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("appendable_quantization")]
        public bool? AppendableQuantization { get; set; }

        /// <summary>
        /// Use single-file mmap in-ram vector storage (InRamMmap)<br/>
        /// Enabled by default in Qdrant 1.17.1+<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("single_file_mmap_vector_storage")]
        public bool? SingleFileMmapVectorStorage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureFlags" /> class.
        /// </summary>
        /// <param name="all">
        /// Magic feature flag that enables all features.<br/>
        /// Note that this will only be applied to all flags when passed into [`init_feature_flags`].<br/>
        /// Default Value: false
        /// </param>
        /// <param name="payloadIndexSkipRocksdb">
        /// Skip usage of RocksDB in new immutable payload indices.<br/>
        /// First implemented in Qdrant 1.13.5. Enabled by default in Qdrant 1.14.1.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="payloadIndexSkipMutableRocksdb">
        /// Skip usage of RocksDB in new mutable payload indices.<br/>
        /// First implemented in Qdrant 1.15.0. Enabled by default in Qdrant 1.16.0.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="payloadStorageSkipRocksdb">
        /// Skip usage of RocksDB in new payload storages.<br/>
        /// On-disk payload storages never use Gridstore.<br/>
        /// First implemented in Qdrant 1.15.0. Enabled by default in Qdrant 1.16.0.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="incrementalHnswBuilding">
        /// Use incremental HNSW building.<br/>
        /// Enabled by default in Qdrant 1.14.1.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="migrateRocksdbIdTracker">
        /// Migrate RocksDB based ID trackers into file based ID tracker on start.<br/>
        /// Enabled by default in Qdrant 1.15.0.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="migrateRocksdbVectorStorage">
        /// Migrate RocksDB based vector storages into new format on start.<br/>
        /// Enabled by default in Qdrant 1.16.1.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="migrateRocksdbPayloadStorage">
        /// Migrate RocksDB based payload storages into new format on start.<br/>
        /// Enabled by default in Qdrant 1.16.1.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="migrateRocksdbPayloadIndices">
        /// Migrate RocksDB based payload indices into new format on start.<br/>
        /// Rebuilds a new payload index from scratch.<br/>
        /// Enabled by default in Qdrant 1.16.1.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="appendableQuantization">
        /// Use appendable quantization in appendable plain segments.<br/>
        /// Enabled by default in Qdrant 1.16.0.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="singleFileMmapVectorStorage">
        /// Use single-file mmap in-ram vector storage (InRamMmap)<br/>
        /// Enabled by default in Qdrant 1.17.1+<br/>
        /// Default Value: false
        /// </param>
        public FeatureFlags(
            bool? all,
            bool? payloadIndexSkipRocksdb,
            bool? payloadIndexSkipMutableRocksdb,
            bool? payloadStorageSkipRocksdb,
            bool? incrementalHnswBuilding,
            bool? migrateRocksdbIdTracker,
            bool? migrateRocksdbVectorStorage,
            bool? migrateRocksdbPayloadStorage,
            bool? migrateRocksdbPayloadIndices,
            bool? appendableQuantization,
            bool? singleFileMmapVectorStorage)
        {
            this.All = all;
            this.PayloadIndexSkipRocksdb = payloadIndexSkipRocksdb;
            this.PayloadIndexSkipMutableRocksdb = payloadIndexSkipMutableRocksdb;
            this.PayloadStorageSkipRocksdb = payloadStorageSkipRocksdb;
            this.IncrementalHnswBuilding = incrementalHnswBuilding;
            this.MigrateRocksdbIdTracker = migrateRocksdbIdTracker;
            this.MigrateRocksdbVectorStorage = migrateRocksdbVectorStorage;
            this.MigrateRocksdbPayloadStorage = migrateRocksdbPayloadStorage;
            this.MigrateRocksdbPayloadIndices = migrateRocksdbPayloadIndices;
            this.AppendableQuantization = appendableQuantization;
            this.SingleFileMmapVectorStorage = singleFileMmapVectorStorage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureFlags" /> class.
        /// </summary>
        public FeatureFlags()
        {
        }
    }
}