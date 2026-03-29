//HintName: G.Models.ModelPrices.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Deprecated. Use 'pricingTiers' instead for models with usage-based pricing variations.<br/>
    /// This field shows prices by usage type from the default pricing tier. Maintained for backward compatibility.<br/>
    /// If the model uses tiered pricing, this field will be populated from the default tier's prices.
    /// </summary>
    public sealed partial class ModelPrices
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}