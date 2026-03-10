//HintName: G.Models.WorkflowStandaloneAgentNodeModelOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowStandaloneAgentNodeModelOutput
    {
        /// <summary>
        /// Default Value: standalone_agent
        /// </summary>
        /// <default>"standalone_agent"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "standalone_agent";

        /// <summary>
        /// Position of the node in the workflow.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("position", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PositionOutput Position { get; set; } = default!;

        /// <summary>
        /// The ids of outgoing edges in the order they should be evaluated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("edge_order", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> EdgeOrder { get; set; } = default!;

        /// <summary>
        /// The ID of the agent to transfer the conversation to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentId { get; set; } = default!;

        /// <summary>
        /// Artificial delay in milliseconds applied before transferring the conversation.<br/>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delay_ms", Required = global::Newtonsoft.Json.Required.Always)]
        public int DelayMs { get; set; } = default!;

        /// <summary>
        /// Optional message sent to the user before the transfer is initiated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transfer_message")]
        public string? TransferMessage { get; set; }

        /// <summary>
        /// Whether to enable the transferred agent to send its configured first message after the transfer.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enable_transferred_agent_first_message", Required = global::Newtonsoft.Json.Required.Always)]
        public bool EnableTransferredAgentFirstMessage { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowStandaloneAgentNodeModelOutput" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: standalone_agent
        /// </param>
        /// <param name="position">
        /// Position of the node in the workflow.
        /// </param>
        /// <param name="edgeOrder">
        /// The ids of outgoing edges in the order they should be evaluated.
        /// </param>
        /// <param name="agentId">
        /// The ID of the agent to transfer the conversation to.
        /// </param>
        /// <param name="delayMs">
        /// Artificial delay in milliseconds applied before transferring the conversation.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="transferMessage">
        /// Optional message sent to the user before the transfer is initiated.
        /// </param>
        /// <param name="enableTransferredAgentFirstMessage">
        /// Whether to enable the transferred agent to send its configured first message after the transfer.<br/>
        /// Default Value: false
        /// </param>
        public WorkflowStandaloneAgentNodeModelOutput(
            global::G.PositionOutput position,
            global::System.Collections.Generic.IList<string> edgeOrder,
            string agentId,
            int delayMs,
            bool enableTransferredAgentFirstMessage,
            string? transferMessage,
            string type = "standalone_agent")
        {
            this.Position = position ?? throw new global::System.ArgumentNullException(nameof(position));
            this.EdgeOrder = edgeOrder ?? throw new global::System.ArgumentNullException(nameof(edgeOrder));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.DelayMs = delayMs;
            this.EnableTransferredAgentFirstMessage = enableTransferredAgentFirstMessage;
            this.Type = type;
            this.TransferMessage = transferMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowStandaloneAgentNodeModelOutput" /> class.
        /// </summary>
        public WorkflowStandaloneAgentNodeModelOutput()
        {
        }
    }
}