//HintName: G.Models.PricingBaseCost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Flat base cost in credits. Present for per-generation models (images). Duration-based models leave this unset.
    /// </summary>
    public sealed partial class PricingBaseCost
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}