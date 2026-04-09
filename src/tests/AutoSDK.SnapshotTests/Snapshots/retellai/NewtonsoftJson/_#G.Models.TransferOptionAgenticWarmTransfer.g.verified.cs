//HintName: G.Models.TransferOptionAgenticWarmTransfer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TransferOptionAgenticWarmTransfer
    {
        /// <summary>
        /// The type of the transfer.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TransferOptionAgenticWarmTransferTypeJsonConverter))]
        public global::G.TransferOptionAgenticWarmTransferType Type { get; set; }

        /// <summary>
        /// If set to true, will show transferee (the user, not the AI agent) as caller when transferring, requires the telephony side to support caller id override. Retell Twilio numbers support this option.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("show_transferee_as_caller")]
        public bool? ShowTransfereeAsCaller { get; set; }

        /// <summary>
        /// The music to play while the caller is being transferred.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("on_hold_music")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TransferOptionAgenticWarmTransferOnHoldMusicJsonConverter))]
        public global::G.TransferOptionAgenticWarmTransferOnHoldMusic? OnHoldMusic { get; set; }

        /// <summary>
        /// Override the ring duration for this specific transfer, in milliseconds. If not set, falls back to the agent-level `ring_duration_ms`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transfer_ring_duration_ms")]
        public int? TransferRingDurationMs { get; set; }

        /// <summary>
        /// If set, when transfer is successful, will say the handoff message to both the transferee and the agent receiving the transfer. Can leave either a static message or a dynamic one based on prompt. Set to null to disable warm handoff.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("public_handoff_option")]
        public global::G.OneOf<global::G.WarmTransferPrompt, global::G.WarmTransferStaticMessage>? PublicHandoffOption { get; set; }

        /// <summary>
        /// Configuration for agentic warm transfer. Required for agentic warm transfer.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agentic_transfer_config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TransferOptionAgenticWarmTransferAgenticTransferConfig AgenticTransferConfig { get; set; } = default!;

        /// <summary>
        /// Whether to play an audio cue when bridging the call. Defaults to true.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enable_bridge_audio_cue")]
        public bool? EnableBridgeAudioCue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferOptionAgenticWarmTransfer" /> class.
        /// </summary>
        /// <param name="agenticTransferConfig">
        /// Configuration for agentic warm transfer. Required for agentic warm transfer.
        /// </param>
        /// <param name="type">
        /// The type of the transfer.
        /// </param>
        /// <param name="showTransfereeAsCaller">
        /// If set to true, will show transferee (the user, not the AI agent) as caller when transferring, requires the telephony side to support caller id override. Retell Twilio numbers support this option.
        /// </param>
        /// <param name="onHoldMusic">
        /// The music to play while the caller is being transferred.
        /// </param>
        /// <param name="transferRingDurationMs">
        /// Override the ring duration for this specific transfer, in milliseconds. If not set, falls back to the agent-level `ring_duration_ms`.
        /// </param>
        /// <param name="publicHandoffOption">
        /// If set, when transfer is successful, will say the handoff message to both the transferee and the agent receiving the transfer. Can leave either a static message or a dynamic one based on prompt. Set to null to disable warm handoff.
        /// </param>
        /// <param name="enableBridgeAudioCue">
        /// Whether to play an audio cue when bridging the call. Defaults to true.<br/>
        /// Default Value: true
        /// </param>
        public TransferOptionAgenticWarmTransfer(
            global::G.TransferOptionAgenticWarmTransferAgenticTransferConfig agenticTransferConfig,
            global::G.TransferOptionAgenticWarmTransferType type,
            bool? showTransfereeAsCaller,
            global::G.TransferOptionAgenticWarmTransferOnHoldMusic? onHoldMusic,
            int? transferRingDurationMs,
            global::G.OneOf<global::G.WarmTransferPrompt, global::G.WarmTransferStaticMessage>? publicHandoffOption,
            bool? enableBridgeAudioCue)
        {
            this.Type = type;
            this.ShowTransfereeAsCaller = showTransfereeAsCaller;
            this.OnHoldMusic = onHoldMusic;
            this.TransferRingDurationMs = transferRingDurationMs;
            this.PublicHandoffOption = publicHandoffOption;
            this.AgenticTransferConfig = agenticTransferConfig ?? throw new global::System.ArgumentNullException(nameof(agenticTransferConfig));
            this.EnableBridgeAudioCue = enableBridgeAudioCue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferOptionAgenticWarmTransfer" /> class.
        /// </summary>
        public TransferOptionAgenticWarmTransfer()
        {
        }
    }
}