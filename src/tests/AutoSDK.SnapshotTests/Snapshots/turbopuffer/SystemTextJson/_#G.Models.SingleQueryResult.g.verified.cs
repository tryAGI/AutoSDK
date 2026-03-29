//HintName: G.Models.SingleQueryResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SingleQueryResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aggregations")]
        public object? Aggregations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aggregation_groups")]
        public global::System.Collections.Generic.IList<global::G.AggregationGroup>? AggregationGroups { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rows")]
        public global::System.Collections.Generic.IList<global::G.Row>? Rows { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleQueryResult" /> class.
        /// </summary>
        /// <param name="aggregations"></param>
        /// <param name="aggregationGroups"></param>
        /// <param name="rows"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SingleQueryResult(
            object? aggregations,
            global::System.Collections.Generic.IList<global::G.AggregationGroup>? aggregationGroups,
            global::System.Collections.Generic.IList<global::G.Row>? rows)
        {
            this.Aggregations = aggregations;
            this.AggregationGroups = aggregationGroups;
            this.Rows = rows;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleQueryResult" /> class.
        /// </summary>
        public SingleQueryResult()
        {
        }
    }
}