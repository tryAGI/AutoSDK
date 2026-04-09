//HintName: G.Models.TransferOptionWarmTransfer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TransferOptionWarmTransfer
    {
        /// <summary>
        /// The type of the transfer.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TransferOptionWarmTransferTypeJsonConverter))]
        public global::G.TransferOptionWarmTransferType Type { get; set; }

        /// <summary>
        /// If set to true, will show transferee (the user, not the AI agent) as caller when transferring, requires the telephony side to support caller id override. Retell Twilio numbers support this option.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("show_transferee_as_caller")]
        public bool? ShowTransfereeAsCaller { get; set; }

        /// <summary>
        /// The time to wait before considering transfer fails.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_detection_timeout_ms")]
        public double? AgentDetectionTimeoutMs { get; set; }

        /// <summary>
        /// Override the ring duration for this specific transfer, in milliseconds. If not set, falls back to the agent-level `ring_duration_ms`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transfer_ring_duration_ms")]
        public int? TransferRingDurationMs { get; set; }

        /// <summary>
        /// The music to play while the caller is being transferred.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("on_hold_music")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TransferOptionWarmTransferOnHoldMusicJsonConverter))]
        public global::G.TransferOptionWarmTransferOnHoldMusic? OnHoldMusic { get; set; }

        /// <summary>
        /// If set, when transfer is successful, will say the handoff message to both the transferee and the agent receiving the transfer. Can leave either a static message or a dynamic one based on prompt. Set to null to disable warm handoff.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("public_handoff_option")]
        public global::G.OneOf<global::G.WarmTransferPrompt, global::G.WarmTransferStaticMessage>? PublicHandoffOption { get; set; }

        /// <summary>
        /// If set, when transfer is connected, will say the handoff message only to the agent receiving the transfer. Can leave either a static message or a dynamic one based on prompt. Set to null to disable warm handoff.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("private_handoff_option")]
        public global::G.OneOf<global::G.WarmTransferPrompt, global::G.WarmTransferStaticMessage>? PrivateHandoffOption { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ivr_option")]
        public global::G.WarmTransferPrompt? IvrOption { get; set; }

        /// <summary>
        /// If set to true, will not perform human detection for the transfer. Default to false.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("opt_out_human_detection")]
        public bool? OptOutHumanDetection { get; set; }

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
        /// Initializes a new instance of the <see cref="TransferOptionWarmTransfer" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the transfer.
        /// </param>
        /// <param name="showTransfereeAsCaller">
        /// If set to true, will show transferee (the user, not the AI agent) as caller when transferring, requires the telephony side to support caller id override. Retell Twilio numbers support this option.
        /// </param>
        /// <param name="agentDetectionTimeoutMs">
        /// The time to wait before considering transfer fails.
        /// </param>
        /// <param name="transferRingDurationMs">
        /// Override the ring duration for this specific transfer, in milliseconds. If not set, falls back to the agent-level `ring_duration_ms`.
        /// </param>
        /// <param name="onHoldMusic">
        /// The music to play while the caller is being transferred.
        /// </param>
        /// <param name="publicHandoffOption">
        /// If set, when transfer is successful, will say the handoff message to both the transferee and the agent receiving the transfer. Can leave either a static message or a dynamic one based on prompt. Set to null to disable warm handoff.
        /// </param>
        /// <param name="privateHandoffOption">
        /// If set, when transfer is connected, will say the handoff message only to the agent receiving the transfer. Can leave either a static message or a dynamic one based on prompt. Set to null to disable warm handoff.
        /// </param>
        /// <param name="ivrOption"></param>
        /// <param name="optOutHumanDetection">
        /// If set to true, will not perform human detection for the transfer. Default to false.
        /// </param>
        /// <param name="enableBridgeAudioCue">
        /// Whether to play an audio cue when bridging the call. Defaults to true.<br/>
        /// Default Value: true
        /// </param>
        public TransferOptionWarmTransfer(
            global::G.TransferOptionWarmTransferType type,
            bool? showTransfereeAsCaller,
            double? agentDetectionTimeoutMs,
            int? transferRingDurationMs,
            global::G.TransferOptionWarmTransferOnHoldMusic? onHoldMusic,
            global::G.OneOf<global::G.WarmTransferPrompt, global::G.WarmTransferStaticMessage>? publicHandoffOption,
            global::G.OneOf<global::G.WarmTransferPrompt, global::G.WarmTransferStaticMessage>? privateHandoffOption,
            global::G.WarmTransferPrompt? ivrOption,
            bool? optOutHumanDetection,
            bool? enableBridgeAudioCue)
        {
            this.Type = type;
            this.ShowTransfereeAsCaller = showTransfereeAsCaller;
            this.AgentDetectionTimeoutMs = agentDetectionTimeoutMs;
            this.TransferRingDurationMs = transferRingDurationMs;
            this.OnHoldMusic = onHoldMusic;
            this.PublicHandoffOption = publicHandoffOption;
            this.PrivateHandoffOption = privateHandoffOption;
            this.IvrOption = ivrOption;
            this.OptOutHumanDetection = optOutHumanDetection;
            this.EnableBridgeAudioCue = enableBridgeAudioCue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferOptionWarmTransfer" /> class.
        /// </summary>
        public TransferOptionWarmTransfer()
        {
        }
    }
}