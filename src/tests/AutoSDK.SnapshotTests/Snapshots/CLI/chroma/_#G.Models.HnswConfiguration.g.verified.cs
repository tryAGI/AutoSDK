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
        [global::System.Text.Json.Serialization.JsonPropertyName("resize_factor")]
        public double? ResizeFactor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("space")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<object, global::G.Space2?>))]
        public global::G.OneOf<object, global::G.Space2?>? Space { get; set; }

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
        /// Initializes a new instance of the <see cref="HnswConfiguration" /> class.
        /// </summary>
        /// <param name="efConstruction"></param>
        /// <param name="efSearch"></param>
        /// <param name="maxNeighbors"></param>
        /// <param name="resizeFactor"></param>
        /// <param name="space"></param>
        /// <param name="syncThreshold"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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