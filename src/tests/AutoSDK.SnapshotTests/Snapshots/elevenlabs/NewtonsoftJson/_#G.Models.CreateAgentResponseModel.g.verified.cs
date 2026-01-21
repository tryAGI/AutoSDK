//HintName: G.Models.CreateAgentResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"agent_id":"J3Pbu5gP6NNKBscdCdwB"}
    /// </summary>
    public sealed partial class CreateAgentResponseModel
    {
        /// <summary>
        /// ID of the created agent
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentResponseModel" /> class.
        /// </summary>
        /// <param name="agentId">
        /// ID of the created agent
        /// </param>
        public CreateAgentResponseModel(
            string agentId)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentResponseModel" /> class.
        /// </summary>
        public CreateAgentResponseModel()
        {
        }
    }
}