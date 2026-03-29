//HintName: G.Models.HnswConfigDiff.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HnswConfigDiff
    {
        /// <summary>
        /// Number of edges per node in the index graph. Larger the value - more accurate the search, more space required.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("m")]
        public int? M { get; set; }

        /// <summary>
        /// Number of neighbours to consider during the index building. Larger the value - more accurate the search, more time required to build the index.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ef_construct")]
        public int? EfConstruct { get; set; }

        /// <summary>
        /// Minimal size threshold (in KiloBytes) below which full-scan is preferred over HNSW search. This measures the total size of vectors being queried against. When the maximum estimated amount of points that a condition satisfies is smaller than `full_scan_threshold_kb`, the query planner will use full-scan search instead of HNSW index traversal for better performance. Note: 1Kb = 1 vector of size 256
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("full_scan_threshold")]
        public int? FullScanThreshold { get; set; }

        /// <summary>
        /// Number of parallel threads used for background index building. If 0 - automatically select from 8 to 16. Best to keep between 8 and 16 to prevent likelihood of building broken/inefficient HNSW graphs. On small CPUs, less threads are used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_indexing_threads")]
        public int? MaxIndexingThreads { get; set; }

        /// <summary>
        /// Store HNSW index on disk. If set to false, the index will be stored in RAM. Default: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on_disk")]
        public bool? OnDisk { get; set; }

        /// <summary>
        /// Custom M param for additional payload-aware HNSW links. If not set, default M will be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload_m")]
        public int? PayloadM { get; set; }

        /// <summary>
        /// Store copies of original and quantized vectors within the HNSW index file. Default: false. Enabling this option will trade the search speed for disk usage by reducing amount of random seeks during the search. Requires quantized vectors to be enabled. Multi-vectors are not supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inline_storage")]
        public bool? InlineStorage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HnswConfigDiff" /> class.
        /// </summary>
        /// <param name="m">
        /// Number of edges per node in the index graph. Larger the value - more accurate the search, more space required.
        /// </param>
        /// <param name="efConstruct">
        /// Number of neighbours to consider during the index building. Larger the value - more accurate the search, more time required to build the index.
        /// </param>
        /// <param name="fullScanThreshold">
        /// Minimal size threshold (in KiloBytes) below which full-scan is preferred over HNSW search. This measures the total size of vectors being queried against. When the maximum estimated amount of points that a condition satisfies is smaller than `full_scan_threshold_kb`, the query planner will use full-scan search instead of HNSW index traversal for better performance. Note: 1Kb = 1 vector of size 256
        /// </param>
        /// <param name="maxIndexingThreads">
        /// Number of parallel threads used for background index building. If 0 - automatically select from 8 to 16. Best to keep between 8 and 16 to prevent likelihood of building broken/inefficient HNSW graphs. On small CPUs, less threads are used.
        /// </param>
        /// <param name="onDisk">
        /// Store HNSW index on disk. If set to false, the index will be stored in RAM. Default: false
        /// </param>
        /// <param name="payloadM">
        /// Custom M param for additional payload-aware HNSW links. If not set, default M will be used.
        /// </param>
        /// <param name="inlineStorage">
        /// Store copies of original and quantized vectors within the HNSW index file. Default: false. Enabling this option will trade the search speed for disk usage by reducing amount of random seeks during the search. Requires quantized vectors to be enabled. Multi-vectors are not supported.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HnswConfigDiff(
            int? m,
            int? efConstruct,
            int? fullScanThreshold,
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
        /// Initializes a new instance of the <see cref="HnswConfigDiff" /> class.
        /// </summary>
        public HnswConfigDiff()
        {
        }
    }
}