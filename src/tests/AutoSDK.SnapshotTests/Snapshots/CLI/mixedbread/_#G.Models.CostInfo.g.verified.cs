//HintName: G.Models.CostInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Cost information for a billing period.<br/>
    /// - net_usage_cost: portion of usage that actually ends up on the invoice after credits,<br/>
    ///     computed as gross_usage_cost - balance_applied.<br/>
    /// - gross_usage_cost: metered usage value before balance applied.
    /// </summary>
    public sealed partial class CostInfo
    {
        /// <summary>
        /// The net usage cost<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("net_usage_cost")]
        public string? NetUsageCost { get; set; }

        /// <summary>
        /// The gross usage cost<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gross_usage_cost")]
        public string? GrossUsageCost { get; set; }

        /// <summary>
        /// The balance applied<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("balance_applied")]
        public string? BalanceApplied { get; set; }

        /// <summary>
        /// The cost for each phase in descending order of end date<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phases")]
        public global::System.Collections.Generic.IList<global::G.PhaseCostInfo>? Phases { get; set; }

        /// <summary>
        /// The cost for each product. Store, Parsing, Reranking, Embeddings<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("products")]
        public global::System.Collections.Generic.IList<global::G.ProductCostInfo>? Products { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CostInfo" /> class.
        /// </summary>
        /// <param name="netUsageCost">
        /// The net usage cost<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="grossUsageCost">
        /// The gross usage cost<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="balanceApplied">
        /// The balance applied<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="phases">
        /// The cost for each phase in descending order of end date<br/>
        /// Default Value: []
        /// </param>
        /// <param name="products">
        /// The cost for each product. Store, Parsing, Reranking, Embeddings<br/>
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CostInfo(
            string? netUsageCost,
            string? grossUsageCost,
            string? balanceApplied,
            global::System.Collections.Generic.IList<global::G.PhaseCostInfo>? phases,
            global::System.Collections.Generic.IList<global::G.ProductCostInfo>? products)
        {
            this.NetUsageCost = netUsageCost;
            this.GrossUsageCost = grossUsageCost;
            this.BalanceApplied = balanceApplied;
            this.Phases = phases;
            this.Products = products;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CostInfo" /> class.
        /// </summary>
        public CostInfo()
        {
        }
    }
}