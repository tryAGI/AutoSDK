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
        [global::System.Text.Json.Serialization.JsonPropertyName("totalSpend")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalSpend { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessTotalSpendNumberData" /> class.
        /// </summary>
        /// <param name="totalSpend"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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