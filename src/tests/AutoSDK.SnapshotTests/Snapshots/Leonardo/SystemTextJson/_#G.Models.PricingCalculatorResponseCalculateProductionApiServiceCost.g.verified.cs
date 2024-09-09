//HintName: G.Models.PricingCalculatorResponseCalculateProductionApiServiceCost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PricingCalculatorResponseCalculateProductionApiServiceCost
    {
        /// <summary>
        /// API service cost to generate the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        public int Cost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}