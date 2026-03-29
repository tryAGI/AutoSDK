//HintName: G.Models.LlamaParseCostOptimizerParametersEnable.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enable cost-optimized parsing. Routes simpler pages to faster processing while complex pages use full AI analysis. May reduce speed on some documents. IMPORTANT: Only available with 'agentic' or 'agentic_plus' tiers
    /// </summary>
    public sealed partial class LlamaParseCostOptimizerParametersEnable
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}