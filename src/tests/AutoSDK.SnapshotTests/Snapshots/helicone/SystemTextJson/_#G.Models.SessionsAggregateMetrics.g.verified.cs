//HintName: G.Models.SessionsAggregateMetrics.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SessionsAggregateMetrics
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AvgCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_latency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AvgLatency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AvgRequests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionsAggregateMetrics" /> class.
        /// </summary>
        /// <param name="count"></param>
        /// <param name="totalCost"></param>
        /// <param name="avgCost"></param>
        /// <param name="avgLatency"></param>
        /// <param name="avgRequests"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionsAggregateMetrics(
            double count,
            double totalCost,
            double avgCost,
            double avgLatency,
            double avgRequests)
        {
            this.Count = count;
            this.TotalCost = totalCost;
            this.AvgCost = avgCost;
            this.AvgLatency = avgLatency;
            this.AvgRequests = avgRequests;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionsAggregateMetrics" /> class.
        /// </summary>
        public SessionsAggregateMetrics()
        {
        }
    }
}