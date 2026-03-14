//HintName: G.Models.UpdateAgentRequestToolConfigurations.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A map of tool configurations available to the agent. Set to null to clear all tools.<br/>
    /// Individual map values set to null will delete that tool configuration.<br/>
    /// Example: {"customer_search":{"type":"corpora_search","argument_override":{"query":"customer support documentation"}}}
    /// </summary>
    public sealed partial class UpdateAgentRequestToolConfigurations
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}