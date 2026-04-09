//HintName: G.IApi.ImportPhoneNumber.g.cs
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Import a phone number from custom telephony &amp; Bind agents
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PhoneNumberResponse> ImportPhoneNumberAsync(

            global::G.ImportPhoneNumberRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Import a phone number from custom telephony &amp; Bind agents
        /// </summary>
        /// <param name="phoneNumber">
        /// The number you are trying to import in E.164 format of the number (+country code, then number with no space, no special characters), used as the unique identifier for phone number APIs.<br/>
        /// Example: +14157774444
        /// </param>
        /// <param name="ignoreE164Validation">
        /// If true, E.164 validation for phone_number is skipped. This is useful for internal pseudo numbers when using custom telephony. If omitted, default is true. Must be a boolean literal; string values like "true" or "false" are invalid.<br/>
        /// Example: true
        /// </param>
        /// <param name="terminationUri">
        /// The termination uri to uniquely identify your elastic SIP trunk. This is used for outbound calls. For Twilio elastic SIP trunks it always end with ".pstn.twilio.com".<br/>
        /// Example: someuri.pstn.twilio.com
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PhoneNumberResponse> ImportPhoneNumberAsync(
            string phoneNumber,
            string terminationUri,
            bool? ignoreE164Validation = default,
            string? sipTrunkAuthUsername = default,
            string? sipTrunkAuthPassword = default,
            global::System.Collections.Generic.IList<global::G.AgentWeight>? inboundAgents = default,
            global::System.Collections.Generic.IList<global::G.AgentWeight>? outboundAgents = default,
            string? nickname = default,
            string? inboundWebhookUrl = default,
            global::System.Collections.Generic.IList<string>? allowedInboundCountryList = default,
            global::System.Collections.Generic.IList<string>? allowedOutboundCountryList = default,
            string? transport = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}