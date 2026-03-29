//HintName: G.Models.TransferOptionAgenticWarmTransferAgenticTransferConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for agentic warm transfer. Required for agentic warm transfer.
    /// </summary>
    public sealed partial class TransferOptionAgenticWarmTransferAgenticTransferConfig
    {
        /// <summary>
        /// The agent that will mediate the transfer decision.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_agent")]
        public global::G.TransferOptionAgenticWarmTransferAgenticTransferConfigTransferAgent? TransferAgent { get; set; }

        /// <summary>
        /// The maximum time to wait for the transfer agent to make a decision, in milliseconds. Defaults to 30000 (30 seconds).<br/>
        /// Default Value: 30000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_timeout_ms")]
        public double? TransferTimeoutMs { get; set; }

        /// <summary>
        /// The action to take when the transfer agent times out without making a decision. Defaults to cancel_transfer.<br/>
        /// Default Value: cancel_transfer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action_on_timeout")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TransferOptionAgenticWarmTransferAgenticTransferConfigActionOnTimeoutJsonConverter))]
        public global::G.TransferOptionAgenticWarmTransferAgenticTransferConfigActionOnTimeout? ActionOnTimeout { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferOptionAgenticWarmTransferAgenticTransferConfig" /> class.
        /// </summary>
        /// <param name="transferAgent">
        /// The agent that will mediate the transfer decision.
        /// </param>
        /// <param name="transferTimeoutMs">
        /// The maximum time to wait for the transfer agent to make a decision, in milliseconds. Defaults to 30000 (30 seconds).<br/>
        /// Default Value: 30000
        /// </param>
        /// <param name="actionOnTimeout">
        /// The action to take when the transfer agent times out without making a decision. Defaults to cancel_transfer.<br/>
        /// Default Value: cancel_transfer
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TransferOptionAgenticWarmTransferAgenticTransferConfig(
            global::G.TransferOptionAgenticWarmTransferAgenticTransferConfigTransferAgent? transferAgent,
            double? transferTimeoutMs,
            global::G.TransferOptionAgenticWarmTransferAgenticTransferConfigActionOnTimeout? actionOnTimeout)
        {
            this.TransferAgent = transferAgent;
            this.TransferTimeoutMs = transferTimeoutMs;
            this.ActionOnTimeout = actionOnTimeout;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferOptionAgenticWarmTransferAgenticTransferConfig" /> class.
        /// </summary>
        public TransferOptionAgenticWarmTransferAgenticTransferConfig()
        {
        }
    }
}