//HintName: G.Models.Query.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Query, filter, full-text search and vector search documents.
    /// </summary>
    public sealed partial class Query
    {
        /// <summary>
        /// How to rank the documents in the namespace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rank_by")]
        public object? RankBy { get; set; }

        /// <summary>
        /// The number of results to return.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_k")]
        public int? TopK { get; set; }

        /// <summary>
        /// Exact filters for attributes to refine search results for. Think of it as a SQL WHERE clause.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public object? Filters { get; set; }

        /// <summary>
        /// Whether to include attributes in the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_attributes")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.IncludeAttributesJsonConverter))]
        public global::G.IncludeAttributes? IncludeAttributes { get; set; }

        /// <summary>
        /// List of attribute names to exclude from the response. All other attributes will be included in the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude_attributes")]
        public global::System.Collections.Generic.IList<string>? ExcludeAttributes { get; set; }

        /// <summary>
        /// Aggregations to compute over all documents in the namespace that match the filters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aggregate_by")]
        public object? AggregateBy { get; set; }

        /// <summary>
        /// Groups documents by the specified attributes (the "group key") before computing aggregates. Aggregates are computed separately for each group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_by")]
        public global::System.Collections.Generic.IList<string>? GroupBy { get; set; }

        /// <summary>
        /// A function used to calculate vector similarity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distance_metric")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DistanceMetricJsonConverter))]
        public global::G.DistanceMetric? DistanceMetric { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<int?, global::G.Limit2>))]
        public global::G.AnyOf<int?, global::G.Limit2>? Limit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Query" /> class.
        /// </summary>
        /// <param name="rankBy">
        /// How to rank the documents in the namespace.
        /// </param>
        /// <param name="topK">
        /// The number of results to return.
        /// </param>
        /// <param name="filters">
        /// Exact filters for attributes to refine search results for. Think of it as a SQL WHERE clause.
        /// </param>
        /// <param name="includeAttributes">
        /// Whether to include attributes in the response.
        /// </param>
        /// <param name="excludeAttributes">
        /// List of attribute names to exclude from the response. All other attributes will be included in the response.
        /// </param>
        /// <param name="aggregateBy">
        /// Aggregations to compute over all documents in the namespace that match the filters.
        /// </param>
        /// <param name="groupBy">
        /// Groups documents by the specified attributes (the "group key") before computing aggregates. Aggregates are computed separately for each group.
        /// </param>
        /// <param name="distanceMetric">
        /// A function used to calculate vector similarity.
        /// </param>
        /// <param name="limit"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Query(
            object? rankBy,
            int? topK,
            object? filters,
            global::G.IncludeAttributes? includeAttributes,
            global::System.Collections.Generic.IList<string>? excludeAttributes,
            object? aggregateBy,
            global::System.Collections.Generic.IList<string>? groupBy,
            global::G.DistanceMetric? distanceMetric,
            global::G.AnyOf<int?, global::G.Limit2>? limit)
        {
            this.RankBy = rankBy;
            this.TopK = topK;
            this.Filters = filters;
            this.IncludeAttributes = includeAttributes;
            this.ExcludeAttributes = excludeAttributes;
            this.AggregateBy = aggregateBy;
            this.GroupBy = groupBy;
            this.DistanceMetric = distanceMetric;
            this.Limit = limit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Query" /> class.
        /// </summary>
        public Query()
        {
        }
    }
}