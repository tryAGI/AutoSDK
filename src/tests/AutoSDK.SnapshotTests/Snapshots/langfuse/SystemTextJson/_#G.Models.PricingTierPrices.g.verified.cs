//HintName: G.Models.PricingTierPrices.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Prices (USD) by usage type for this tier.<br/>
    /// Common usage types: "input", "output", "total", "request", "image"<br/>
    /// Prices are specified in USD per unit (e.g., per token, per request, per second).<br/>
    /// Example: {"input": 0.000003, "output": 0.000015} means $3 per million input tokens and $15 per million output tokens.
    /// </summary>
    public sealed partial class PricingTierPrices
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}