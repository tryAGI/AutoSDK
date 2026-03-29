//HintName: G.Models.HnswIndexConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for HNSW vector index algorithm parameters
    /// </summary>
    public sealed partial class HnswIndexConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_size")]
        public int? BatchSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ef_construction")]
        public int? EfConstruction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ef_search")]
        public int? EfSearch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_neighbors")]
        public int? MaxNeighbors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_threads")]
        public int? NumThreads { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resize_factor")]
        public double? ResizeFactor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sync_threshold")]
        public int? SyncThreshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HnswIndexConfig" /> class.
        /// </summary>
        /// <param name="batchSize"></param>
        /// <param name="efConstruction"></param>
        /// <param name="efSearch"></param>
        /// <param name="maxNeighbors"></param>
        /// <param name="numThreads"></param>
        /// <param name="resizeFactor"></param>
        /// <param name="syncThreshold"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HnswIndexConfig(
            int? batchSize,
            int? efConstruction,
            int? efSearch,
            int? maxNeighbors,
            int? numThreads,
            double? resizeFactor,
            int? syncThreshold)
        {
            this.BatchSize = batchSize;
            this.EfConstruction = efConstruction;
            this.EfSearch = efSearch;
            this.MaxNeighbors = maxNeighbors;
            this.NumThreads = numThreads;
            this.ResizeFactor = resizeFactor;
            this.SyncThreshold = syncThreshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HnswIndexConfig" /> class.
        /// </summary>
        public HnswIndexConfig()
        {
        }
    }
}