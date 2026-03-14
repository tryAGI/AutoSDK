//HintName: G.Models.CreateAgentRequestToolConfigurations.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A map of tool configurations available to the agent. The key is the name of the tool configuration and the value is the AgentToolConfiguration.<br/>
    /// Example: {"customer_search":{"type":"corpora_search","argument_override":{"query":"customer support documentation"}}}
    /// </summary>
    public sealed partial class CreateAgentRequestToolConfigurations
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}