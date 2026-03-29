//HintName: G.Models.ByoSipTrunkCredential.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ByoSipTrunkCredential
    {
        /// <summary>
        /// This can be used to bring your own SIP trunks or to connect to a Carrier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ByoSipTrunkCredentialProviderJsonConverter))]
        public global::G.ByoSipTrunkCredentialProvider? Provider { get; set; }

        /// <summary>
        /// This is the unique identifier for the credential.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// This is the unique identifier for the org that this credential belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrgId { get; set; }

        /// <summary>
        /// This is the ISO 8601 date-time string of when the credential was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// This is the ISO 8601 date-time string of when the assistant was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// This is the name of credential. This is just for your reference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// This is the list of SIP trunk's gateways.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gateways")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.SipTrunkGateway> Gateways { get; set; }

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
        /// Initializes a new instance of the <see cref="ByoSipTrunkCredential" /> class.
        /// </summary>
        /// <param name="id">
        /// This is the unique identifier for the credential.
        /// </param>
        /// <param name="orgId">
        /// This is the unique identifier for the org that this credential belongs to.
        /// </param>
        /// <param name="createdAt">
        /// This is the ISO 8601 date-time string of when the credential was created.
        /// </param>
        /// <param name="updatedAt">
        /// This is the ISO 8601 date-time string of when the assistant was last updated.
        /// </param>
        /// <param name="gateways">
        /// This is the list of SIP trunk's gateways.
        /// </param>
        /// <param name="provider">
        /// This can be used to bring your own SIP trunks or to connect to a Carrier.
        /// </param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
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
        public ByoSipTrunkCredential(
            string id,
            string orgId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.Collections.Generic.IList<global::G.SipTrunkGateway> gateways,
            global::G.ByoSipTrunkCredentialProvider? provider,
            string? name,
            global::G.SipTrunkOutboundAuthenticationPlan? outboundAuthenticationPlan,
            bool? outboundLeadingPlusEnabled,
            string? techPrefix,
            string? sipDiversionHeader,
            global::G.SbcConfiguration? sbcConfiguration)
        {
            this.Provider = provider;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Name = name;
            this.Gateways = gateways ?? throw new global::System.ArgumentNullException(nameof(gateways));
            this.OutboundAuthenticationPlan = outboundAuthenticationPlan;
            this.OutboundLeadingPlusEnabled = outboundLeadingPlusEnabled;
            this.TechPrefix = techPrefix;
            this.SipDiversionHeader = sipDiversionHeader;
            this.SbcConfiguration = sbcConfiguration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ByoSipTrunkCredential" /> class.
        /// </summary>
        public ByoSipTrunkCredential()
        {
        }
    }
}