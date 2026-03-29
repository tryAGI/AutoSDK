//HintName: G.Models.UpdatePhoneNumberRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdatePhoneNumberRequest
    {
        /// <summary>
        /// Unique id of agent to bind to the number. The number will automatically use the agent when receiving inbound calls. If set to null, this number would not accept inbound call. Deprecated. See https://docs.retellai.com/deprecation-notice/2026/03-31_phone_number_agent_fields<br/>
        /// Example: oBeDLoLOeuAbiuaMFXRtDOLriTJ5tSxD
        /// </summary>
        /// <example>oBeDLoLOeuAbiuaMFXRtDOLriTJ5tSxD</example>
        [global::Newtonsoft.Json.JsonProperty("inbound_agent_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? InboundAgentId { get; set; }

        /// <summary>
        /// Unique id of agent to bind to the number. The number will automatically use the agent when conducting outbound calls. If set to null, this number would not be able to initiate outbound call without agent id override. Deprecated. See https://docs.retellai.com/deprecation-notice/2026/03-31_phone_number_agent_fields<br/>
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
        /// Version of the outbound agent to bind to the number. If not provided, will default to latest version.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("outbound_agent_version")]
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
        /// Inbound SMS agents to bind to the number with weights. If set and non-empty, one agent will be picked randomly for each inbound SMS, with probability proportional to the weight. Total weights must add up to 1. If not set or empty, fallback to inbound_sms_agent_id.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inbound_sms_agents")]
        public global::System.Collections.Generic.IList<global::G.AgentWeight>? InboundSmsAgents { get; set; }

        /// <summary>
        /// Outbound SMS agents to bind to the number with weights. If set and non-empty, one agent will be picked randomly for each outbound SMS, with probability proportional to the weight. Total weights must add up to 1. If not set or empty, fallback to outbound_sms_agent_id.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outbound_sms_agents")]
        public global::System.Collections.Generic.IList<global::G.AgentWeight>? OutboundSmsAgents { get; set; }

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
        /// If set, will send a webhook for inbound SMS, where you can override agent id, set dynamic variables and other fields specific to that chat.<br/>
        /// Example: https://example.com/inbound-sms-webhook
        /// </summary>
        /// <example>https://example.com/inbound-sms-webhook</example>
        [global::Newtonsoft.Json.JsonProperty("inbound_sms_webhook_url")]
        public string? InboundSmsWebhookUrl { get; set; }

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
        /// The termination uri to update for the phone number. This is used for outbound calls.<br/>
        /// Example: someuri.pstn.twilio.com
        /// </summary>
        /// <example>someuri.pstn.twilio.com</example>
        [global::Newtonsoft.Json.JsonProperty("termination_uri")]
        public string? TerminationUri { get; set; }

        /// <summary>
        /// The username used for authentication for the SIP trunk to update for the phone number.<br/>
        /// Example: username
        /// </summary>
        /// <example>username</example>
        [global::Newtonsoft.Json.JsonProperty("auth_username")]
        public string? AuthUsername { get; set; }

        /// <summary>
        /// The password used for authentication for the SIP trunk to update for the phone number.<br/>
        /// Example: 123456
        /// </summary>
        /// <example>123456</example>
        [global::Newtonsoft.Json.JsonProperty("auth_password")]
        public string? AuthPassword { get; set; }

        /// <summary>
        /// Outbound transport protocol to update for the phone number. Valid values are "TLS", "TCP" and "UDP". Default is "TCP".<br/>
        /// Example: TCP
        /// </summary>
        /// <example>TCP</example>
        [global::Newtonsoft.Json.JsonProperty("transport")]
        public string? Transport { get; set; }

        /// <summary>
        /// Enterprise only. Phone number to transfer inbound calls to when organization is in outage mode. Can be either a Retell phone number or an external number. Set to null to remove. Cannot be the same as this phone number, and cannot be a number that already has its own fallback configured (prevents nested forwarding).<br/>
        /// Example: +14155551234
        /// </summary>
        /// <example>+14155551234</example>
        [global::Newtonsoft.Json.JsonProperty("fallback_number")]
        public string? FallbackNumber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePhoneNumberRequest" /> class.
        /// </summary>
        /// <param name="outboundAgentVersion">
        /// Version of the outbound agent to bind to the number. If not provided, will default to latest version.<br/>
        /// Example: 1
        /// </param>
        /// <param name="inboundAgents">
        /// Inbound agents to bind to the number with weights. If set and non-empty, one agent will be picked randomly for each inbound call, with probability proportional to the weight. Total weights must add up to 1. If not set or empty, fallback to inbound_agent_id.
        /// </param>
        /// <param name="outboundAgents">
        /// Outbound agents to bind to the number with weights. If set and non-empty, one agent will be picked randomly for each outbound call, with probability proportional to the weight. Total weights must add up to 1. If not set or empty, fallback to outbound_agent_id.
        /// </param>
        /// <param name="inboundSmsAgents">
        /// Inbound SMS agents to bind to the number with weights. If set and non-empty, one agent will be picked randomly for each inbound SMS, with probability proportional to the weight. Total weights must add up to 1. If not set or empty, fallback to inbound_sms_agent_id.
        /// </param>
        /// <param name="outboundSmsAgents">
        /// Outbound SMS agents to bind to the number with weights. If set and non-empty, one agent will be picked randomly for each outbound SMS, with probability proportional to the weight. Total weights must add up to 1. If not set or empty, fallback to outbound_sms_agent_id.
        /// </param>
        /// <param name="nickname">
        /// Nickname of the number. This is for your reference only.<br/>
        /// Example: Frontdesk Number
        /// </param>
        /// <param name="inboundWebhookUrl">
        /// If set, will send a webhook for inbound calls, where you can to override agent id, set dynamic variables and other fields specific to that call.<br/>
        /// Example: https://example.com/inbound-webhook
        /// </param>
        /// <param name="inboundSmsWebhookUrl">
        /// If set, will send a webhook for inbound SMS, where you can override agent id, set dynamic variables and other fields specific to that chat.<br/>
        /// Example: https://example.com/inbound-sms-webhook
        /// </param>
        /// <param name="allowedInboundCountryList">
        /// List of ISO 3166-1 alpha-2 country codes from which inbound calls are allowed. If not set or empty, calls from all countries are allowed.<br/>
        /// Example: [US, CA, GB]
        /// </param>
        /// <param name="allowedOutboundCountryList">
        /// List of ISO 3166-1 alpha-2 country codes to which outbound calls are allowed. If not set or empty, calls to all countries are allowed.<br/>
        /// Example: [US, CA]
        /// </param>
        /// <param name="terminationUri">
        /// The termination uri to update for the phone number. This is used for outbound calls.<br/>
        /// Example: someuri.pstn.twilio.com
        /// </param>
        /// <param name="authUsername">
        /// The username used for authentication for the SIP trunk to update for the phone number.<br/>
        /// Example: username
        /// </param>
        /// <param name="authPassword">
        /// The password used for authentication for the SIP trunk to update for the phone number.<br/>
        /// Example: 123456
        /// </param>
        /// <param name="transport">
        /// Outbound transport protocol to update for the phone number. Valid values are "TLS", "TCP" and "UDP". Default is "TCP".<br/>
        /// Example: TCP
        /// </param>
        /// <param name="fallbackNumber">
        /// Enterprise only. Phone number to transfer inbound calls to when organization is in outage mode. Can be either a Retell phone number or an external number. Set to null to remove. Cannot be the same as this phone number, and cannot be a number that already has its own fallback configured (prevents nested forwarding).<br/>
        /// Example: +14155551234
        /// </param>
        public UpdatePhoneNumberRequest(
            int? outboundAgentVersion,
            global::System.Collections.Generic.IList<global::G.AgentWeight>? inboundAgents,
            global::System.Collections.Generic.IList<global::G.AgentWeight>? outboundAgents,
            global::System.Collections.Generic.IList<global::G.AgentWeight>? inboundSmsAgents,
            global::System.Collections.Generic.IList<global::G.AgentWeight>? outboundSmsAgents,
            string? nickname,
            string? inboundWebhookUrl,
            string? inboundSmsWebhookUrl,
            global::System.Collections.Generic.IList<string>? allowedInboundCountryList,
            global::System.Collections.Generic.IList<string>? allowedOutboundCountryList,
            string? terminationUri,
            string? authUsername,
            string? authPassword,
            string? transport,
            string? fallbackNumber)
        {
            this.OutboundAgentVersion = outboundAgentVersion;
            this.InboundAgents = inboundAgents;
            this.OutboundAgents = outboundAgents;
            this.InboundSmsAgents = inboundSmsAgents;
            this.OutboundSmsAgents = outboundSmsAgents;
            this.Nickname = nickname;
            this.InboundWebhookUrl = inboundWebhookUrl;
            this.InboundSmsWebhookUrl = inboundSmsWebhookUrl;
            this.AllowedInboundCountryList = allowedInboundCountryList;
            this.AllowedOutboundCountryList = allowedOutboundCountryList;
            this.TerminationUri = terminationUri;
            this.AuthUsername = authUsername;
            this.AuthPassword = authPassword;
            this.Transport = transport;
            this.FallbackNumber = fallbackNumber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePhoneNumberRequest" /> class.
        /// </summary>
        public UpdatePhoneNumberRequest()
        {
        }
    }
}