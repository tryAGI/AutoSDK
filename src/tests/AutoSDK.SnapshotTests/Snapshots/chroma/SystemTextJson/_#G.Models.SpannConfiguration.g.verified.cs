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
        [global::System.Text.Json.Serialization.JsonPropertyName("merge_threshold")]
        public int? MergeThreshold { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reassign_neighbor_count")]
        public int? ReassignNeighborCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_nprobe")]
        public int? SearchNprobe { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("space")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<object, global::G.Space2?>))]
        public global::G.OneOf<object, global::G.Space2?>? Space { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("split_threshold")]
        public int? SplitThreshold { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("write_nprobe")]
        public int? WriteNprobe { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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