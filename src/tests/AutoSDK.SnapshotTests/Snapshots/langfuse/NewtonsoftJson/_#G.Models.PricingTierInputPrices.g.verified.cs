//HintName: G.Models.PricingTierInputPrices.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Prices (USD) by usage type for this tier. At least one price must be defined.<br/>
    /// Common usage types: "input", "output", "total", "request", "image"<br/>
    /// Prices are in USD per unit (e.g., per token).<br/>
    /// Example: {"input": 0.000003, "output": 0.000015} represents $3 per million input tokens and $15 per million output tokens.
    /// </summary>
    public sealed partial class PricingTierInputPrices
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}