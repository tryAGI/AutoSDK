//HintName: G.Models.TransferOptionAgenticWarmTransferAgenticTransferConfigTransferAgent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The agent that will mediate the transfer decision.
    /// </summary>
    public sealed partial class TransferOptionAgenticWarmTransferAgenticTransferConfigTransferAgent
    {
        /// <summary>
        /// The agent ID of the transfer agent. This agent must have isTransferAgent set to true and should use bridge_transfer and cancel_transfer tools (for Retell LLM) or BridgeTransferNode and CancelTransferNode (for Conversation Flow).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentId { get; set; } = default!;

        /// <summary>
        /// The version of the transfer agent to use.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_version", Required = global::Newtonsoft.Json.Required.Always)]
        public double AgentVersion { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferOptionAgenticWarmTransferAgenticTransferConfigTransferAgent" /> class.
        /// </summary>
        /// <param name="agentId">
        /// The agent ID of the transfer agent. This agent must have isTransferAgent set to true and should use bridge_transfer and cancel_transfer tools (for Retell LLM) or BridgeTransferNode and CancelTransferNode (for Conversation Flow).
        /// </param>
        /// <param name="agentVersion">
        /// The version of the transfer agent to use.
        /// </param>
        public TransferOptionAgenticWarmTransferAgenticTransferConfigTransferAgent(
            string agentId,
            double agentVersion)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.AgentVersion = agentVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferOptionAgenticWarmTransferAgenticTransferConfigTransferAgent" /> class.
        /// </summary>
        public TransferOptionAgenticWarmTransferAgenticTransferConfigTransferAgent()
        {
        }
    }
}