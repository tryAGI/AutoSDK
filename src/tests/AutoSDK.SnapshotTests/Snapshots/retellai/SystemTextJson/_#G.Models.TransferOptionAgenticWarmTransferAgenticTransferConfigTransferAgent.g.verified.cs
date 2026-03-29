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
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// The version of the transfer agent to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AgentVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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