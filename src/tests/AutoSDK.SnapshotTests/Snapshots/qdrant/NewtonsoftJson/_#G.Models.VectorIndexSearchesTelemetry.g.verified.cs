//HintName: G.Models.VectorIndexSearchesTelemetry.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VectorIndexSearchesTelemetry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index_name")]
        public string? IndexName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("unfiltered_plain", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OperationDurationStatistics UnfilteredPlain { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("unfiltered_hnsw", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OperationDurationStatistics UnfilteredHnsw { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("unfiltered_sparse", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OperationDurationStatistics UnfilteredSparse { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filtered_plain", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OperationDurationStatistics FilteredPlain { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filtered_small_cardinality", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OperationDurationStatistics FilteredSmallCardinality { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filtered_large_cardinality", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OperationDurationStatistics FilteredLargeCardinality { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filtered_exact", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OperationDurationStatistics FilteredExact { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filtered_sparse", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OperationDurationStatistics FilteredSparse { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("unfiltered_exact", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OperationDurationStatistics UnfilteredExact { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorIndexSearchesTelemetry" /> class.
        /// </summary>
        /// <param name="unfilteredPlain"></param>
        /// <param name="unfilteredHnsw"></param>
        /// <param name="unfilteredSparse"></param>
        /// <param name="filteredPlain"></param>
        /// <param name="filteredSmallCardinality"></param>
        /// <param name="filteredLargeCardinality"></param>
        /// <param name="filteredExact"></param>
        /// <param name="filteredSparse"></param>
        /// <param name="unfilteredExact"></param>
        /// <param name="indexName"></param>
        public VectorIndexSearchesTelemetry(
            global::G.OperationDurationStatistics unfilteredPlain,
            global::G.OperationDurationStatistics unfilteredHnsw,
            global::G.OperationDurationStatistics unfilteredSparse,
            global::G.OperationDurationStatistics filteredPlain,
            global::G.OperationDurationStatistics filteredSmallCardinality,
            global::G.OperationDurationStatistics filteredLargeCardinality,
            global::G.OperationDurationStatistics filteredExact,
            global::G.OperationDurationStatistics filteredSparse,
            global::G.OperationDurationStatistics unfilteredExact,
            string? indexName)
        {
            this.IndexName = indexName;
            this.UnfilteredPlain = unfilteredPlain ?? throw new global::System.ArgumentNullException(nameof(unfilteredPlain));
            this.UnfilteredHnsw = unfilteredHnsw ?? throw new global::System.ArgumentNullException(nameof(unfilteredHnsw));
            this.UnfilteredSparse = unfilteredSparse ?? throw new global::System.ArgumentNullException(nameof(unfilteredSparse));
            this.FilteredPlain = filteredPlain ?? throw new global::System.ArgumentNullException(nameof(filteredPlain));
            this.FilteredSmallCardinality = filteredSmallCardinality ?? throw new global::System.ArgumentNullException(nameof(filteredSmallCardinality));
            this.FilteredLargeCardinality = filteredLargeCardinality ?? throw new global::System.ArgumentNullException(nameof(filteredLargeCardinality));
            this.FilteredExact = filteredExact ?? throw new global::System.ArgumentNullException(nameof(filteredExact));
            this.FilteredSparse = filteredSparse ?? throw new global::System.ArgumentNullException(nameof(filteredSparse));
            this.UnfilteredExact = unfilteredExact ?? throw new global::System.ArgumentNullException(nameof(unfilteredExact));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorIndexSearchesTelemetry" /> class.
        /// </summary>
        public VectorIndexSearchesTelemetry()
        {
        }
    }
}