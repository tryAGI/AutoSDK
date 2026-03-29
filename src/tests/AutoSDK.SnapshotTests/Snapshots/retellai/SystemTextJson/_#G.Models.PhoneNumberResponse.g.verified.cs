//HintName: G.Models.PhoneNumberResponse.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PhoneNumberResponse
    {
        /// <summary>
        /// E.164 format of the number (+country code, then number with no space, no special characters), used as the unique identifier for phone number APIs.<br/>
        /// Example: +14157774444
        /// </summary>
        /// <example>+14157774444</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PhoneNumber { get; set; }

        /// <summary>
        /// Type of the phone number.<br/>
        /// Example: retell-twilio
        /// </summary>
        /// <example>retell-twilio</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_number_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PhoneNumberResponsePhoneNumberTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PhoneNumberResponsePhoneNumberType PhoneNumberType { get; set; }

        /// <summary>
        /// Pretty printed phone number, provided for your reference.<br/>
        /// Example: +1 (415) 777-4444
        /// </summary>
        /// <example>+1 (415) 777-4444</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_number_pretty")]
        public string? PhoneNumberPretty { get; set; }

        /// <summary>
        /// Unique id of agent to bind to the number. The number will automatically use the agent when receiving inbound calls. If null, this number would not accept inbound call. Deprecated. See https://docs.retellai.com/deprecation-notice/2026/03-31_phone_number_agent_fields<br/>
        /// Example: oBeDLoLOeuAbiuaMFXRtDOLriTJ5tSxD
        /// </summary>
        /// <example>oBeDLoLOeuAbiuaMFXRtDOLriTJ5tSxD</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("inbound_agent_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? InboundAgentId { get; set; }

        /// <summary>
        /// Unique id of agent to bind to the number. The number will automatically use the agent when conducting outbound calls. If null, this number would not be able to initiate outbound call without agent id override. Deprecated. See https://docs.retellai.com/deprecation-notice/2026/03-31_phone_number_agent_fields<br/>
        /// Example: oBeDLoLOeuAbiuaMFXRtDOLriTJ5tSxD
        /// </summary>
        /// <example>oBeDLoLOeuAbiuaMFXRtDOLriTJ5tSxD</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("outbound_agent_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? OutboundAgentId { get; set; }

        /// <summary>
        /// Version of the inbound agent to bind to the number. If not provided, will default to latest version. Deprecated. See https://docs.retellai.com/deprecation-notice/2026/03-31_phone_number_agent_fields<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("inbound_agent_version")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? InboundAgentVersion { get; set; }

        /// <summary>
        /// Version of the outbound agent to bind to the number. If not provided, will default to latest version. Deprecated. See https://docs.retellai.com/deprecation-notice/2026/03-31_phone_number_agent_fields<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("outbound_agent_version")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? OutboundAgentVersion { get; set; }

        /// <summary>
        /// List of ISO 3166-1 alpha-2 country codes from which inbound calls are allowed. If not set or empty, calls from all countries are allowed.<br/>
        /// Example: [US, CA, GB]
        /// </summary>
        /// <example>[US, CA, GB]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_inbound_country_list")]
        public global::System.Collections.Generic.IList<string>? AllowedInboundCountryList { get; set; }

        /// <summary>
        /// List of ISO 3166-1 alpha-2 country codes to which outbound calls are allowed. If not set or empty, calls to all countries are allowed.<br/>
        /// Example: [US, CA]
        /// </summary>
        /// <example>[US, CA]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_outbound_country_list")]
        public global::System.Collections.Generic.IList<string>? AllowedOutboundCountryList { get; set; }

        /// <summary>
        /// Area code of the number to obtain. Format is a 3 digit integer. Currently only supports US area code.<br/>
        /// Example: 415
        /// </summary>
        /// <example>415</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("area_code")]
        public int? AreaCode { get; set; }

        /// <summary>
        /// Inbound agents to bind to the number with weights. If set and non-empty, one agent will be picked randomly for each inbound call, with probability proportional to the weight. Total weights must add up to 1. If not set or empty, fallback to inbound_agent_id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inbound_agents")]
        public global::System.Collections.Generic.IList<global::G.AgentWeight>? InboundAgents { get; set; }

        /// <summary>
        /// Outbound agents to bind to the number with weights. If set and non-empty, one agent will be picked randomly for each outbound call, with probability proportional to the weight. Total weights must add up to 1. If not set or empty, fallback to outbound_agent_id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outbound_agents")]
        public global::System.Collections.Generic.IList<global::G.AgentWeight>? OutboundAgents { get; set; }

        /// <summary>
        /// Inbound SMS agents to bind to the number with weights. If set and non-empty, one agent will be picked randomly for each inbound SMS, with probability proportional to the weight. Total weights must add up to 1. If not set or empty, fallback to inbound_sms_agent_id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inbound_sms_agents")]
        public global::System.Collections.Generic.IList<global::G.AgentWeight>? InboundSmsAgents { get; set; }

        /// <summary>
        /// Outbound SMS agents to bind to the number with weights. If set and non-empty, one agent will be picked randomly for each outbound SMS, with probability proportional to the weight. Total weights must add up to 1. If not set or empty, fallback to outbound_sms_agent_id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outbound_sms_agents")]
        public global::System.Collections.Generic.IList<global::G.AgentWeight>? OutboundSmsAgents { get; set; }

        /// <summary>
        /// Nickname of the number. This is for your reference only.<br/>
        /// Example: Frontdesk Number
        /// </summary>
        /// <example>Frontdesk Number</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("nickname")]
        public string? Nickname { get; set; }

        /// <summary>
        /// If set, will send a webhook for inbound calls, where you can to override agent id, set dynamic variables and other fields specific to that call.<br/>
        /// Example: https://example.com/inbound-webhook
        /// </summary>
        /// <example>https://example.com/inbound-webhook</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("inbound_webhook_url")]
        public string? InboundWebhookUrl { get; set; }

        /// <summary>
        /// If set, will send a webhook for inbound SMS, where you can override agent id, set dynamic variables and other fields specific to that chat.<br/>
        /// Example: https://example.com/inbound-sms-webhook
        /// </summary>
        /// <example>https://example.com/inbound-sms-webhook</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("inbound_sms_webhook_url")]
        public string? InboundSmsWebhookUrl { get; set; }

        /// <summary>
        /// Last modification timestamp (milliseconds since epoch). Either the time of last update or creation if no updates available.<br/>
        /// Example: 1703413636133
        /// </summary>
        /// <example>1703413636133</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_modification_timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long LastModificationTimestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sip_outbound_trunk_config")]
        public global::G.PhoneNumberResponseSipOutboundTrunkConfig? SipOutboundTrunkConfig { get; set; }

        /// <summary>
        /// Enterprise only. Phone number to transfer inbound calls to when organization is in outage mode. Can be either a Retell phone number or an external number. Cannot be the same as this phone number, and cannot be a number that already has its own fallback configured (prevents nested forwarding).<br/>
        /// Example: +14155551234
        /// </summary>
        /// <example>+14155551234</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallback_number")]
        public string? FallbackNumber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberResponse" /> class.
        /// </summary>
        /// <param name="phoneNumber">
        /// E.164 format of the number (+country code, then number with no space, no special characters), used as the unique identifier for phone number APIs.<br/>
        /// Example: +14157774444
        /// </param>
        /// <param name="phoneNumberType">
        /// Type of the phone number.<br/>
        /// Example: retell-twilio
        /// </param>
        /// <param name="lastModificationTimestamp">
        /// Last modification timestamp (milliseconds since epoch). Either the time of last update or creation if no updates available.<br/>
        /// Example: 1703413636133
        /// </param>
        /// <param name="phoneNumberPretty">
        /// Pretty printed phone number, provided for your reference.<br/>
        /// Example: +1 (415) 777-4444
        /// </param>
        /// <param name="allowedInboundCountryList">
        /// List of ISO 3166-1 alpha-2 country codes from which inbound calls are allowed. If not set or empty, calls from all countries are allowed.<br/>
        /// Example: [US, CA, GB]
        /// </param>
        /// <param name="allowedOutboundCountryList">
        /// List of ISO 3166-1 alpha-2 country codes to which outbound calls are allowed. If not set or empty, calls to all countries are allowed.<br/>
        /// Example: [US, CA]
        /// </param>
        /// <param name="areaCode">
        /// Area code of the number to obtain. Format is a 3 digit integer. Currently only supports US area code.<br/>
        /// Example: 415
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
        /// <param name="sipOutboundTrunkConfig"></param>
        /// <param name="fallbackNumber">
        /// Enterprise only. Phone number to transfer inbound calls to when organization is in outage mode. Can be either a Retell phone number or an external number. Cannot be the same as this phone number, and cannot be a number that already has its own fallback configured (prevents nested forwarding).<br/>
        /// Example: +14155551234
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PhoneNumberResponse(
            string phoneNumber,
            global::G.PhoneNumberResponsePhoneNumberType phoneNumberType,
            long lastModificationTimestamp,
            string? phoneNumberPretty,
            global::System.Collections.Generic.IList<string>? allowedInboundCountryList,
            global::System.Collections.Generic.IList<string>? allowedOutboundCountryList,
            int? areaCode,
            global::System.Collections.Generic.IList<global::G.AgentWeight>? inboundAgents,
            global::System.Collections.Generic.IList<global::G.AgentWeight>? outboundAgents,
            global::System.Collections.Generic.IList<global::G.AgentWeight>? inboundSmsAgents,
            global::System.Collections.Generic.IList<global::G.AgentWeight>? outboundSmsAgents,
            string? nickname,
            string? inboundWebhookUrl,
            string? inboundSmsWebhookUrl,
            global::G.PhoneNumberResponseSipOutboundTrunkConfig? sipOutboundTrunkConfig,
            string? fallbackNumber)
        {
            this.PhoneNumber = phoneNumber ?? throw new global::System.ArgumentNullException(nameof(phoneNumber));
            this.PhoneNumberType = phoneNumberType;
            this.PhoneNumberPretty = phoneNumberPretty;
            this.AllowedInboundCountryList = allowedInboundCountryList;
            this.AllowedOutboundCountryList = allowedOutboundCountryList;
            this.AreaCode = areaCode;
            this.InboundAgents = inboundAgents;
            this.OutboundAgents = outboundAgents;
            this.InboundSmsAgents = inboundSmsAgents;
            this.OutboundSmsAgents = outboundSmsAgents;
            this.Nickname = nickname;
            this.InboundWebhookUrl = inboundWebhookUrl;
            this.InboundSmsWebhookUrl = inboundSmsWebhookUrl;
            this.LastModificationTimestamp = lastModificationTimestamp;
            this.SipOutboundTrunkConfig = sipOutboundTrunkConfig;
            this.FallbackNumber = fallbackNumber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberResponse" /> class.
        /// </summary>
        public PhoneNumberResponse()
        {
        }
    }
}