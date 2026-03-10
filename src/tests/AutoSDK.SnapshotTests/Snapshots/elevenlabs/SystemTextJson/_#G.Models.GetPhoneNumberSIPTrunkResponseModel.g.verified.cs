//HintName: G.Models.GetPhoneNumberSIPTrunkResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"label":"Sales Team","livekit_stack":"standard","phone_number":"\u002B1987654321","phone_number_id":"phone_456","provider":"sip_trunk"}
    /// </summary>
    public sealed partial class GetPhoneNumberSIPTrunkResponseModel
    {
        /// <summary>
        /// Phone number
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PhoneNumber { get; set; }

        /// <summary>
        /// Label for the phone number
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// This field is deprecated and will be removed in the future. Whether this phone number supports inbound calls<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_inbound")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? SupportsInbound { get; set; }

        /// <summary>
        /// This field is deprecated and will be removed in the future. Whether this phone number supports outbound calls<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_outbound")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? SupportsOutbound { get; set; }

        /// <summary>
        /// The ID of the phone number
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_number_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PhoneNumberId { get; set; }

        /// <summary>
        /// The agent that is assigned to the phone number
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assigned_agent")]
        public global::G.PhoneNumberAgentInfo? AssignedAgent { get; set; }

        /// <summary>
        /// Phone provider<br/>
        /// Default Value: sip_trunk
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_config")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.GetPhoneNumberOutboundSIPTrunkConfigResponseModel? ProviderConfig { get; set; }

        /// <summary>
        /// Configuration of the Outbound SIP trunk - if configured.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outbound_trunk")]
        public global::G.GetPhoneNumberOutboundSIPTrunkConfigResponseModel? OutboundTrunk { get; set; }

        /// <summary>
        /// Configuration of the Inbound SIP trunk - if configured.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inbound_trunk")]
        public global::G.GetPhoneNumberInboundSIPTrunkConfigResponseModel? InboundTrunk { get; set; }

        /// <summary>
        /// Type of Livekit stack used for this number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("livekit_stack")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.LivekitStackTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.LivekitStackType LivekitStack { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPhoneNumberSIPTrunkResponseModel" /> class.
        /// </summary>
        /// <param name="phoneNumber">
        /// Phone number
        /// </param>
        /// <param name="label">
        /// Label for the phone number
        /// </param>
        /// <param name="phoneNumberId">
        /// The ID of the phone number
        /// </param>
        /// <param name="assignedAgent">
        /// The agent that is assigned to the phone number
        /// </param>
        /// <param name="provider">
        /// Phone provider<br/>
        /// Default Value: sip_trunk
        /// </param>
        /// <param name="outboundTrunk">
        /// Configuration of the Outbound SIP trunk - if configured.
        /// </param>
        /// <param name="inboundTrunk">
        /// Configuration of the Inbound SIP trunk - if configured.
        /// </param>
        /// <param name="livekitStack">
        /// Type of Livekit stack used for this number.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetPhoneNumberSIPTrunkResponseModel(
            string phoneNumber,
            string label,
            string phoneNumberId,
            global::G.LivekitStackType livekitStack,
            global::G.PhoneNumberAgentInfo? assignedAgent,
            string? provider,
            global::G.GetPhoneNumberOutboundSIPTrunkConfigResponseModel? outboundTrunk,
            global::G.GetPhoneNumberInboundSIPTrunkConfigResponseModel? inboundTrunk)
        {
            this.PhoneNumber = phoneNumber ?? throw new global::System.ArgumentNullException(nameof(phoneNumber));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.PhoneNumberId = phoneNumberId ?? throw new global::System.ArgumentNullException(nameof(phoneNumberId));
            this.LivekitStack = livekitStack;
            this.AssignedAgent = assignedAgent;
            this.Provider = provider;
            this.OutboundTrunk = outboundTrunk;
            this.InboundTrunk = inboundTrunk;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPhoneNumberSIPTrunkResponseModel" /> class.
        /// </summary>
        public GetPhoneNumberSIPTrunkResponseModel()
        {
        }
    }
}