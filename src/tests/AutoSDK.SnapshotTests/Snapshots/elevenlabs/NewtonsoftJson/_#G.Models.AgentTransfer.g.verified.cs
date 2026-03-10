//HintName: G.Models.AgentTransfer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentTransfer
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("condition", Required = global::Newtonsoft.Json.Required.Always)]
        public string Condition { get; set; } = default!;

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delay_ms")]
        public int? DelayMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transfer_message")]
        public string? TransferMessage { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enable_transferred_agent_first_message")]
        public bool? EnableTransferredAgentFirstMessage { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_workflow_node_transfer")]
        public bool? IsWorkflowNodeTransfer { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTransfer" /> class.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="condition"></param>
        /// <param name="delayMs">
        /// Default Value: 0
        /// </param>
        /// <param name="transferMessage"></param>
        /// <param name="enableTransferredAgentFirstMessage">
        /// Default Value: false
        /// </param>
        /// <param name="isWorkflowNodeTransfer">
        /// Default Value: false
        /// </param>
        public AgentTransfer(
            string agentId,
            string condition,
            int? delayMs,
            string? transferMessage,
            bool? enableTransferredAgentFirstMessage,
            bool? isWorkflowNodeTransfer)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.Condition = condition ?? throw new global::System.ArgumentNullException(nameof(condition));
            this.DelayMs = delayMs;
            this.TransferMessage = transferMessage;
            this.EnableTransferredAgentFirstMessage = enableTransferredAgentFirstMessage;
            this.IsWorkflowNodeTransfer = isWorkflowNodeTransfer;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTransfer" /> class.
        /// </summary>
        public AgentTransfer()
        {
        }
    }
}