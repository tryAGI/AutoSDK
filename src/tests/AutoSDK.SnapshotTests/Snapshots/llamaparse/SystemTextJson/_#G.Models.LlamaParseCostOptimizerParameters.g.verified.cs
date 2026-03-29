//HintName: G.Models.LlamaParseCostOptimizerParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Cost optimizer configuration for reducing parsing costs on simpler pages.<br/>
    /// When enabled, the parser analyzes each page and routes simpler pages to faster,<br/>
    /// cheaper processing while preserving quality for complex pages. Only works with<br/>
    /// 'agentic' or 'agentic_plus' tiers.
    /// </summary>
    public sealed partial class LlamaParseCostOptimizerParameters
    {
        /// <summary>
        /// Enable cost-optimized parsing. Routes simpler pages to faster processing while complex pages use full AI analysis. May reduce speed on some documents. IMPORTANT: Only available with 'agentic' or 'agentic_plus' tiers
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable")]
        public bool? Enable { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LlamaParseCostOptimizerParameters" /> class.
        /// </summary>
        /// <param name="enable">
        /// Enable cost-optimized parsing. Routes simpler pages to faster processing while complex pages use full AI analysis. May reduce speed on some documents. IMPORTANT: Only available with 'agentic' or 'agentic_plus' tiers
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LlamaParseCostOptimizerParameters(
            bool? enable)
        {
            this.Enable = enable;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LlamaParseCostOptimizerParameters" /> class.
        /// </summary>
        public LlamaParseCostOptimizerParameters()
        {
        }
    }
}