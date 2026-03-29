//HintName: G.Models.UpdateHnswConfiguration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateHnswConfiguration
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("batch_size")]
        public int? BatchSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ef_search")]
        public int? EfSearch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_neighbors")]
        public int? MaxNeighbors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_threads")]
        public int? NumThreads { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resize_factor")]
        public double? ResizeFactor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sync_threshold")]
        public int? SyncThreshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateHnswConfiguration" /> class.
        /// </summary>
        /// <param name="batchSize"></param>
        /// <param name="efSearch"></param>
        /// <param name="maxNeighbors"></param>
        /// <param name="numThreads"></param>
        /// <param name="resizeFactor"></param>
        /// <param name="syncThreshold"></param>
        public UpdateHnswConfiguration(
            int? batchSize,
            int? efSearch,
            int? maxNeighbors,
            int? numThreads,
            double? resizeFactor,
            int? syncThreshold)
        {
            this.BatchSize = batchSize;
            this.EfSearch = efSearch;
            this.MaxNeighbors = maxNeighbors;
            this.NumThreads = numThreads;
            this.ResizeFactor = resizeFactor;
            this.SyncThreshold = syncThreshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateHnswConfiguration" /> class.
        /// </summary>
        public UpdateHnswConfiguration()
        {
        }
    }
}