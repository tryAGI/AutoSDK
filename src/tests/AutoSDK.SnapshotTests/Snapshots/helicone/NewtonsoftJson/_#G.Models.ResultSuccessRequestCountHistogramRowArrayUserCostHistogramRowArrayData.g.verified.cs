//HintName: G.Models.ResultSuccessRequestCountHistogramRowArrayUserCostHistogramRowArrayData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResultSuccessRequestCountHistogramRowArrayUserCostHistogramRowArrayData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_cost", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.HistogramRow> UserCost { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_count", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.HistogramRow> RequestCount { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessRequestCountHistogramRowArrayUserCostHistogramRowArrayData" /> class.
        /// </summary>
        /// <param name="userCost"></param>
        /// <param name="requestCount"></param>
        public ResultSuccessRequestCountHistogramRowArrayUserCostHistogramRowArrayData(
            global::System.Collections.Generic.IList<global::G.HistogramRow> userCost,
            global::System.Collections.Generic.IList<global::G.HistogramRow> requestCount)
        {
            this.UserCost = userCost ?? throw new global::System.ArgumentNullException(nameof(userCost));
            this.RequestCount = requestCount ?? throw new global::System.ArgumentNullException(nameof(requestCount));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessRequestCountHistogramRowArrayUserCostHistogramRowArrayData" /> class.
        /// </summary>
        public ResultSuccessRequestCountHistogramRowArrayUserCostHistogramRowArrayData()
        {
        }
    }
}