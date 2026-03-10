//HintName: G.Models.TurnConfigWorkflowOverrideSpeculativeTurn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// When enabled, starts generating LLM responses during silence before full turn confidence is reached, reducing perceived latency. May increase LLM costs.
    /// </summary>
    public sealed partial class TurnConfigWorkflowOverrideSpeculativeTurn
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}