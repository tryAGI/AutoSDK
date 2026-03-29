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
        [global::System.Text.Json.Serialization.JsonPropertyName("user_cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.HistogramRow> UserCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.HistogramRow> RequestCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessRequestCountHistogramRowArrayUserCostHistogramRowArrayData" /> class.
        /// </summary>
        /// <param name="userCost"></param>
        /// <param name="requestCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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