//HintName: G.Models.FeedbackStatsResWindowStats.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Aggregations over the full query window, keyed by metric slug (e.g. 'output_score'). Each value maps agg name to result.
    /// </summary>
    public sealed partial class FeedbackStatsResWindowStats
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}