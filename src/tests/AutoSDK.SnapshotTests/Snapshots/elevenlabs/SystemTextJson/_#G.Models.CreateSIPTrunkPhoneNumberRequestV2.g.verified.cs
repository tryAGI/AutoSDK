//HintName: G.Models.CreateSIPTrunkPhoneNumberRequestV2.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSIPTrunkPhoneNumberRequestV2
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
        /// Default Value: sip_trunk
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inbound_trunk_config")]
        public global::G.InboundSIPTrunkConfigRequestModel? InboundTrunkConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outbound_trunk_config")]
        public global::G.OutboundSIPTrunkConfigRequestModel? OutboundTrunkConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSIPTrunkPhoneNumberRequestV2" /> class.
        /// </summary>
        /// <param name="phoneNumber">
        /// Phone number
        /// </param>
        /// <param name="label">
        /// Label for the phone number
        /// </param>
        /// <param name="provider">
        /// Default Value: sip_trunk
        /// </param>
        /// <param name="inboundTrunkConfig"></param>
        /// <param name="outboundTrunkConfig"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSIPTrunkPhoneNumberRequestV2(
            string phoneNumber,
            string label,
            string? provider,
            global::G.InboundSIPTrunkConfigRequestModel? inboundTrunkConfig,
            global::G.OutboundSIPTrunkConfigRequestModel? outboundTrunkConfig)
        {
            this.PhoneNumber = phoneNumber ?? throw new global::System.ArgumentNullException(nameof(phoneNumber));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Provider = provider;
            this.InboundTrunkConfig = inboundTrunkConfig;
            this.OutboundTrunkConfig = outboundTrunkConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSIPTrunkPhoneNumberRequestV2" /> class.
        /// </summary>
        public CreateSIPTrunkPhoneNumberRequestV2()
        {
        }
    }
}