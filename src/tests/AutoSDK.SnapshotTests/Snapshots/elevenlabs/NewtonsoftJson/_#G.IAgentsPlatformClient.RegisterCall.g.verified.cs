//HintName: G.IAgentsPlatformClient.RegisterCall.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Register A Twilio Call And Return Twiml<br/>
        /// Register a Twilio call and return TwiML to connect the call
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> RegisterCallAsync(

            global::G.BodyRegisterATwilioCallAndReturnTwiMLV1ConvaiTwilioRegisterCallPost request,
            string? xiApiKey = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Register A Twilio Call And Return Twiml<br/>
        /// Register a Twilio call and return TwiML to connect the call
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="agentId"></param>
        /// <param name="fromNumber"></param>
        /// <param name="toNumber"></param>
        /// <param name="direction">
        /// Default Value: inbound
        /// </param>
        /// <param name="conversationInitiationClientData"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> RegisterCallAsync(
            string agentId,
            string fromNumber,
            string toNumber,
            string? xiApiKey = default,
            global::G.BodyRegisterATwilioCallAndReturnTwiMLV1ConvaiTwilioRegisterCallPostDirection? direction = default,
            global::G.ConversationInitiationClientDataRequestInput? conversationInitiationClientData = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}