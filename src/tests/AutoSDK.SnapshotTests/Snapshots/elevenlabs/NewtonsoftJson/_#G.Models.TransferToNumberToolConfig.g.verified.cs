//HintName: G.Models.TransferToNumberToolConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TransferToNumberToolConfig
    {
        /// <summary>
        /// Default Value: transfer_to_number
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("system_tool_type")]
        public string? SystemToolType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transfers", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.PhoneNumberTransfer> Transfers { get; set; } = default!;

        /// <summary>
        /// Whether to play a message to the client while they wait for transfer. Defaults to true for backward compatibility.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enable_client_message")]
        public bool? EnableClientMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferToNumberToolConfig" /> class.
        /// </summary>
        /// <param name="systemToolType">
        /// Default Value: transfer_to_number
        /// </param>
        /// <param name="transfers"></param>
        /// <param name="enableClientMessage">
        /// Whether to play a message to the client while they wait for transfer. Defaults to true for backward compatibility.<br/>
        /// Default Value: true
        /// </param>
        public TransferToNumberToolConfig(
            global::System.Collections.Generic.IList<global::G.PhoneNumberTransfer> transfers,
            string? systemToolType,
            bool? enableClientMessage)
        {
            this.Transfers = transfers ?? throw new global::System.ArgumentNullException(nameof(transfers));
            this.SystemToolType = systemToolType;
            this.EnableClientMessage = enableClientMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferToNumberToolConfig" /> class.
        /// </summary>
        public TransferToNumberToolConfig()
        {
        }
    }
}