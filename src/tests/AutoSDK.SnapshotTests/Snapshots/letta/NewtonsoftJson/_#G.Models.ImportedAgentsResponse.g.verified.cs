//HintName: G.Models.ImportedAgentsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response model for imported agents
    /// </summary>
    public sealed partial class ImportedAgentsResponse
    {
        /// <summary>
        /// List of IDs of the imported agents
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> AgentIds { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportedAgentsResponse" /> class.
        /// </summary>
        /// <param name="agentIds">
        /// List of IDs of the imported agents
        /// </param>
        public ImportedAgentsResponse(
            global::System.Collections.Generic.IList<string> agentIds)
        {
            this.AgentIds = agentIds ?? throw new global::System.ArgumentNullException(nameof(agentIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportedAgentsResponse" /> class.
        /// </summary>
        public ImportedAgentsResponse()
        {
        }
    }
}