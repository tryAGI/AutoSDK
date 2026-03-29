//HintName: G.Models.CreatePhoneNumberRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatePhoneNumberRequest
    {
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
        /// Area code of the number to obtain. Format is a 3 digit integer. Currently only supports US area code.<br/>
        /// Example: 415
        /// </summary>
        /// <example>415</example>
        [global::Newtonsoft.Json.JsonProperty("area_code")]
        public int? AreaCode { get; set; }

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
        /// The provider to purchase the phone number from. Default to twilio.<br/>
        /// Example: twilio
        /// </summary>
        /// <example>twilio</example>
        [global::Newtonsoft.Json.JsonProperty("number_provider")]
        public global::G.CreatePhoneNumberRequestNumberProvider? NumberProvider { get; set; }

        /// <summary>
        /// The ISO 3166-1 alpha-2 country code of the number you are trying to purchase. If left empty, will default to "US".<br/>
        /// Example: US
        /// </summary>
        /// <example>US</example>
        [global::Newtonsoft.Json.JsonProperty("country_code")]
        public global::G.CreatePhoneNumberRequestCountryCode? CountryCode { get; set; }

        /// <summary>
        /// Whether to purchase a toll-free number. Toll-free numbers incur higher costs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("toll_free")]
        public bool? TollFree { get; set; }

        /// <summary>
        /// The number you are trying to purchase in E.164 format of the number (+country code then number with no space and no special characters).<br/>
        /// Example: +14157774444
        /// </summary>
        /// <example>+14157774444</example>
        [global::Newtonsoft.Json.JsonProperty("phone_number")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Outbound transport protocol to use for the phone number. Valid values are "TLS", "TCP" and "UDP". Default is "TCP".<br/>
        /// Example: TCP
        /// </summary>
        /// <example>TCP</example>
        [global::Newtonsoft.Json.JsonProperty("transport")]
        public string? Transport { get; set; }

        /// <summary>
        /// Enterprise only. Phone number to transfer inbound calls to when organization is in outage mode. Can be either a Retell phone number or an external number. Cannot be the same as this phone number, and cannot be a number that already has its own fallback configured (prevents nested forwarding).<br/>
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
        /// Initializes a new instance of the <see cref="CreatePhoneNumberRequest" /> class.
        /// </summary>
        /// <param name="inboundAgents">
        /// Inbound agents to bind to the number with weights. If set and non-empty, one agent will be picked randomly for each inbound call, with probability proportional to the weight. Total weights must add up to 1. If not set or empty, fallback to inbound_agent_id.
        /// </param>
        /// <param name="outboundAgents">
        /// Outbound agents to bind to the number with weights. If set and non-empty, one agent will be picked randomly for each outbound call, with probability proportional to the weight. Total weights must add up to 1. If not set or empty, fallback to outbound_agent_id.
        /// </param>
        /// <param name="areaCode">
        /// Area code of the number to obtain. Format is a 3 digit integer. Currently only supports US area code.<br/>
        /// Example: 415
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
        /// <param name="numberProvider">
        /// The provider to purchase the phone number from. Default to twilio.<br/>
        /// Example: twilio
        /// </param>
        /// <param name="countryCode">
        /// The ISO 3166-1 alpha-2 country code of the number you are trying to purchase. If left empty, will default to "US".<br/>
        /// Example: US
        /// </param>
        /// <param name="tollFree">
        /// Whether to purchase a toll-free number. Toll-free numbers incur higher costs.
        /// </param>
        /// <param name="phoneNumber">
        /// The number you are trying to purchase in E.164 format of the number (+country code then number with no space and no special characters).<br/>
        /// Example: +14157774444
        /// </param>
        /// <param name="transport">
        /// Outbound transport protocol to use for the phone number. Valid values are "TLS", "TCP" and "UDP". Default is "TCP".<br/>
        /// Example: TCP
        /// </param>
        /// <param name="fallbackNumber">
        /// Enterprise only. Phone number to transfer inbound calls to when organization is in outage mode. Can be either a Retell phone number or an external number. Cannot be the same as this phone number, and cannot be a number that already has its own fallback configured (prevents nested forwarding).<br/>
        /// Example: +14155551234
        /// </param>
        public CreatePhoneNumberRequest(
            global::System.Collections.Generic.IList<global::G.AgentWeight>? inboundAgents,
            global::System.Collections.Generic.IList<global::G.AgentWeight>? outboundAgents,
            int? areaCode,
            string? nickname,
            string? inboundWebhookUrl,
            global::System.Collections.Generic.IList<string>? allowedInboundCountryList,
            global::System.Collections.Generic.IList<string>? allowedOutboundCountryList,
            global::G.CreatePhoneNumberRequestNumberProvider? numberProvider,
            global::G.CreatePhoneNumberRequestCountryCode? countryCode,
            bool? tollFree,
            string? phoneNumber,
            string? transport,
            string? fallbackNumber)
        {
            this.InboundAgents = inboundAgents;
            this.OutboundAgents = outboundAgents;
            this.AreaCode = areaCode;
            this.Nickname = nickname;
            this.InboundWebhookUrl = inboundWebhookUrl;
            this.AllowedInboundCountryList = allowedInboundCountryList;
            this.AllowedOutboundCountryList = allowedOutboundCountryList;
            this.NumberProvider = numberProvider;
            this.CountryCode = countryCode;
            this.TollFree = tollFree;
            this.PhoneNumber = phoneNumber;
            this.Transport = transport;
            this.FallbackNumber = fallbackNumber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePhoneNumberRequest" /> class.
        /// </summary>
        public CreatePhoneNumberRequest()
        {
        }
    }
}