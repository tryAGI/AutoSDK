//HintName: G.Models.TransferToAgentToolConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TransferToAgentToolConfig
    {
        /// <summary>
        /// Default Value: transfer_to_agent
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("system_tool_type")]
        public global::G.TransferToAgentToolConfigSystemToolType? SystemToolType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transfers", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.AgentTransfer> Transfers { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferToAgentToolConfig" /> class.
        /// </summary>
        /// <param name="systemToolType">
        /// Default Value: transfer_to_agent
        /// </param>
        /// <param name="transfers"></param>
        public TransferToAgentToolConfig(
            global::System.Collections.Generic.IList<global::G.AgentTransfer> transfers,
            global::G.TransferToAgentToolConfigSystemToolType? systemToolType)
        {
            this.Transfers = transfers ?? throw new global::System.ArgumentNullException(nameof(transfers));
            this.SystemToolType = systemToolType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferToAgentToolConfig" /> class.
        /// </summary>
        public TransferToAgentToolConfig()
        {
        }
    }
}