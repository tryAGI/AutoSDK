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
        [global::System.Text.Json.Serialization.JsonPropertyName("index_name")]
        public string? IndexName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unfiltered_plain")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OperationDurationStatistics UnfilteredPlain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unfiltered_hnsw")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OperationDurationStatistics UnfilteredHnsw { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unfiltered_sparse")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OperationDurationStatistics UnfilteredSparse { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filtered_plain")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OperationDurationStatistics FilteredPlain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filtered_small_cardinality")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OperationDurationStatistics FilteredSmallCardinality { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filtered_large_cardinality")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OperationDurationStatistics FilteredLargeCardinality { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filtered_exact")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OperationDurationStatistics FilteredExact { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filtered_sparse")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OperationDurationStatistics FilteredSparse { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unfiltered_exact")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OperationDurationStatistics UnfilteredExact { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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