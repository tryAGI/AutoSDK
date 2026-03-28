//HintName: G.Models.ToolUsageStatsResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolUsageStatsResponseModel
    {
        /// <summary>
        /// The total number of calls to the tool<br/>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_calls")]
        public int? TotalCalls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avg_latency_secs", Required = global::Newtonsoft.Json.Required.Always)]
        public double AvgLatencySecs { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolUsageStatsResponseModel" /> class.
        /// </summary>
        /// <param name="avgLatencySecs"></param>
        /// <param name="totalCalls">
        /// The total number of calls to the tool<br/>
        /// Default Value: 0
        /// </param>
        public ToolUsageStatsResponseModel(
            double avgLatencySecs,
            int? totalCalls)
        {
            this.TotalCalls = totalCalls;
            this.AvgLatencySecs = avgLatencySecs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolUsageStatsResponseModel" /> class.
        /// </summary>
        public ToolUsageStatsResponseModel()
        {
        }
    }
}