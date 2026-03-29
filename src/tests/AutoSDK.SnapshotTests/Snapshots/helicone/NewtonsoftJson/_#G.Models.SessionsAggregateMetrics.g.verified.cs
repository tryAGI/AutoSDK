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
        [global::Newtonsoft.Json.JsonProperty("count", Required = global::Newtonsoft.Json.Required.Always)]
        public double Count { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_cost", Required = global::Newtonsoft.Json.Required.Always)]
        public double TotalCost { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avg_cost", Required = global::Newtonsoft.Json.Required.Always)]
        public double AvgCost { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avg_latency", Required = global::Newtonsoft.Json.Required.Always)]
        public double AvgLatency { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avg_requests", Required = global::Newtonsoft.Json.Required.Always)]
        public double AvgRequests { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionsAggregateMetrics" /> class.
        /// </summary>
        /// <param name="count"></param>
        /// <param name="totalCost"></param>
        /// <param name="avgCost"></param>
        /// <param name="avgLatency"></param>
        /// <param name="avgRequests"></param>
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