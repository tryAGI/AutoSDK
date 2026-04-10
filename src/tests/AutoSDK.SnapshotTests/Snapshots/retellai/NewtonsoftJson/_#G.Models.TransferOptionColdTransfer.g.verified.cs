//HintName: G.Models.TransferOptionColdTransfer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TransferOptionColdTransfer
    {
        /// <summary>
        /// The type of the transfer.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TransferOptionColdTransferTypeJsonConverter))]
        public global::G.TransferOptionColdTransferType Type { get; set; }

        /// <summary>
        /// If set to true, will show transferee (the user, not the AI agent) as caller when transferring. Requires the telephony side to support caller id override. Retell Twilio numbers support this option. This parameter takes effect only when `cold_transfer_mode` is set to `sip_invite`. When using `sip_refer`, this option is not available. Retell Twilio numbers always use user's number as the caller id when using `sip refer` cold transfer mode.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("show_transferee_as_caller")]
        public bool? ShowTransfereeAsCaller { get; set; }

        /// <summary>
        /// The mode of the cold transfer. If set to `sip_refer`, will use SIP REFER to transfer the call. If set to `sip_invite`, will use SIP INVITE to transfer the call.<br/>
        /// Default Value: sip_invite
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cold_transfer_mode")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TransferOptionColdTransferColdTransferModeJsonConverter))]
        public global::G.TransferOptionColdTransferColdTransferMode? ColdTransferMode { get; set; }

        /// <summary>
        /// Override the ring duration for this specific transfer, in milliseconds. If not set, falls back to the agent-level `ring_duration_ms`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transfer_ring_duration_ms")]
        public int? TransferRingDurationMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferOptionColdTransfer" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the transfer.
        /// </param>
        /// <param name="showTransfereeAsCaller">
        /// If set to true, will show transferee (the user, not the AI agent) as caller when transferring. Requires the telephony side to support caller id override. Retell Twilio numbers support this option. This parameter takes effect only when `cold_transfer_mode` is set to `sip_invite`. When using `sip_refer`, this option is not available. Retell Twilio numbers always use user's number as the caller id when using `sip refer` cold transfer mode.
        /// </param>
        /// <param name="coldTransferMode">
        /// The mode of the cold transfer. If set to `sip_refer`, will use SIP REFER to transfer the call. If set to `sip_invite`, will use SIP INVITE to transfer the call.<br/>
        /// Default Value: sip_invite
        /// </param>
        /// <param name="transferRingDurationMs">
        /// Override the ring duration for this specific transfer, in milliseconds. If not set, falls back to the agent-level `ring_duration_ms`.
        /// </param>
        public TransferOptionColdTransfer(
            global::G.TransferOptionColdTransferType type,
            bool? showTransfereeAsCaller,
            global::G.TransferOptionColdTransferColdTransferMode? coldTransferMode,
            int? transferRingDurationMs)
        {
            this.Type = type;
            this.ShowTransfereeAsCaller = showTransfereeAsCaller;
            this.ColdTransferMode = coldTransferMode;
            this.TransferRingDurationMs = transferRingDurationMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferOptionColdTransfer" /> class.
        /// </summary>
        public TransferOptionColdTransfer()
        {
        }
    }
}