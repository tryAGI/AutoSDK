//HintName: G.IApi.UpdatePhoneNumber.g.cs
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Update agent bound to a purchased phone number
        /// </summary>
        /// <param name="phoneNumber">
        /// Example: +14157774444
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PhoneNumberResponse> UpdatePhoneNumberAsync(
            string phoneNumber,

            global::G.UpdatePhoneNumberRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update agent bound to a purchased phone number
        /// </summary>
        /// <param name="phoneNumber">
        /// Example: +14157774444
        /// </param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PhoneNumberResponse> UpdatePhoneNumberAsync(
            string phoneNumber,
            int? outboundAgentVersion = default,
            global::System.Collections.Generic.IList<global::G.AgentWeight>? inboundAgents = default,
            global::System.Collections.Generic.IList<global::G.AgentWeight>? outboundAgents = default,
            global::System.Collections.Generic.IList<global::G.AgentWeight>? inboundSmsAgents = default,
            global::System.Collections.Generic.IList<global::G.AgentWeight>? outboundSmsAgents = default,
            string? nickname = default,
            string? inboundWebhookUrl = default,
            string? inboundSmsWebhookUrl = default,
            global::System.Collections.Generic.IList<string>? allowedInboundCountryList = default,
            global::System.Collections.Generic.IList<string>? allowedOutboundCountryList = default,
            string? terminationUri = default,
            string? authUsername = default,
            string? authPassword = default,
            string? transport = default,
            string? fallbackNumber = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}