//HintName: G.Models.ResultSuccessPropertyStringTotalCostNumberRequestCountNumberCreatedAtTruncStringArrayDataItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResultSuccessPropertyStringTotalCostNumberRequestCountNumberCreatedAtTruncStringArrayDataItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at_trunc", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAtTrunc { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_count", Required = global::Newtonsoft.Json.Required.Always)]
        public double RequestCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_cost", Required = global::Newtonsoft.Json.Required.Always)]
        public double TotalCost { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("property", Required = global::Newtonsoft.Json.Required.Always)]
        public string Property { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessPropertyStringTotalCostNumberRequestCountNumberCreatedAtTruncStringArrayDataItem" /> class.
        /// </summary>
        /// <param name="createdAtTrunc"></param>
        /// <param name="requestCount"></param>
        /// <param name="totalCost"></param>
        /// <param name="property"></param>
        public ResultSuccessPropertyStringTotalCostNumberRequestCountNumberCreatedAtTruncStringArrayDataItem(
            string createdAtTrunc,
            double requestCount,
            double totalCost,
            string property)
        {
            this.CreatedAtTrunc = createdAtTrunc ?? throw new global::System.ArgumentNullException(nameof(createdAtTrunc));
            this.RequestCount = requestCount;
            this.TotalCost = totalCost;
            this.Property = property ?? throw new global::System.ArgumentNullException(nameof(property));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessPropertyStringTotalCostNumberRequestCountNumberCreatedAtTruncStringArrayDataItem" /> class.
        /// </summary>
        public ResultSuccessPropertyStringTotalCostNumberRequestCountNumberCreatedAtTruncStringArrayDataItem()
        {
        }
    }
}