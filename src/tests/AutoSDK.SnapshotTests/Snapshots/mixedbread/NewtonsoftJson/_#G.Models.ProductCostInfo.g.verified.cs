//HintName: G.Models.ProductCostInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Cost information for a product.
    /// </summary>
    public sealed partial class ProductCostInfo
    {
        /// <summary>
        /// The name of the product. Store, Parsing, Reranking, Embeddings
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("product_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProductName { get; set; } = default!;

        /// <summary>
        /// The gross usage cost of the product
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gross_usage_cost", Required = global::Newtonsoft.Json.Required.Always)]
        public string GrossUsageCost { get; set; } = default!;

        /// <summary>
        /// The net usage cost of the product
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("net_usage_cost", Required = global::Newtonsoft.Json.Required.Always)]
        public string NetUsageCost { get; set; } = default!;

        /// <summary>
        /// The balance applied to the product
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("balance_applied", Required = global::Newtonsoft.Json.Required.Always)]
        public string BalanceApplied { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductCostInfo" /> class.
        /// </summary>
        /// <param name="productName">
        /// The name of the product. Store, Parsing, Reranking, Embeddings
        /// </param>
        /// <param name="grossUsageCost">
        /// The gross usage cost of the product
        /// </param>
        /// <param name="netUsageCost">
        /// The net usage cost of the product
        /// </param>
        /// <param name="balanceApplied">
        /// The balance applied to the product
        /// </param>
        public ProductCostInfo(
            string productName,
            string grossUsageCost,
            string netUsageCost,
            string balanceApplied)
        {
            this.ProductName = productName ?? throw new global::System.ArgumentNullException(nameof(productName));
            this.GrossUsageCost = grossUsageCost ?? throw new global::System.ArgumentNullException(nameof(grossUsageCost));
            this.NetUsageCost = netUsageCost ?? throw new global::System.ArgumentNullException(nameof(netUsageCost));
            this.BalanceApplied = balanceApplied ?? throw new global::System.ArgumentNullException(nameof(balanceApplied));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductCostInfo" /> class.
        /// </summary>
        public ProductCostInfo()
        {
        }
    }
}