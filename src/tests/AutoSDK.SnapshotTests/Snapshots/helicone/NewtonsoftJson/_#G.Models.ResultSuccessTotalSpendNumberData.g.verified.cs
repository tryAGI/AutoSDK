//HintName: G.Models.ResultSuccessTotalSpendNumberData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResultSuccessTotalSpendNumberData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalSpend", Required = global::Newtonsoft.Json.Required.Always)]
        public double TotalSpend { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessTotalSpendNumberData" /> class.
        /// </summary>
        /// <param name="totalSpend"></param>
        public ResultSuccessTotalSpendNumberData(
            double totalSpend)
        {
            this.TotalSpend = totalSpend;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessTotalSpendNumberData" /> class.
        /// </summary>
        public ResultSuccessTotalSpendNumberData()
        {
        }
    }
}