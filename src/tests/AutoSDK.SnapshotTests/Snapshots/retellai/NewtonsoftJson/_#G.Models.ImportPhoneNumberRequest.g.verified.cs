//HintName: G.Models.ImportPhoneNumberRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImportPhoneNumberRequest
    {
        /// <summary>
        /// The number you are trying to import in E.164 format of the number (+country code, then number with no space, no special characters), used as the unique identifier for phone number APIs.<br/>
        /// Example: +14157774444
        /// </summary>
        /// <example>+14157774444</example>
        [global::Newtonsoft.Json.JsonProperty("phone_number", Required = global::Newtonsoft.Json.Required.Always)]
        public string PhoneNumber { get; set; } = default!;

        /// <summary>
        /// If true, E.164 validation for phone_number is skipped. This is useful for internal pseudo numbers when using custom telephony. If omitted, default is true. Must be a boolean literal; string values like "true" or "false" are invalid.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("ignore_e164_validation")]
        public bool? IgnoreE164Validation { get; set; }

        /// <summary>
        /// The termination uri to uniquely identify your elastic SIP trunk. This is used for outbound calls. For Twilio elastic SIP trunks it always end with ".pstn.twilio.com".<br/>
        /// Example: someuri.pstn.twilio.com
        /// </summary>
        /// <example>someuri.pstn.twilio.com</example>
        [global::Newtonsoft.Json.JsonProperty("termination_uri", Required = global::Newtonsoft.Json.Required.Always)]
        public string TerminationUri { get; set; } = default!;

        /// <summary>
        /// The username used for authentication for the SIP trunk.<br/>
        /// Example: username
        /// </summary>
        /// <example>username</example>
        [global::Newtonsoft.Json.JsonProperty("sip_trunk_auth_username")]
        public string? SipTrunkAuthUsername { get; set; }

        /// <summary>
        /// The password used for authentication for the SIP trunk.<br/>
        /// Example: 123456
        /// </summary>
        /// <example>123456</example>
        [global::Newtonsoft.Json.JsonProperty("sip_trunk_auth_password")]
        public string? SipTrunkAuthPassword { get; set; }

        /// <summary>
        /// Unique id of agent to bind to the number. The number will automatically use the agent when receiving inbound calls. If null, this number would not accept inbound call. Deprecated. See https://docs.retellai.com/deprecation-notice/2026/03-31_phone_number_agent_fields<br/>
        /// Example: oBeDLoLOeuAbiuaMFXRtDOLriTJ5tSxD
        /// </summary>
        /// <example>oBeDLoLOeuAbiuaMFXRtDOLriTJ5tSxD</example>
        [global::Newtonsoft.Json.JsonProperty("inbound_agent_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? InboundAgentId { get; set; }

        /// <summary>
        /// Unique id of agent to bind to the number. The number will automatically use the agent when conducting outbound calls. If null, this number would not be able to initiate outbound call without agent id override. Deprecated. See https://docs.retellai.com/deprecation-notice/2026/03-31_phone_number_agent_fields<br/>
        /// Example: oBeDLoLOeuAbiuaMFXRtDOLriTJ5tSxD
        /// </summary>
        /// <example>oBeDLoLOeuAbiuaMFXRtDOLriTJ5tSxD</example>
        [global::Newtonsoft.Json.JsonProperty("outbound_agent_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? OutboundAgentId { get; set; }

        /// <summary>
        /// Version of the inbound agent to bind to the number. If not provided, will default to latest version. Deprecated. See https://docs.retellai.com/deprecation-notice/2026/03-31_phone_number_agent_fields<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("inbound_agent_version")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? InboundAgentVersion { get; set; }

        /// <summary>
        /// Version of the outbound agent to bind to the number. If not provided, will default to latest version. Deprecated. See https://docs.retellai.com/deprecation-notice/2026/03-31_phone_number_agent_fields<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("outbound_agent_version")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? OutboundAgentVersion { get; set; }

        /// <summary>
        /// Inbound agents to bind to the number with weights. If set and non-empty, one agent will be picked randomly for each inbound call, with probability proportional to the weight. Total weights must add up to 1. If not set or empty, fallback to inbound_agent_id.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inbound_agents")]
        public global::System.Collections.Generic.IList<global::G.AgentWeight>? InboundAgents { get; set; }

        /// <summary>
        /// Outbound agents to bind to the number with weights. If set and non-empty, one agent will be picked randomly for each outbound call, with probability proportional to the weight. Total weights must add up to 1. If not set or empty, fallback to outbound_agent_id.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outbound_agents")]
        public global::System.Collections.Generic.IList<global::G.AgentWeight>? OutboundAgents { get; set; }

        /// <summary>
        /// Nickname of the number. This is for your reference only.<br/>
        /// Example: Frontdesk Number
        /// </summary>
        /// <example>Frontdesk Number</example>
        [global::Newtonsoft.Json.JsonProperty("nickname")]
        public string? Nickname { get; set; }

        /// <summary>
        /// If set, will send a webhook for inbound calls, where you can to override agent id, set dynamic variables and other fields specific to that call.<br/>
        /// Example: https://example.com/inbound-webhook
        /// </summary>
        /// <example>https://example.com/inbound-webhook</example>
        [global::Newtonsoft.Json.JsonProperty("inbound_webhook_url")]
        public string? InboundWebhookUrl { get; set; }

        /// <summary>
        /// List of ISO 3166-1 alpha-2 country codes from which inbound calls are allowed. If not set or empty, calls from all countries are allowed.<br/>
        /// Example: [US, CA, GB]
        /// </summary>
        /// <example>[US, CA, GB]</example>
        [global::Newtonsoft.Json.JsonProperty("allowed_inbound_country_list")]
        public global::System.Collections.Generic.IList<string>? AllowedInboundCountryList { get; set; }

        /// <summary>
        /// List of ISO 3166-1 alpha-2 country codes to which outbound calls are allowed. If not set or empty, calls to all countries are allowed.<br/>
        /// Example: [US, CA]
        /// </summary>
        /// <example>[US, CA]</example>
        [global::Newtonsoft.Json.JsonProperty("allowed_outbound_country_list")]
        public global::System.Collections.Generic.IList<string>? AllowedOutboundCountryList { get; set; }

        /// <summary>
        /// Outbound transport protocol to update for the phone number. Valid values are "TLS", "TCP" and "UDP". Default is "TCP".<br/>
        /// Example: TCP
        /// </summary>
        /// <example>TCP</example>
        [global::Newtonsoft.Json.JsonProperty("transport")]
        public string? Transport { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportPhoneNumberRequest" /> class.
        /// </summary>
        /// <param name="phoneNumber">
        /// The number you are trying to import in E.164 format of the number (+country code, then number with no space, no special characters), used as the unique identifier for phone number APIs.<br/>
        /// Example: +14157774444
        /// </param>
        /// <param name="terminationUri">
        /// The termination uri to uniquely identify your elastic SIP trunk. This is used for outbound calls. For Twilio elastic SIP trunks it always end with ".pstn.twilio.com".<br/>
        /// Example: someuri.pstn.twilio.com
        /// </param>
        /// <param name="ignoreE164Validation">
        /// If true, E.164 validation for phone_number is skipped. This is useful for internal pseudo numbers when using custom telephony. If omitted, default is true. Must be a boolean literal; string values like "true" or "false" are invalid.<br/>
        /// Example: true
        /// </param>
        /// <param name="sipTrunkAuthUsername">
        /// The username used for authentication for the SIP trunk.<br/>
        /// Example: username
        /// </param>
        /// <param name="sipTrunkAuthPassword">
        /// The password used for authentication for the SIP trunk.<br/>
        /// Example: 123456
        /// </param>
        /// <param name="inboundAgents">
        /// Inbound agents to bind to the number with weights. If set and non-empty, one agent will be picked randomly for each inbound call, with probability proportional to the weight. Total weights must add up to 1. If not set or empty, fallback to inbound_agent_id.
        /// </param>
        /// <param name="outboundAgents">
        /// Outbound agents to bind to the number with weights. If set and non-empty, one agent will be picked randomly for each outbound call, with probability proportional to the weight. Total weights must add up to 1. If not set or empty, fallback to outbound_agent_id.
        /// </param>
        /// <param name="nickname">
        /// Nickname of the number. This is for your reference only.<br/>
        /// Example: Frontdesk Number
        /// </param>
        /// <param name="inboundWebhookUrl">
        /// If set, will send a webhook for inbound calls, where you can to override agent id, set dynamic variables and other fields specific to that call.<br/>
        /// Example: https://example.com/inbound-webhook
        /// </param>
        /// <param name="allowedInboundCountryList">
        /// List of ISO 3166-1 alpha-2 country codes from which inbound calls are allowed. If not set or empty, calls from all countries are allowed.<br/>
        /// Example: [US, CA, GB]
        /// </param>
        /// <param name="allowedOutboundCountryList">
        /// List of ISO 3166-1 alpha-2 country codes to which outbound calls are allowed. If not set or empty, calls to all countries are allowed.<br/>
        /// Example: [US, CA]
        /// </param>
        /// <param name="transport">
        /// Outbound transport protocol to update for the phone number. Valid values are "TLS", "TCP" and "UDP". Default is "TCP".<br/>
        /// Example: TCP
        /// </param>
        public ImportPhoneNumberRequest(
            string phoneNumber,
            string terminationUri,
            bool? ignoreE164Validation,
            string? sipTrunkAuthUsername,
            string? sipTrunkAuthPassword,
            global::System.Collections.Generic.IList<global::G.AgentWeight>? inboundAgents,
            global::System.Collections.Generic.IList<global::G.AgentWeight>? outboundAgents,
            string? nickname,
            string? inboundWebhookUrl,
            global::System.Collections.Generic.IList<string>? allowedInboundCountryList,
            global::System.Collections.Generic.IList<string>? allowedOutboundCountryList,
            string? transport)
        {
            this.PhoneNumber = phoneNumber ?? throw new global::System.ArgumentNullException(nameof(phoneNumber));
            this.IgnoreE164Validation = ignoreE164Validation;
            this.TerminationUri = terminationUri ?? throw new global::System.ArgumentNullException(nameof(terminationUri));
            this.SipTrunkAuthUsername = sipTrunkAuthUsername;
            this.SipTrunkAuthPassword = sipTrunkAuthPassword;
            this.InboundAgents = inboundAgents;
            this.OutboundAgents = outboundAgents;
            this.Nickname = nickname;
            this.InboundWebhookUrl = inboundWebhookUrl;
            this.AllowedInboundCountryList = allowedInboundCountryList;
            this.AllowedOutboundCountryList = allowedOutboundCountryList;
            this.Transport = transport;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportPhoneNumberRequest" /> class.
        /// </summary>
        public ImportPhoneNumberRequest()
        {
        }
    }
}