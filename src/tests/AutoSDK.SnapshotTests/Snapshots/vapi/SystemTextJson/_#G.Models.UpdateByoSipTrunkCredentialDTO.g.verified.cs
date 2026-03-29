//HintName: G.Models.UpdateByoSipTrunkCredentialDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateByoSipTrunkCredentialDTO
    {
        /// <summary>
        /// This is the name of credential. This is just for your reference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// This is the list of SIP trunk's gateways.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gateways")]
        public global::System.Collections.Generic.IList<global::G.SipTrunkGateway>? Gateways { get; set; }

        /// <summary>
        /// This can be used to configure the outbound authentication if required by the SIP trunk.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outboundAuthenticationPlan")]
        public global::G.SipTrunkOutboundAuthenticationPlan? OutboundAuthenticationPlan { get; set; }

        /// <summary>
        /// This ensures the outbound origination attempts have a leading plus. Defaults to false to match conventional telecom behavior.<br/>
        /// Usage:<br/>
        /// - Vonage/Twilio requires leading plus for all outbound calls. Set this to true.<br/>
        /// @default false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outboundLeadingPlusEnabled")]
        public bool? OutboundLeadingPlusEnabled { get; set; }

        /// <summary>
        /// This can be used to configure the tech prefix on outbound calls. This is an advanced property.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("techPrefix")]
        public string? TechPrefix { get; set; }

        /// <summary>
        /// This can be used to enable the SIP diversion header for authenticating the calling number if the SIP trunk supports it. This is an advanced property.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sipDiversionHeader")]
        public string? SipDiversionHeader { get; set; }

        /// <summary>
        /// This is an advanced configuration for enterprise deployments. This uses the onprem SBC to trunk into the SIP trunk's `gateways`, rather than the managed SBC provided by Vapi.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sbcConfiguration")]
        public global::G.SbcConfiguration? SbcConfiguration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateByoSipTrunkCredentialDTO" /> class.
        /// </summary>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
        /// <param name="gateways">
        /// This is the list of SIP trunk's gateways.
        /// </param>
        /// <param name="outboundAuthenticationPlan">
        /// This can be used to configure the outbound authentication if required by the SIP trunk.
        /// </param>
        /// <param name="outboundLeadingPlusEnabled">
        /// This ensures the outbound origination attempts have a leading plus. Defaults to false to match conventional telecom behavior.<br/>
        /// Usage:<br/>
        /// - Vonage/Twilio requires leading plus for all outbound calls. Set this to true.<br/>
        /// @default false
        /// </param>
        /// <param name="techPrefix">
        /// This can be used to configure the tech prefix on outbound calls. This is an advanced property.
        /// </param>
        /// <param name="sipDiversionHeader">
        /// This can be used to enable the SIP diversion header for authenticating the calling number if the SIP trunk supports it. This is an advanced property.
        /// </param>
        /// <param name="sbcConfiguration">
        /// This is an advanced configuration for enterprise deployments. This uses the onprem SBC to trunk into the SIP trunk's `gateways`, rather than the managed SBC provided by Vapi.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateByoSipTrunkCredentialDTO(
            string? name,
            global::System.Collections.Generic.IList<global::G.SipTrunkGateway>? gateways,
            global::G.SipTrunkOutboundAuthenticationPlan? outboundAuthenticationPlan,
            bool? outboundLeadingPlusEnabled,
            string? techPrefix,
            string? sipDiversionHeader,
            global::G.SbcConfiguration? sbcConfiguration)
        {
            this.Name = name;
            this.Gateways = gateways;
            this.OutboundAuthenticationPlan = outboundAuthenticationPlan;
            this.OutboundLeadingPlusEnabled = outboundLeadingPlusEnabled;
            this.TechPrefix = techPrefix;
            this.SipDiversionHeader = sipDiversionHeader;
            this.SbcConfiguration = sbcConfiguration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateByoSipTrunkCredentialDTO" /> class.
        /// </summary>
        public UpdateByoSipTrunkCredentialDTO()
        {
        }
    }
}