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
        [global::Newtonsoft.Json.JsonProperty("product_costs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ProductCost> ProductCosts { get; set; } = default!;

        /// <summary>
        /// Total duration of the call in seconds<br/>
        /// Example: 60
        /// </summary>
        /// <example>60</example>
        [global::Newtonsoft.Json.JsonProperty("total_duration_seconds", Required = global::Newtonsoft.Json.Required.Always)]
        public double TotalDurationSeconds { get; set; } = default!;

        /// <summary>
        /// Total unit duration price of all products in cents per second<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("total_duration_unit_price", Required = global::Newtonsoft.Json.Required.Always)]
        public double TotalDurationUnitPrice { get; set; } = default!;

        /// <summary>
        /// Combined cost of all individual costs in cents<br/>
        /// Example: 70
        /// </summary>
        /// <example>70</example>
        [global::Newtonsoft.Json.JsonProperty("combined_cost", Required = global::Newtonsoft.Json.Required.Always)]
        public double CombinedCost { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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