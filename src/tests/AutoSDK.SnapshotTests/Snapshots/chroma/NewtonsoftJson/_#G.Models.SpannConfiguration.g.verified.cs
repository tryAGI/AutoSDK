//HintName: G.Models.SpannConfiguration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpannConfiguration
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
        [global::Newtonsoft.Json.JsonProperty("merge_threshold")]
        public int? MergeThreshold { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reassign_neighbor_count")]
        public int? ReassignNeighborCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("search_nprobe")]
        public int? SearchNprobe { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("space")]
        public global::G.OneOf<object, global::G.Space2?>? Space { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("split_threshold")]
        public int? SplitThreshold { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("write_nprobe")]
        public int? WriteNprobe { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpannConfiguration" /> class.
        /// </summary>
        /// <param name="efConstruction"></param>
        /// <param name="efSearch"></param>
        /// <param name="maxNeighbors"></param>
        /// <param name="mergeThreshold"></param>
        /// <param name="reassignNeighborCount"></param>
        /// <param name="searchNprobe"></param>
        /// <param name="space"></param>
        /// <param name="splitThreshold"></param>
        /// <param name="writeNprobe"></param>
        public SpannConfiguration(
            int? efConstruction,
            int? efSearch,
            int? maxNeighbors,
            int? mergeThreshold,
            int? reassignNeighborCount,
            int? searchNprobe,
            global::G.OneOf<object, global::G.Space2?>? space,
            int? splitThreshold,
            int? writeNprobe)
        {
            this.EfConstruction = efConstruction;
            this.EfSearch = efSearch;
            this.MaxNeighbors = maxNeighbors;
            this.MergeThreshold = mergeThreshold;
            this.ReassignNeighborCount = reassignNeighborCount;
            this.SearchNprobe = searchNprobe;
            this.Space = space;
            this.SplitThreshold = splitThreshold;
            this.WriteNprobe = writeNprobe;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpannConfiguration" /> class.
        /// </summary>
        public SpannConfiguration()
        {
        }
    }
}