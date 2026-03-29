//HintName: G.Models.V2CallBaseCallCost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Cost of the call, including all the products and their costs and discount.
    /// </summary>
    public sealed partial class V2CallBaseCallCost
    {
        /// <summary>
        /// List of products with their unit prices and costs in cents
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("product_costs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ProductCost> ProductCosts { get; set; }

        /// <summary>
        /// Total duration of the call in seconds<br/>
        /// Example: 60
        /// </summary>
        /// <example>60</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_duration_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalDurationSeconds { get; set; }

        /// <summary>
        /// Total unit duration price of all products in cents per second<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_duration_unit_price")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalDurationUnitPrice { get; set; }

        /// <summary>
        /// Combined cost of all individual costs in cents<br/>
        /// Example: 70
        /// </summary>
        /// <example>70</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("combined_cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CombinedCost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V2CallBaseCallCost" /> class.
        /// </summary>
        /// <param name="productCosts">
        /// List of products with their unit prices and costs in cents
        /// </param>
        /// <param name="totalDurationSeconds">
        /// Total duration of the call in seconds<br/>
        /// Example: 60
        /// </param>
        /// <param name="totalDurationUnitPrice">
        /// Total unit duration price of all products in cents per second<br/>
        /// Example: 1
        /// </param>
        /// <param name="combinedCost">
        /// Combined cost of all individual costs in cents<br/>
        /// Example: 70
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V2CallBaseCallCost(
            global::System.Collections.Generic.IList<global::G.ProductCost> productCosts,
            double totalDurationSeconds,
            double totalDurationUnitPrice,
            double combinedCost)
        {
            this.ProductCosts = productCosts ?? throw new global::System.ArgumentNullException(nameof(productCosts));
            this.TotalDurationSeconds = totalDurationSeconds;
            this.TotalDurationUnitPrice = totalDurationUnitPrice;
            this.CombinedCost = combinedCost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V2CallBaseCallCost" /> class.
        /// </summary>
        public V2CallBaseCallCost()
        {
        }
    }
}