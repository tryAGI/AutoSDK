//HintName: G.Models.HnswConfiguration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HnswConfiguration
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ef_construction")]
        public int? EfConstruction { get; set; }

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
        [global::Newtonsoft.Json.JsonProperty("resize_factor")]
        public double? ResizeFactor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("space")]
        public global::G.OneOf<object, global::G.Space2?>? Space { get; set; }

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
        /// Initializes a new instance of the <see cref="HnswConfiguration" /> class.
        /// </summary>
        /// <param name="efConstruction"></param>
        /// <param name="efSearch"></param>
        /// <param name="maxNeighbors"></param>
        /// <param name="resizeFactor"></param>
        /// <param name="space"></param>
        /// <param name="syncThreshold"></param>
        public HnswConfiguration(
            int? efConstruction,
            int? efSearch,
            int? maxNeighbors,
            double? resizeFactor,
            global::G.OneOf<object, global::G.Space2?>? space,
            int? syncThreshold)
        {
            this.EfConstruction = efConstruction;
            this.EfSearch = efSearch;
            this.MaxNeighbors = maxNeighbors;
            this.ResizeFactor = resizeFactor;
            this.Space = space;
            this.SyncThreshold = syncThreshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HnswConfiguration" /> class.
        /// </summary>
        public HnswConfiguration()
        {
        }
    }
}