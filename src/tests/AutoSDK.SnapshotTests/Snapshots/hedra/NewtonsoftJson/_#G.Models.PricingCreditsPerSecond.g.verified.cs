//HintName: G.Models.PricingCreditsPerSecond.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Credit cost per second. Only present for duration-based models. Image/per-generation models leave this unset.
    /// </summary>
    public sealed partial class PricingCreditsPerSecond
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}