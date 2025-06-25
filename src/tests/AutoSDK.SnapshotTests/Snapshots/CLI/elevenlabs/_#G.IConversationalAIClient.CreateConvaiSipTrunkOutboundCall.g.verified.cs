//HintName: G.IConversationalAIClient.CreateConvaiSipTrunkOutboundCall.g.cs
#nullable enable

namespace G
{
    public partial interface IConversationalAIClient
    {
        /// <summary>
        /// Handle An Outbound Call Via Sip Trunk<br/>
        /// Handle an outbound call via SIP trunk
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SIPTrunkOutboundCallResponse> CreateConvaiSipTrunkOutboundCallAsync(
            global::G.BodyHandleAnOutboundCallViaSIPTrunkV1ConvaiSipTrunkOutboundCallPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Handle An Outbound Call Via Sip Trunk<br/>
        /// Handle an outbound call via SIP trunk
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="agentId"></param>
        /// <param name="agentPhoneNumberId"></param>
        /// <param name="toNumber"></param>
        /// <param name="conversationInitiationClientData"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SIPTrunkOutboundCallResponse> CreateConvaiSipTrunkOutboundCallAsync(
            string agentId,
            string agentPhoneNumberId,
            string toNumber,
            string? xiApiKey = default,
            global::G.ConversationInitiationClientDataRequestInput? conversationInitiationClientData = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}