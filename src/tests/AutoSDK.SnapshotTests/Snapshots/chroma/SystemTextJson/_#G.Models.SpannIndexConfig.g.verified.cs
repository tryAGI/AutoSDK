//HintName: G.Models.SpannIndexConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for SPANN vector index algorithm parameters
    /// </summary>
    public sealed partial class SpannIndexConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("center_drift_threshold")]
        public float? CenterDriftThreshold { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("initial_lambda")]
        public float? InitialLambda { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("nreplica_count")]
        public int? NreplicaCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_centers_to_merge_to")]
        public int? NumCentersToMergeTo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_samples_kmeans")]
        public int? NumSamplesKmeans { get; set; }

        /// <summary>
        /// Quantization implementation for vector search (cloud-only feature)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantize")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.QuantizationJsonConverter))]
        public global::G.Quantization? Quantize { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("search_rng_epsilon")]
        public float? SearchRngEpsilon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_rng_factor")]
        public float? SearchRngFactor { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("write_rng_epsilon")]
        public float? WriteRngEpsilon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("write_rng_factor")]
        public float? WriteRngFactor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpannIndexConfig" /> class.
        /// </summary>
        /// <param name="centerDriftThreshold"></param>
        /// <param name="efConstruction"></param>
        /// <param name="efSearch"></param>
        /// <param name="initialLambda"></param>
        /// <param name="maxNeighbors"></param>
        /// <param name="mergeThreshold"></param>
        /// <param name="nreplicaCount"></param>
        /// <param name="numCentersToMergeTo"></param>
        /// <param name="numSamplesKmeans"></param>
        /// <param name="quantize">
        /// Quantization implementation for vector search (cloud-only feature)
        /// </param>
        /// <param name="reassignNeighborCount"></param>
        /// <param name="searchNprobe"></param>
        /// <param name="searchRngEpsilon"></param>
        /// <param name="searchRngFactor"></param>
        /// <param name="splitThreshold"></param>
        /// <param name="writeNprobe"></param>
        /// <param name="writeRngEpsilon"></param>
        /// <param name="writeRngFactor"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpannIndexConfig(
            float? centerDriftThreshold,
            int? efConstruction,
            int? efSearch,
            float? initialLambda,
            int? maxNeighbors,
            int? mergeThreshold,
            int? nreplicaCount,
            int? numCentersToMergeTo,
            int? numSamplesKmeans,
            global::G.Quantization? quantize,
            int? reassignNeighborCount,
            int? searchNprobe,
            float? searchRngEpsilon,
            float? searchRngFactor,
            int? splitThreshold,
            int? writeNprobe,
            float? writeRngEpsilon,
            float? writeRngFactor)
        {
            this.CenterDriftThreshold = centerDriftThreshold;
            this.EfConstruction = efConstruction;
            this.EfSearch = efSearch;
            this.InitialLambda = initialLambda;
            this.MaxNeighbors = maxNeighbors;
            this.MergeThreshold = mergeThreshold;
            this.NreplicaCount = nreplicaCount;
            this.NumCentersToMergeTo = numCentersToMergeTo;
            this.NumSamplesKmeans = numSamplesKmeans;
            this.Quantize = quantize;
            this.ReassignNeighborCount = reassignNeighborCount;
            this.SearchNprobe = searchNprobe;
            this.SearchRngEpsilon = searchRngEpsilon;
            this.SearchRngFactor = searchRngFactor;
            this.SplitThreshold = splitThreshold;
            this.WriteNprobe = writeNprobe;
            this.WriteRngEpsilon = writeRngEpsilon;
            this.WriteRngFactor = writeRngFactor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpannIndexConfig" /> class.
        /// </summary>
        public SpannIndexConfig()
        {
        }
    }
}