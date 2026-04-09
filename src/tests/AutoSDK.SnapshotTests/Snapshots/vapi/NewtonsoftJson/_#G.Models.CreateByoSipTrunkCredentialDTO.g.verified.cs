//HintName: G.Models.CreateByoSipTrunkCredentialDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateByoSipTrunkCredentialDTO
    {
        /// <summary>
        /// This can be used to bring your own SIP trunks or to connect to a Carrier.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateByoSipTrunkCredentialDTOProviderJsonConverter))]
        public global::G.CreateByoSipTrunkCredentialDTOProvider? Provider { get; set; }

        /// <summary>
        /// This is the list of SIP trunk's gateways.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gateways", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.SipTrunkGateway> Gateways { get; set; } = default!;

        /// <summary>
        /// This can be used to configure the outbound authentication if required by the SIP trunk.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outboundAuthenticationPlan")]
        public global::G.SipTrunkOutboundAuthenticationPlan? OutboundAuthenticationPlan { get; set; }

        /// <summary>
        /// This ensures the outbound origination attempts have a leading plus. Defaults to false to match conventional telecom behavior.<br/>
        /// Usage:<br/>
        /// - Vonage/Twilio requires leading plus for all outbound calls. Set this to true.<br/>
        /// @default false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outboundLeadingPlusEnabled")]
        public bool? OutboundLeadingPlusEnabled { get; set; }

        /// <summary>
        /// This can be used to configure the tech prefix on outbound calls. This is an advanced property.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("techPrefix")]
        public string? TechPrefix { get; set; }

        /// <summary>
        /// This can be used to enable the SIP diversion header for authenticating the calling number if the SIP trunk supports it. This is an advanced property.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sipDiversionHeader")]
        public string? SipDiversionHeader { get; set; }

        /// <summary>
        /// This is an advanced configuration for enterprise deployments. This uses the onprem SBC to trunk into the SIP trunk's `gateways`, rather than the managed SBC provided by Vapi.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sbcConfiguration")]
        public global::G.SbcConfiguration? SbcConfiguration { get; set; }

        /// <summary>
        /// This is the name of credential. This is just for your reference.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateByoSipTrunkCredentialDTO" /> class.
        /// </summary>
        /// <param name="gateways">
        /// This is the list of SIP trunk's gateways.
        /// </param>
        /// <param name="provider">
        /// This can be used to bring your own SIP trunks or to connect to a Carrier.
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
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
        public CreateByoSipTrunkCredentialDTO(
            global::System.Collections.Generic.IList<global::G.SipTrunkGateway> gateways,
            global::G.CreateByoSipTrunkCredentialDTOProvider? provider,
            global::G.SipTrunkOutboundAuthenticationPlan? outboundAuthenticationPlan,
            bool? outboundLeadingPlusEnabled,
            string? techPrefix,
            string? sipDiversionHeader,
            global::G.SbcConfiguration? sbcConfiguration,
            string? name)
        {
            this.Provider = provider;
            this.Gateways = gateways ?? throw new global::System.ArgumentNullException(nameof(gateways));
            this.OutboundAuthenticationPlan = outboundAuthenticationPlan;
            this.OutboundLeadingPlusEnabled = outboundLeadingPlusEnabled;
            this.TechPrefix = techPrefix;
            this.SipDiversionHeader = sipDiversionHeader;
            this.SbcConfiguration = sbcConfiguration;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateByoSipTrunkCredentialDTO" /> class.
        /// </summary>
        public CreateByoSipTrunkCredentialDTO()
        {
        }
    }
}