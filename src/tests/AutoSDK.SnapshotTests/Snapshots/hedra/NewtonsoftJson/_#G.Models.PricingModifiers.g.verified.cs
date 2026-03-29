//HintName: G.Models.PricingModifiers.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Pricing modifiers by dimension. Each dimension (e.g. 'resolution', 'generate_audio') maps option values to their price multipliers. Only non-1.0 modifiers are included (1.0 is the implicit default). Example: {'resolution': {'540p': 0.5, '1080p': 3.0}}
    /// </summary>
    public sealed partial class PricingModifiers
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}