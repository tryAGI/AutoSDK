//HintName: G.Models.HnswConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Config of HNSW index
    /// </summary>
    public sealed partial class HnswConfig
    {
        /// <summary>
        /// Number of edges per node in the index graph. Larger the value - more accurate the search, more space required.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("m", Required = global::Newtonsoft.Json.Required.Always)]
        public int M { get; set; } = default!;

        /// <summary>
        /// Number of neighbours to consider during the index building. Larger the value - more accurate the search, more time required to build index.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ef_construct", Required = global::Newtonsoft.Json.Required.Always)]
        public int EfConstruct { get; set; } = default!;

        /// <summary>
        /// Minimal size threshold (in KiloBytes) below which full-scan is preferred over HNSW search. This measures the total size of vectors being queried against. When the maximum estimated amount of points that a condition satisfies is smaller than `full_scan_threshold_kb`, the query planner will use full-scan search instead of HNSW index traversal for better performance. Note: 1Kb = 1 vector of size 256
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("full_scan_threshold", Required = global::Newtonsoft.Json.Required.Always)]
        public int FullScanThreshold { get; set; } = default!;

        /// <summary>
        /// Number of parallel threads used for background index building. If 0 - automatically select from 8 to 16. Best to keep between 8 and 16 to prevent likelihood of slow building or broken/inefficient HNSW graphs. On small CPUs, less threads are used.<br/>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_indexing_threads")]
        public int? MaxIndexingThreads { get; set; }

        /// <summary>
        /// Store HNSW index on disk. If set to false, index will be stored in RAM. Default: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("on_disk")]
        public bool? OnDisk { get; set; }

        /// <summary>
        /// Custom M param for hnsw graph built for payload index. If not set, default M will be used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("payload_m")]
        public int? PayloadM { get; set; }

        /// <summary>
        /// Store copies of original and quantized vectors within the HNSW index file. Default: false. Enabling this option will trade the search speed for disk usage by reducing amount of random seeks during the search. Requires quantized vectors to be enabled. Multi-vectors are not supported.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inline_storage")]
        public bool? InlineStorage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HnswConfig" /> class.
        /// </summary>
        /// <param name="m">
        /// Number of edges per node in the index graph. Larger the value - more accurate the search, more space required.
        /// </param>
        /// <param name="efConstruct">
        /// Number of neighbours to consider during the index building. Larger the value - more accurate the search, more time required to build index.
        /// </param>
        /// <param name="fullScanThreshold">
        /// Minimal size threshold (in KiloBytes) below which full-scan is preferred over HNSW search. This measures the total size of vectors being queried against. When the maximum estimated amount of points that a condition satisfies is smaller than `full_scan_threshold_kb`, the query planner will use full-scan search instead of HNSW index traversal for better performance. Note: 1Kb = 1 vector of size 256
        /// </param>
        /// <param name="maxIndexingThreads">
        /// Number of parallel threads used for background index building. If 0 - automatically select from 8 to 16. Best to keep between 8 and 16 to prevent likelihood of slow building or broken/inefficient HNSW graphs. On small CPUs, less threads are used.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="onDisk">
        /// Store HNSW index on disk. If set to false, index will be stored in RAM. Default: false
        /// </param>
        /// <param name="payloadM">
        /// Custom M param for hnsw graph built for payload index. If not set, default M will be used.
        /// </param>
        /// <param name="inlineStorage">
        /// Store copies of original and quantized vectors within the HNSW index file. Default: false. Enabling this option will trade the search speed for disk usage by reducing amount of random seeks during the search. Requires quantized vectors to be enabled. Multi-vectors are not supported.
        /// </param>
        public HnswConfig(
            int m,
            int efConstruct,
            int fullScanThreshold,
            int? maxIndexingThreads,
            bool? onDisk,
            int? payloadM,
            bool? inlineStorage)
        {
            this.M = m;
            this.EfConstruct = efConstruct;
            this.FullScanThreshold = fullScanThreshold;
            this.MaxIndexingThreads = maxIndexingThreads;
            this.OnDisk = onDisk;
            this.PayloadM = payloadM;
            this.InlineStorage = inlineStorage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HnswConfig" /> class.
        /// </summary>
        public HnswConfig()
        {
        }
    }
}