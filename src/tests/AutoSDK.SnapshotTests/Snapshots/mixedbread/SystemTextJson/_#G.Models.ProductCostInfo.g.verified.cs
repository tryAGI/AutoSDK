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
        [global::System.Text.Json.Serialization.JsonPropertyName("product_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProductName { get; set; }

        /// <summary>
        /// The gross usage cost of the product
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gross_usage_cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GrossUsageCost { get; set; }

        /// <summary>
        /// The net usage cost of the product
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("net_usage_cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NetUsageCost { get; set; }

        /// <summary>
        /// The balance applied to the product
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("balance_applied")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BalanceApplied { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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