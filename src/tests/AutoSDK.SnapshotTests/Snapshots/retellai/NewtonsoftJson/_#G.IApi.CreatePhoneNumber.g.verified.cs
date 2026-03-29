//HintName: G.IApi.CreatePhoneNumber.g.cs
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Buy a new phone number &amp; Bind agents
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PhoneNumberResponse> CreatePhoneNumberAsync(

            global::G.CreatePhoneNumberRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Buy a new phone number &amp; Bind agents
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PhoneNumberResponse> CreatePhoneNumberAsync(
            global::System.Collections.Generic.IList<global::G.AgentWeight>? inboundAgents = default,
            global::System.Collections.Generic.IList<global::G.AgentWeight>? outboundAgents = default,
            int? areaCode = default,
            string? nickname = default,
            string? inboundWebhookUrl = default,
            global::System.Collections.Generic.IList<string>? allowedInboundCountryList = default,
            global::System.Collections.Generic.IList<string>? allowedOutboundCountryList = default,
            global::G.CreatePhoneNumberRequestNumberProvider? numberProvider = default,
            global::G.CreatePhoneNumberRequestCountryCode? countryCode = default,
            bool? tollFree = default,
            string? phoneNumber = default,
            string? transport = default,
            string? fallbackNumber = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}