//HintName: G.Models.GroupContentWithAggregations.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GroupContentWithAggregations
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aggregations")]
        public global::G.AggregationData? Aggregations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupContentWithAggregations" /> class.
        /// </summary>
        /// <param name="label"></param>
        /// <param name="aggregations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GroupContentWithAggregations(
            string? label,
            global::G.AggregationData? aggregations)
        {
            this.Label = label;
            this.Aggregations = aggregations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupContentWithAggregations" /> class.
        /// </summary>
        public GroupContentWithAggregations()
        {
        }
    }
}